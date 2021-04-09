using System;
using System.Windows.Forms;

namespace WinFormsLibraryManager
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }
    }
}