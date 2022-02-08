using NucCheck.Constants;
using System;
using System.Net;
using System.Web;

namespace NucCheck.Services
{
    public class CURLService
    {

        /// <summary>
        /// Checks if a website is reachable
        /// </summary>
        /// <param name="url">The URl that will be checked</param>
        /// <param name="issuerObject">The object that wants to perform this action, this is important for the logboxes, so we dont log stuff in the other logbox.</param>
        /// <returns>If true, the website is reachable, if false the website doesnt exists / is offline</returns>
        public Boolean CallUrl(String url, Object issuerObject)
        {
            MessageBoxService _service = new MessageBoxService();

            //Adds https to the url
            if (!url.Contains("http") || !url.Contains("https"))
            {
                url = "https://" + url;
            }

            try
            {
                var request = CreateWebRequest(url);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (issuerObject.Equals(Program.getInstance()))
                    {
                        Program.getInstance().ShowStartMessage("Server answered OK");
                    }
                    else
                    {
                        Program.getInstance()._comparerPanel.ShowStartMessage("Server answered OK");
                    }
                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch
            {
                _service.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_TARGET_IS_NO_WEBSITE);
            }
            return false;
        }

        /// <summary>
        /// Calls a URL for the NotificationType "Call URL"
        /// </summary>
        /// <param name="url"></param>
        public void CallUrlPlain(String url)
        {
            MessageBoxService _service = new MessageBoxService();

            //Adds https to the url
            if (!url.Contains("http") || !url.Contains("https"))
            {
                url = "https://" + url;
            }

            try
            {
                var request = CreateWebRequest(url);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    // Create instance so the call is going through.
                }
            }
            catch (Exception)
            {
                // A 303 or something would throw an exception, so we dont do here anything. 
            }
        }

        /// <summary>
        /// Create a web request with default parameters.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private HttpWebRequest CreateWebRequest(String url)
        {
            var request = (HttpWebRequest)WebRequest.Create(HttpUtility.HtmlEncode(url));
            request.Timeout = 15000;
            request.UserAgent = "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2490.71 Safari/537.36";
            request.Method = "GET";
            return request;
        }
    }
}
