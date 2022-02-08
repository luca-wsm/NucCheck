using NucCheck.Constants;
using System;
using System.Windows.Forms;

namespace NucCheck.Services
{
    public enum MessageBoxType
    {
        INFORMATION,
        WARNING,
        ERROR,
    }

    public class MessageBoxService
    {
        public void Send(MessageBoxType type, String message)
        {
            switch (type)
            {
                case MessageBoxType.INFORMATION:
                    MessageBox.Show(message, MessageConstants.MESSAGEBOX_INFORMATION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case MessageBoxType.WARNING:
                    MessageBox.Show(message, MessageConstants.MESSAGEBOX_WARNING_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case MessageBoxType.ERROR:
                    MessageBox.Show(message, MessageConstants.MESSAGEBOX_ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
