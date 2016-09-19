using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;


namespace MainMenu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
    
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (Mutex mutex = new Mutex(false, "Global\\" + appGuid))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("Instance already running");
                    return;
                }

                Application.Run(new frmLogin());
            }



  
//            Application.Run(new frmLogin());


        }
        private static string appGuid = "c0a76b5a-12ab-45c5-b9d9-d693faa6e7b9";
     }
}
