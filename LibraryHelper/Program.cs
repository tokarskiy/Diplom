using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryHelper
{
    static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var window = new UserFormLogin();
            ThisApplication.Instance.CurrentEmployee = window.ShowAndLogin();

            if (ThisApplication.Instance.CurrentEmployee == null)
            {
                return;
            }

            Application.Run(new UserFormMainWindow());
        }
    }
}
