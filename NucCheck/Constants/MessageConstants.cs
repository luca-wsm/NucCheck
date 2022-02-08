using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NucCheck.Constants
{
    public class MessageConstants
    {
        public const String APPLICATION_NAME = "NucCheck";
        public const String MESSAGEBOX_INFORMATION_TITLE = APPLICATION_NAME + " » Information";
        public const String MESSAGEBOX_WARNING_TITLE = APPLICATION_NAME + " » Warning";
        public const String MESSAGEBOX_ERROR_TITLE = APPLICATION_NAME + " » Error";
        public const String MESSAGEBOX_NO_NOTIFICATION_SELECTED = "You didnt selected a notification type!";
        public const String MESSAGEBOX_PANEL_HIDDEN = "Click the tray icon the show the panel\nBackground activites are still active.";
        public const String MESSAGEBOX_NO_NOTIFICATION_VALUE_SELECTED = "You didnt selected a notification value!";
        public const String MESSAGEBOX_TARGET_WEBISTE_EMPTY = "You didnt defined a target website.";
        public const String MESSAGEBOX_TARGET_IS_NO_WEBSITE = "The defined target site is no website or didnt answered.";
        public const String MESSAGEBOX_SEARCH_STRING_EMPTY = "You didnt defined a search string.";
        public const String MESSAGEBOX_SEARCH_STRING_NOT_FOUND = "The search string you entered was not found. Please enter a string that exists on the website.";
        public const String LOGBOX_STRING_NOT_CHANGED = "[%TIME%] String not changed... [%URL%] [%COUNT%]";
        public const String LOGBOX_WEBSITE_NOT_CHANGED = "[%TIME%] Website content is still the same... [%URL%] [%COUNT%]";
        public const String LOGBOX_NOTIFICATION_TRIGGERD = "[%TIME%] String has changed or cannot be found, NotificationService triggerd!";
        public const String LOGBOX_NOTIFICATION_TRIGGERD_COMPARER = "[%TIME%] The website has changed content, NotificationService triggerd!";
        public const String MESSAGEBOX_EMAIL_FIELDS_ARE_MISSING = "One or more fields are not specified!";
        public const String MESSAGEBOX_EMAIL_TEST_SUCCESFULLY = "The Email has been succesfully sent!";
        public const String MESSAGEBOX_EMAIL_SMTP_WRONG = "The SMTP-Settings are not valid!";
        public const String MESSAGEBOX_SMTP_SETTINGS_NOT_TESTED = "You have to test the smtp settings first before you can save them.";
        public const String MESSAGEBOX_SMTP_CONFIG_NOT_EXISTS = "There are no saved SMTP-Settings.";
        public const String MESSAGEBOX_CONFIG_IS_THE_SAME = "This config is already saved.";
        public const String MESSAGEBOX_SMTP_CONFIG_NOT_EXISTS_SCRAPING = "There are no saved SMTP-Settings, please create one in the 'Email-Settings' section";
        public const String MESSAGEBOX_SMTP_CONFIG_DELETED = "The SMTP-Settings deleted succesfully!";
        public const String MESSAGEBOX_COMPARER_PANEL_INIT = "An instance of the comparer panel already started!";
        public const String MESSAGEBOX_EMAIL_PANEL_INIT = "An instance of the email settings panel already started!";
        public const String MESSAGEBOX_SMTP_CONFIG_SAVED_SUCCESFULLY = "The SMTP-Settings saved succesfully!";
        public const String MESSAGEBOX_SMTP_CONFIG_ALREADY_EXISTS = "A settings config already exists, are you sure to overwrite the current config?"; //MessageBox Shows YES or NO
        public const String MESSAGEBOX_SMTP_BODY_INFORMATION = "You can use placeholder in the body, that will be filled when the email will be send.\n%TIME% - for the time\n%URL% - for the url\n%count% - for the try count\nNotice: In the test Email the placeholder will be set with a hardcoded data.";
        public const String MESSAGEBOX_PANEL_HELP_BUTTON = "You can define a target website and a search string. For example we have the website coolwebsite.net/coolproduct and the productpage says, that the article is out of stock. Now you can define the searchstring 'out of stock'. The Program will send you a email or calls a url when this string no longer exists / cant be found. \nYou can use the website comparer to check if there are any changed content since you first scraped the website. This feature can be used when you want to wait for a new drop or something like this.";
    }
}
