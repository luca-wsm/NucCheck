using NucCheck.Constants;
using System;
using System.Linq;
using System.Net;
using System.Threading;

namespace NucCheck.Services
{
    public class ComparerService
    {
        public String _url { get; set; }
        public int _choosenMethod { get; set; }
        public String _notificationValue { get; set; }


        private bool _run = true; // Boolean for the thread while.
        private Thread _workerThread;
        private String _cachedContent; // The website source on the first scrape.
        private int _tryCount = 0; // A integer for the check count, increments +1 by every try.

        /// <summary>
        /// Starts the thread, gets the cachedContent and adds
        /// http or https to the url.
        /// </summary>
        public void StartThread()
        {
            if (!_url.Contains("http") || !_url.Contains("https"))
            {
                _url = "https://" + _url;
            }

            SetContent();
            _workerThread = new Thread(Run);
            _workerThread.Start();
        }

        private void Run(object obj)
        {
            while (_run)
            {
                StartComparing();
                Thread.Sleep(Program.getInstance()._comparerPanel.threadDelay);
            }
        }

        private void SetContent()
        {
            using var client = new WebClient();

            try
            {
                _cachedContent = client.DownloadString(_url);
            }
            catch (Exception)
            {
                //TODO: Implement
            }
        }

        private String GetContent()
        {
            using var client = new WebClient();

            try
            {
                return client.DownloadString(_url);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void StartComparing()
        {
            var _currentContent = GetContent(); // Gets the current content from the website

            DateTime time = DateTime.Now;
            String timeString = time.ToString("HH:mm:ss"); // We only want to get the time.

            // This will be the formatted url, without a route. Converts: google.com/mycoolroute to google.com
            var _scrapeUrl = _url;
            _scrapeUrl = _scrapeUrl.Replace("https://", String.Empty).Replace("http://", String.Empty);
            int index = _scrapeUrl.IndexOf("/");
            if (index >= 0)
                _scrapeUrl = _scrapeUrl.Substring(0, index);

            _tryCount++;

            if (_cachedContent == _currentContent && _run)
            {
                Program.getInstance()._comparerPanel.AddLogItem(MessageConstants.LOGBOX_WEBSITE_NOT_CHANGED.Replace("%TIME%", timeString).Replace("%URL%", _scrapeUrl).Replace("%COUNT%", _tryCount.ToString())); // Website is still the same
            }
            else
            {
                var smtpSaveService = new SMTPSaveService();
                var mailService = new MailService();

                KillThread();
                Program.getInstance()._comparerPanel.StopButtons();
                Program.getInstance()._comparerPanel.ClearLog();
                Program.getInstance()._comparerPanel.AddLogItem(MessageConstants.LOGBOX_NOTIFICATION_TRIGGERD_COMPARER.Replace("%TIME%", timeString)); // Website has changed

                if (_choosenMethod == 0) // 0 == Email | 1 == Call URL
                {
                    mailService.SendEmailWithBody(smtpSaveService.GetConfiguration(), smtpSaveService.GetConfiguration().emailBody.Replace("%TIME%", timeString).Replace("%URL%", _scrapeUrl).Replace("%COUNT%", _tryCount.ToString()));
                }
                else
                {
                    var curlService = new CURLService();
                    curlService.CallUrlPlain(_notificationValue);
                }
            }
        }

        public void KillThread()
        {
            _run = false;
            GC.Collect();
        }
    }
}
