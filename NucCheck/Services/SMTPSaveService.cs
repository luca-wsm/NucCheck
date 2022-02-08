using NucCheck.Constants;
using NucCheck.Objects;
using System;
using System.IO;
using System.Text.Json;

namespace NucCheck.Services
{
    public class SMTPSaveService
    {

        String fullSavePath = DataConstants.SMTP_SAVE_PATH + DataConstants.SMTP_FILE_NAME;

        public void SaveConfiguration(SMTPSetting smptSetting)
        {

            if (!Directory.Exists(DataConstants.SMTP_SAVE_PATH))
            {
                Directory.CreateDirectory(DataConstants.SMTP_SAVE_PATH);
                using FileStream createSteeam = File.Create(fullSavePath);
            }

            var jsonString = JsonSerializer.Serialize(smptSetting, new JsonSerializerOptions()
            {
                WriteIndented = true
            });

            File.WriteAllText(fullSavePath, jsonString);
        }

        public bool ConfigurationExists()
        {
            try
            {
                return File.Exists(fullSavePath);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public SMTPSetting GetConfiguration()
        {
            var jsonString = File.ReadAllText(fullSavePath);
            return JsonSerializer.Deserialize<SMTPSetting>(jsonString);
        }

        /// <summary>
        /// Gets the SMTP Configuration in a raw unminified json string.
        /// </summary>
        /// <returns></returns>
        public String GetJsonRawConfiguration()
        {
            return File.ReadAllText(fullSavePath);
        }

        public bool DeleteConfiguration()
        {
            if (File.Exists(fullSavePath))
            {
                File.Delete(fullSavePath);
                Directory.Delete(DataConstants.SMTP_SAVE_PATH);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
