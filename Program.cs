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
        internal static string conStr = @"Data Source=ZHUKYU;Initial Catalog=PhoneDb;Integrated Security=True";
        //bruh sao k gan vao day
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
