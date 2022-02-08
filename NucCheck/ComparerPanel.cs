using NucCheck.Constants;
using NucCheck.Services;
using System;
using System.Threading;
using System.Windows.Forms;

namespace NucCheck
{
    public partial class ComparerPanel : Form
    {
        private MessageBoxService _messageBoxService;
        private SMTPSaveService _saveService;
        private ComparerService _comparerService;
        public int threadDelay = 5000;

        public ComparerPanel()
        {
            InitializeComponent();
            notificationValueBox.Enabled = false;
            notificationTypeBox.SelectedIndex = 0;
            _messageBoxService = new MessageBoxService();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (_comparerService != null) { _comparerService.KillThread(); } // If the comparer thread is running we kill the thread, because we create every time a new panel instance.
            _comparerService = null;
            Program.getInstance()._comparerPanel = null;
            Program.getInstance().comparerPanelHidden = false;
        }

        private void emailSettingsBttn_Click(object sender, EventArgs e)
        {
            if (Program.getInstance()._emailSettingsPanel == null)
            {
                Program.getInstance()._emailSettingsPanel = new EmailSettingsPanel();
                Program.getInstance()._emailSettingsPanel.Show();
            }
            else
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_EMAIL_PANEL_INIT);
            }
        }

        private void startBttn_Click(object sender, EventArgs e)
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
                        return;
                    }
                }

                StartButtons();
                _comparerService = new ComparerService();
                _comparerService._url = targetWebsiteBox.Text;
                _comparerService._choosenMethod = notificationTypeBox.SelectedIndex;
                _comparerService._notificationValue = notificationValueBox.Text;
                _comparerService.StartThread();
            }
        }

        private void stopBttn_Click(object sender, EventArgs e)
        {
            _comparerService.KillThread();
            _comparerService = null;
            Thread.Sleep(2000); // 2sec sleeping that the user cant spam the start and stop button.
            StopButtons();
            ClearLog();
        }

        private void notificationTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (notificationTypeBox.SelectedIndex != 0)
            {
                notificationValueBox.Enabled = true;
            }
            else
            {
                notificationValueBox.Text = String.Empty;
                notificationValueBox.Enabled = false;
            }
        }

        private void threadDelayUpDown_ValueChanged(object sender, EventArgs e)
        {
            threadDelay = (int)(1000 * threadDelayUpDown.Value); // *1000 because the Thread.Sleep method uses milliseconds.
        }

        /// <summary>
        /// Checks if the user given inputs are valid
        /// </summary>
        /// <returns>True when all inputs are valid / not empty</returns>
        private bool ValidateUserInputs()
        {
            if (targetWebsiteBox.Text == String.Empty)
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_TARGET_WEBISTE_EMPTY);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Adds a item to the logBox.
        /// We need to invoke this method because it will be called from the CompareThread.
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

        /// <summary>
        /// This message will be shown in the logbox when the comparing starts.
        /// This method only will be called from the CallURL Method from the CURLService.
        /// </summary>
        /// <param name="answer">The answer from the CURL Client.</param>
        public void ShowStartMessage(String answer)
        {
            AddLogItem("▶ —————————————————————— ◀");
            AddLogItem("");
            AddLogItem("» NucCheck Comparer started succesfully");
            AddLogItem("» Developed by Luca Wesemann");
            AddLogItem("");
            AddLogItem("» " + answer);
            AddLogItem("");
            AddLogItem("▶ —————————————————————— ◀");
            AddLogItem("");
        }

        /// <summary>
        /// This method will be called when the start button pressed
        /// </summary>
        public void StartButtons()
        {
            startBttn.Enabled = false;
            targetWebsiteBox.Enabled = false;
            threadDelayUpDown.Enabled = false;
            stopBttn.Enabled = true;
            notificationTypeBox.Enabled = false;
            notificationValueBox.Enabled = false;
            emailSettingsBttn.Enabled = false;
        }

        /// <summary>
        /// This method will be called when the stop button pressed.
        /// We need to invoke this method because it will be called from the CompareThread.
        /// </summary>
        public void StopButtons()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { this.StopButtons(); });
                return;
            }
            targetWebsiteBox.Enabled = true;
            threadDelayUpDown.Enabled = true;
            stopBttn.Enabled = false;
            startBttn.Enabled = true;
            notificationTypeBox.Enabled = true;
            emailSettingsBttn.Enabled = true;
        }

        private void hidePanelBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.getInstance().comparerPanelHidden = true;
            Program.getInstance().notifyIcon.Visible = true;

            Program.getInstance().notifyIcon.BalloonTipText = MessageConstants.MESSAGEBOX_PANEL_HIDDEN;
            Program.getInstance().notifyIcon.BalloonTipTitle = MessageConstants.MESSAGEBOX_INFORMATION_TITLE;
            Program.getInstance().notifyIcon.ShowBalloonTip(2000);
        }
    }
}
