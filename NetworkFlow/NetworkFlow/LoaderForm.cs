// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoaderForm.cs" company="Warsaw University of Technology">
//   Piotr Janaszek
// </copyright>
// <summary>
//   The loader form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NetworkFlow
{
    using System;
    using System.IO;
    using System.Timers;
    using System.Windows.Forms;

    using Timer = System.Timers.Timer;

    /// <summary>
    /// The loader form.
    /// </summary>
    public partial class LoaderForm : Form
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LoaderForm"/> class.
        /// </summary>
        public LoaderForm()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// The close application.
        /// </summary>
        private void CloseApplication()
        {
            var timer = new Timer(5000);
            timer.Elapsed += this.TimerElapsed;
            timer.Enabled = true;
        }

        /// <summary>
        /// The loader form load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void LoaderFormLoad(object sender, EventArgs e)
        {
            string providerDll = Path.Combine(
                Path.GetDirectoryName(Application.ExecutablePath), "NetworkFlow.Provider.dll");
            string gleeDll = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Microsoft.GLEE.dll");
            string gleeDrawingDll = Path.Combine(
                Path.GetDirectoryName(Application.ExecutablePath), "Microsoft.GLEE.Drawing.dll");
            string gleeGdiDll = Path.Combine(
                Path.GetDirectoryName(Application.ExecutablePath), "Microsoft.GLEE.GraphViewerGDI.dll");
            if (File.Exists(providerDll))
            {
                this.labelFound1.Visible = true;
            }

            if (!File.Exists(providerDll))
            {
                this.labelNotFound1.Visible = true;
                this.labelError.Visible = true;
            }

            if (File.Exists(gleeDll))
            {
                this.labelFound2.Visible = true;
            }

            if (!File.Exists(gleeDll))
            {
                this.labelNotFound2.Visible = true;
                this.labelError.Visible = true;
            }

            if (File.Exists(gleeDrawingDll))
            {
                this.labelFound3.Visible = true;
            }

            if (!File.Exists(gleeDrawingDll))
            {
                this.labelNotFound3.Visible = true;
                this.labelError.Visible = true;
            }

            if (File.Exists(gleeGdiDll))
            {
                this.labelFound4.Visible = true;
            }

            if (!File.Exists(gleeGdiDll))
            {
                this.labelNotFound4.Visible = true;
                this.labelError.Visible = true;
            }

            this.CloseApplication();
        }

        /// <summary>
        /// The timer elapsed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)this.Close);
        }

        #endregion
    }
}