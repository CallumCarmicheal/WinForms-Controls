using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingADashboard {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // Add the event handler for handling UI thread exceptions to the event.
            Application.ThreadException += Application_ThreadException;

            // Set the unhandled exception mode to force all Windows Forms errors
            // to go through our handler.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event. 
            AppDomain.CurrentDomain.UnhandledException += new
            UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestForm());
        }

        public static void WTFDidIDo(Exception ex) {
            // STATE OF THE ARK: ERROR HANDLING
            // WHAT TO DO, IGNORE IT JUST OPEN STACKOVERFLOW IN THE BACKGROUND
            // 10/10 
            string url = "http://stackoverflow.com/search?q=%5Bc%23%5D+";
            string error = ex.Message;

            string ret = url + error;

            Process.Start(@"chrome.exe",
              ret);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e) {
            WTFDidIDo((Exception)e.ExceptionObject);
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e) {
            WTFDidIDo((Exception)e.Exception);
        }
    }
}
