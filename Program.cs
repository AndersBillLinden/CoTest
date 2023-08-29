using System;
using System.Windows.Forms;

namespace TreeViewAdvBugRepro
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NGaF1cVGhIfEx1RHxQdld5ZFRHallYTnNWUj0eQnxTdEZjUX1ccHFURGFbUUd3XA==");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
