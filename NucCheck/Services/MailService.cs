using NucCheck.Objects;
using System;
using System.Net;
using System.Net.Mail;
namespace NucCheck.Services
{
    public class MailService
    {

        /// <summary>
        /// Sends a email with the pre-configured smtp settings.
        /// </summary>
        /// <param name="settings">The settings object that we get from a json-file</param>
        /// <param name="body">The email body, this cant be saved static in the settings because we have to replace placeholder values like %TIME% for the time.</param>
        /// <returns></returns>
        public bool SendEmailWithBody(SMTPSetting settings, String body) // Maybe change to async in the future
        {
            try
            {
                GetClient(settings).Send(settings.smtpEmail, settings.targetEmail, settings.emailSubject, body);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Returns a SmtpClient with the given smtpSettings.
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        public SmtpClient GetClient(SMTPSetting settings)
        {
            return new SmtpClient(settings.smtpServer)
            {
                Port = settings.port,
                Credentials = new NetworkCredential(settings.smtpEmail, settings.smtpPassword),
                EnableSsl = settings.useSSL,
            };
        }

    }
}
