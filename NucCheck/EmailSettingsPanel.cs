using NucCheck.Constants;
using NucCheck.Objects;
using NucCheck.Services;
using System;
using System.Text.Json;
using System.Windows.Forms;

namespace NucCheck
{
    public partial class EmailSettingsPanel : Form
    {

        private MessageBoxService _messageBoxService;
        private SMTPSaveService _smtpSaveService;
        private bool testMailSend = false; // This boolean is used for the saveConfiguration feature, we can only save a smtp config after we tested the credentials.

        public EmailSettingsPanel()
        {
            InitializeComponent();
            _messageBoxService = new MessageBoxService();
            _smtpSaveService = new SMTPSaveService();
        }

        private void saveConfigurationBttn_Click(object sender, EventArgs e)
        {

            if (IsStringValid(smtpServerBox.Text) && IsStringValid(smtpPort.Text) &&
               IsStringValid(smtpPasswordBox.Text) && IsStringValid(smtpEmailBox.Text) &&
               IsStringValid(targetEmailBox.Text) && IsStringValid(emailSubjectBox.Text))
            {

                var settings = new SMTPSetting()
                {
                    smtpServer = smtpServerBox.Text,
                    port = int.Parse(smtpPort.Text),
                    smtpEmail = smtpEmailBox.Text,
                    smtpPassword = smtpPasswordBox.Text,
                    useSSL = true,
                    targetEmail = targetEmailBox.Text,
                    emailBody = emailContentBox.Text,
                    emailSubject = emailSubjectBox.Text
                };

                if (_smtpSaveService.ConfigurationExists())
                {

                    var settingsJson = JsonSerializer.Serialize(settings, new JsonSerializerOptions()
                    {
                        WriteIndented = true
                    });

                    var storedJson = _smtpSaveService.GetJsonRawConfiguration(); // We can use typeOf, but this is more particularly

                    if (settingsJson == storedJson)
                    {
                        _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_CONFIG_IS_THE_SAME); // The given parameters are the same like in the config
                        return;
                    }

                    var result = MessageBox.Show(MessageConstants.MESSAGEBOX_SMTP_CONFIG_ALREADY_EXISTS, MessageConstants.MESSAGEBOX_WARNING_TITLE, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                }

                if (!testMailSend)
                {
                    _messageBoxService.Send(MessageBoxType.INFORMATION, MessageConstants.MESSAGEBOX_SMTP_SETTINGS_NOT_TESTED); // SMTP Settings not tested
                    return;
                }

                testMailSend = false;

                _smtpSaveService.SaveConfiguration(settings);
                _messageBoxService.Send(MessageBoxType.INFORMATION, MessageConstants.MESSAGEBOX_SMTP_CONFIG_SAVED_SUCCESFULLY); // SMTP Config saved succesfully

            }
            else
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_EMAIL_FIELDS_ARE_MISSING); // Fields are missing
            }
        }

        private void deleteConfigurationBttn_Click(object sender, EventArgs e)
        {
            if (_smtpSaveService.DeleteConfiguration())
            {
                _messageBoxService.Send(MessageBoxType.INFORMATION, MessageConstants.MESSAGEBOX_SMTP_CONFIG_DELETED);
                ResetUserInputs();
            }
            else
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_SMTP_CONFIG_NOT_EXISTS);
            }
        }

        private void EmailSettingsPanel_Load(object sender, EventArgs e)
        {
            if (_smtpSaveService.ConfigurationExists())
            {
                var settings = _smtpSaveService.GetConfiguration();
                smtpServerBox.Text = settings.smtpServer;
                smtpPort.TabIndex = settings.port;
                smtpEmailBox.Text = settings.smtpEmail;
                smtpPasswordBox.Text = settings.smtpPassword;
                targetEmailBox.Text = settings.targetEmail;
                emailSubjectBox.Text = settings.emailSubject;
                emailContentBox.Text = settings.emailBody;
            }
        }

        private void testmailBttn_Click(object sender, EventArgs e)
        {
            if (ValidateUserInputs())
            {
                var _mailService = new MailService();
                var _settings = new SMTPSetting()
                {
                    smtpServer = smtpServerBox.Text,
                    port = int.Parse(smtpPort.Text),
                    smtpEmail = smtpEmailBox.Text,
                    smtpPassword = smtpPasswordBox.Text,
                    useSSL = true,
                    targetEmail = targetEmailBox.Text,
                    emailBody = emailContentBox.Text,
                    emailSubject = emailSubjectBox.Text
                };

                if (_mailService.SendEmailWithBody(_settings, _settings.emailBody.Replace("%TIME%", "14:04:12").Replace("%URL%", "https://mywebsite.net").Replace("%COUNT%", "1337"))) // Sends the test-email with hardcoded placeholders.
                {
                    _messageBoxService.Send(MessageBoxType.INFORMATION, MessageConstants.MESSAGEBOX_EMAIL_TEST_SUCCESFULLY); // Succesfully send the email
                    testMailSend = true;
                }
                else
                {
                    _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_EMAIL_SMTP_WRONG); // SMTP-Settings are wrong
                }
            }
            else
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_EMAIL_FIELDS_ARE_MISSING); // Fields are missing
            }
        }

        private void informationLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _messageBoxService.Send(MessageBoxType.INFORMATION, MessageConstants.MESSAGEBOX_SMTP_BODY_INFORMATION);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Program.getInstance()._emailSettingsPanel = null;
        }

        /// <summary>
        /// Checks if the textboxes are empty.
        /// When the textboxes are empty the function returns false.
        /// </summary>
        public bool ValidateUserInputs()
        {
            if (IsStringValid(smtpServerBox.Text) && IsStringValid(smtpPort.Text) &&
                IsStringValid(smtpPasswordBox.Text) && IsStringValid(smtpEmailBox.Text) &&
                IsStringValid(targetEmailBox.Text) && IsStringValid(emailSubjectBox.Text) && IsStringValid(emailContentBox.Text)) { return true; }

            return false;
        }

        public void ResetUserInputs()
        {
            smtpServerBox.Text = String.Empty;
            smtpPort.TabIndex = 587;
            smtpEmailBox.Text = String.Empty;
            smtpPasswordBox.Text = String.Empty;
            targetEmailBox.Text = String.Empty;
            emailSubjectBox.Text = String.Empty;
            emailContentBox.Text = String.Empty;
        }

        /// <summary>
        /// Returns true if the given string is not empty.
        /// </summary>
        private bool IsStringValid(String s)
        {
            return s != String.Empty;
        }
    }
}
