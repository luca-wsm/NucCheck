using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NucCheck.Objects
{
    public class SMTPSetting
    {
        //Server Settings
        public String smtpServer { get; set; }
        public int port { get; set; } // Standard port: 587
        public string smtpEmail { get; set; }
        public string smtpPassword { get; set; }
        public bool useSSL { get; set; } //always true

        //Email Settings
        public string targetEmail { get; set; }
        public string emailSubject { get; set; }
        public string emailBody { get; set; }

    }
}
