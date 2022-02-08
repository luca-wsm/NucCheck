using NucCheck.Constants;
using NucCheck.Services;
using System;
using System.Windows.Forms;

namespace NucCheck
{
    public partial class Panel : Form
    {
        private MessageBoxService _messageBoxService;
        private SMTPSaveService _saveService;
        private ScrapeService _scrapeService;
        public ComparerPanel _comparerPanel;
        public EmailSettingsPanel _emailSettingsPanel;

        public bool mainPanelHidden = false;
        public bool comparerPanelHidden = false;
        public int threadDelay = 5000;

        public Panel()
        {
            InitializeComponent();
            _messageBoxService = new MessageBoxService();
            notificationValueBox.Enabled = false;
            notificationTypeBox.SelectedIndex = 0;
            notifyIcon.Visible = false;
        }

        private async void startBttn_Click(object sender, EventArgs e)
        {
            ClearLog();

            if (ValidateUserInputs() && new CURLService().CallUrl(targetWebsiteBox.Text, this))
            {

                if (notificationTypeBox.SelectedIndex == 0)
                {
                    _saveService = new SMTPSaveService();
                    if (!_saveService.ConfigurationExists())
                    {
                        ClearLog();
                        _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_SMTP_CONFIG_NOT_EXISTS_SCRAPING);
                        return;
                    }
                }
                else
                {
                    if (notificationValueBox.Text == String.Empty)
                    {
                        ClearLog();
                        _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_NO_NOTIFICATION_VALUE_SELECTED);
                    }
                }
                _scrapeService = new ScrapeService(targetWebsiteBox.Text, searchStringBox.Text, notificationTypeBox.SelectedIndex, notificationValueBox.Text);

                var stringFound = await _scrapeService.StringFound();

                if (!stringFound)
                {
                    ClearLog();
                    _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_SEARCH_STRING_NOT_FOUND);
                    return;
                }

                StartFormButtons();
                _scrapeService.startThread();
            }
        }

        private void stopBttn_Click(object sender, EventArgs e)
        {
            ClearLog();
            StopFormButtons();
            _scrapeService.KillThread();
        }

        /// <summary>
        /// Sets the Delay for the ScrpeThread.
        /// * 1000 because the Thread.Sleep Method uses milliseconds.
        /// </summary>
        private void threadTimeOut_ValueChanged(object sender, EventArgs e)
        {
            threadDelay = (int)(1000 * threadTimeOut.Value);
        }

        private void emailSettingsBttn_Click(object sender, EventArgs e)
        {
            if (_emailSettingsPanel == null)
            {
                _emailSettingsPanel = new EmailSettingsPanel();
                _emailSettingsPanel.Show();
            }
            else
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_EMAIL_PANEL_INIT);
            }
        }

        private void notificationTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (notificationTypeBox.SelectedIndex == 0)
            {
                notificationValueBox.Enabled = false;
            }
            else
            {
                notificationValueBox.Enabled = true;
            }
        }

        private void helpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _messageBoxService.Send(MessageBoxType.INFORMATION, MessageConstants.MESSAGEBOX_PANEL_HELP_BUTTON);
        }

        private void comparerBttn_Click(object sender, EventArgs e)
        {
            if (_comparerPanel == null)
            {
                _comparerPanel = new ComparerPanel();
                _comparerPanel.Show();
            } else if (comparerPanelHidden)
            {
                _comparerPanel.Show();
                comparerPanelHidden = false;
            }
            else
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_COMPARER_PANEL_INIT);
            }
        }

        /// <summary>
        /// Checks if all UserInputs are valid and set like <example>targetWebsite</example>.
        /// </summary>
        /// <returns>False if one thing is not valid and shows a error message box.</returns>
        private bool ValidateUserInputs()
        {
            if (notificationTypeBox.SelectedItem == null)
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_NO_NOTIFICATION_SELECTED);
                return false;
            }

            if (notificationTypeBox.SelectedIndex == 1 && notificationValueBox.Text == string.Empty)
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_NO_NOTIFICATION_VALUE_SELECTED);
                return false;
            }

            if (targetWebsiteBox.Text == string.Empty)
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_TARGET_WEBISTE_EMPTY);
                return false;
            }

            if (searchStringBox.Text == string.Empty)
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_SEARCH_STRING_EMPTY);
                return false;
            }

            return true;
        }

        /// <summary>
        /// This is the message that will be shown in the logBox when the Scraping starts.
        /// This method will be called from the CURLService after the Server answered.
        /// </summary>
        /// <param name="answer">The answer string from the CURLService, this should be always "Server answered OK"</param>
        public void ShowStartMessage(String answer)
        {
            AddLogItem("▶ —————————————————————— ◀");
            AddLogItem("");
            AddLogItem("» NucCheck Scraper started succesfully");
            AddLogItem("» Developed by Luca Wesemann");
            AddLogItem("");
            AddLogItem("» " + answer);
            AddLogItem("");
            AddLogItem("▶ —————————————————————— ◀");
            AddLogItem("");
        }

        /// <summary>
        /// This method will set all Buttons into the Comparer Mode.
        /// <example>Disables the startButton</example>
        /// </summary>
        public void StartFormButtons()
        {
            startBttn.Enabled = false;
            stopBttn.Enabled = true;
            notificationTypeBox.Enabled = false;
            notificationValueBox.Enabled = false;
            emailSettingsBttn.Enabled = false;
            targetWebsiteBox.Enabled = false;
            searchStringBox.Enabled = true;
            searchStringBox.Enabled = false;
        }

        /// <summary>
        /// This method will set all Buttons into the Idle Mode.
        /// We need to invoke this method because it will be called from the ScrapeThread.
        /// <example>Enables the startButton</example>
        /// </summary>
        public void StopFormButtons()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { this.StopFormButtons(); });
                return;
            }
            ClearLog();
            startBttn.Enabled = true;
            stopBttn.Enabled = false;
            notificationTypeBox.Enabled = true;
            notificationValueBox.Enabled = true;
            emailSettingsBttn.Enabled = true;
            targetWebsiteBox.Enabled = true;
            searchStringBox.Enabled = true;
        }

        /// <summary>
        /// Adds a item to the logBox.
        /// We need to invoke this method because it will be called from the ScrapeThread.
        /// </summary>
        public void AddLogItem(string item)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { this.AddLogItem(item); });
                return;
            }
            logBox.Items.Add(item);
            logBox.SelectedIndex = logBox.Items.Count - 1;

        }

        /// <summary>
        /// This method clears the logBox.
        /// </summary>
        public void ClearLog()
        { //TODO: Call when the LogBox Size is too big ( ram issue )
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { this.ClearLog(); });
                return;
            }
            logBox.Items.Clear();
        }

        private void Panel_Load(object sender, EventArgs e)
        {
        }

        private void hidePanelButton_Click(object sender, EventArgs e)
        {
            mainPanelHidden = true;
            this.Hide();
            notifyIcon.Visible = true;

            notifyIcon.BalloonTipText = MessageConstants.MESSAGEBOX_PANEL_HIDDEN;
            notifyIcon.BalloonTipTitle = MessageConstants.MESSAGEBOX_INFORMATION_TITLE;
            notifyIcon.ShowBalloonTip(2000);
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (mainPanelHidden && comparerPanelHidden)
            {
                this.Show();
                _comparerPanel.Show();
            }

            if (mainPanelHidden)
            {
                this.Show();
            }
            if (comparerPanelHidden)
            {
                _comparerPanel.Show();
            }
        }
    }
}
