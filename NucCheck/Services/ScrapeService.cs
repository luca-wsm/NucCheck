using NucCheck.Constants;
using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace NucCheck.Services
{
    public class ScrapeService
    {
        private Thread _workerThread;
        private String _url;
        private String _searchString;
        private Boolean _run = true; // Boolean for the Thread while
        private int _tryCount = 0; // A integer for the check count, increments +1 by every try.
        private int _choosenMethod;
        private String _notificationValue;

        public ScrapeService(String url, String searchString, int choosenMethod, String notificationValue)
        {
            _url = url;
            _searchString = searchString;
            _choosenMethod = choosenMethod;
            _notificationValue = notificationValue;
            if (!_url.Contains("http") || !_url.Contains("https"))
            {
                _url = "https://" + _url;
            }
        }

        /// <summary>
        /// Starts the thread
        /// </summary>
        public void startThread()
        {
            _workerThread = new Thread(Run);
            _workerThread.IsBackground = true;
            _workerThread.Start();
        }

        /// <summary>
        /// This is the method that the thread will trigger.
        /// Also sets the Sleep Delay for the thread.
        /// </summary>
        private void Run()
        {
            while (_run)
            {
                Fetch();
                Thread.Sleep(Program.getInstance().threadDelay);
            }
        }

        /// <summary>
        /// Kills the ScrapeThread and starting the GarbageCollector.
        /// </summary>
        public void KillThread()
        {
            _run = false;
            GC.Collect();
        }

        /// <summary>
        /// Fetches the HTML-Code, and checks if the code still contains the searchString.
        /// Also converting the searchString to lowerCase and formats the logBox short URL.
        /// </summary>
        private async void Fetch()
        {
            DateTime time = DateTime.Now;
            String timeString = time.ToString("HH:mm:ss"); // We only want to get the time.
            String content;

            // This will be the formatted url, without a route. Converts: google.com/mycoolroute to google.com
            var _scrapeUrl = _url;
            _scrapeUrl = _scrapeUrl.Replace("https://", String.Empty).Replace("http://", String.Empty);
            int index = _scrapeUrl.IndexOf("/");
            if (index >= 0)
                _scrapeUrl = _scrapeUrl.Substring(0, index);

            _tryCount++;

            var client = CreateHTTPClient();

            try
            {
                content = await client.GetStringAsync(_url);
            }
            catch (Exception)
            {
                return;
            }

            content = content.ToLower();

            // Regex Check if the targetString has changed.
            if (Regex.IsMatch(content, @$"\b{_searchString.ToLower()}\b"))
            {
                Program.getInstance().AddLogItem(MessageConstants.LOGBOX_STRING_NOT_CHANGED.Replace("%TIME%", timeString).Replace("%URL%", _scrapeUrl).Replace("%COUNT%", _tryCount.ToString())); // String is still the same
            }
            else
            {
                var smtpSaveService = new SMTPSaveService();
                var mailService = new MailService();

                if (_choosenMethod == 0) // 0 == Email | 1 == Call URL
                {
                    mailService.SendEmailWithBody(smtpSaveService.GetConfiguration(), smtpSaveService.GetConfiguration().emailBody.Replace("%TIME%", timeString).Replace("%URL%", _scrapeUrl).Replace("%COUNT%", _tryCount.ToString()));
                }
                else
                {
                    var curlService = new CURLService();
                    curlService.CallUrlPlain(_notificationValue);
                }

                KillThread();
                Program.getInstance().StopFormButtons();
                Program.getInstance().AddLogItem(MessageConstants.LOGBOX_NOTIFICATION_TRIGGERD.Replace("%TIME%", timeString)); // String has changed or cannot be found
            }
        }

        /// <summary>
        /// First check if the given SearchString can be found.
        /// If true the Scraping will be started
        /// If false a error will be shown.
        /// </summary>
        public async Task<bool> StringFound()
        {
            using var client = CreateHTTPClient();

            String content;

            try
            {
                content = await client.GetStringAsync(_url);
            }
            catch (Exception)
            {
                return false;
            }

            content = content.ToLower();

            if (!Regex.IsMatch(content, @$"\b{_searchString.ToLower().ToLower()}\b"))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Returns a http client
        /// </summary>
        /// <returns></returns>
        private static HttpClient CreateHTTPClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders
            .UserAgent
            .TryParseAdd("Mozilla/5.0 (Windows NT 5.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2490.71 Safari/537.36");

            return client;
        }
    }
}
