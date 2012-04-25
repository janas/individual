// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EditEdgeForm.cs" company="Warsaw University of Technology">
//   Piotr Janaszek
// </copyright>
// <summary>
//   The edit edge form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NetworkFlow
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The edit edge form.
    /// </summary>
    public partial class EditEdgeForm : Form
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EditEdgeForm"/> class.
        /// </summary>
        /// <param name="flow">
        /// The flow.
        /// </param>
        public EditEdgeForm(string flow)
        {
            this.InitializeComponent();
            int start = flow.IndexOf('[');
            int end = flow.IndexOf('|');
            this.maskedTextBoxFlow.Text = flow.Substring(start, end - start);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets Flow.
        /// </summary>
        public int Flow { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// The process cmd key.
        /// </summary>
        /// <param name="msg">
        /// The msg.
        /// </param>
        /// <param name="keyData">
        /// The key data.
        /// </param>
        /// <returns>
        /// Returns true if Return button was pressed.
        /// </returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.Return)
            {
                return false;
            }

            this.btnOK.PerformClick();
            return true;
        }

        /// <summary>
        /// The btn ok click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnOkClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// The masked text box flow mask input rejected.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void MaskedTextBoxFlowMaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.toolTipEditEdge.ToolTipTitle = "Invalid input";
            this.toolTipEditEdge.Show("Only digits (0-9) are allowed.", this.maskedTextBoxFlow, 3000);
        }

        /// <summary>
        /// The masked text box flow text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void MaskedTextBoxFlowTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.maskedTextBoxFlow.Text))
            {
                this.toolTipEditEdge.ToolTipTitle = "Flow cannot be empty";
                this.toolTipEditEdge.Show("Please enter valid flow value.", this.maskedTextBoxFlow, 3000);
                this.btnOK.Enabled = false;
                return;
            }

            this.Flow = int.Parse(this.maskedTextBoxFlow.Text);
            this.btnOK.Enabled = true;
        }

        #endregion
    }
}