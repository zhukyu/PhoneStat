using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneStat
{
    internal static class Program
    {
        internal static bool isLoggedIn = false;
        internal static string userName = "";
        internal static string conStr = @"Data Source=ZHUKYU;Initial Catalog=PhoneDb;Integrated Security=True";

        //vinhh: Data Source=DESKTOP-AE7IM0R\SQLEXPRESS01;Initial Catalog=QLCH;Integrated Security=True
        //huu: Data Source=ZHUKYU;Initial Catalog=PhoneDb;Integrated Security=True
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}
