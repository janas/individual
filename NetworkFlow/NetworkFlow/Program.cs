// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Warsaw University of Technology">
//   Piotr Janaszek
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NetworkFlow
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// The program.
    /// </summary>
    internal static class Program
    {
        #region Methods

        /// <summary>
        /// The load application.
        /// </summary>
        private static void LoadApplication()
        {
            string providerDll = Path.Combine(
                Path.GetDirectoryName(Application.ExecutablePath), "NetworkFlow.Provider.dll");
            string gleeDll = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Microsoft.GLEE.dll");
            string gleeDrawingDll = Path.Combine(
                Path.GetDirectoryName(Application.ExecutablePath), "Microsoft.GLEE.Drawing.dll");
            string gleeGdiDll = Path.Combine(
                Path.GetDirectoryName(Application.ExecutablePath), "Microsoft.GLEE.GraphViewerGDI.dll");
            if (File.Exists(providerDll) && File.Exists(gleeDll) && File.Exists(gleeDrawingDll)
                && File.Exists(gleeGdiDll))
            {
                Application.Run(new MainForm());
            }
            else
            {
                Application.Run(new LoaderForm());
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadApplication();
        }

        #endregion
    }
}