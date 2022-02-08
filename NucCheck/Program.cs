using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NucCheck
{
    static class Program
    {
        static Panel panel = null;

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            panel = new Panel();
            Application.Run(panel);
        }
        public static Panel getInstance()
        {
            return panel;
        }
    }
}
