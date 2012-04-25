// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddNodeForm.cs" company="Warsaw University of Technology">
//   Piotr Janaszek
// </copyright>
// <summary>
//   The add node form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NetworkFlow
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The add node form.
    /// </summary>
    public partial class AddNodeForm : Form
    {
        #region Constants and Fields

        /// <summary>
        /// The provider.
        /// </summary>
        private readonly Provider.Provider provider;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddNodeForm"/> class.
        /// </summary>
        /// <param name="provider">
        /// The provider.
        /// </param>
        public AddNodeForm(Provider.Provider provider)
        {
            this.InitializeComponent();
            this.provider = provider;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets VertexId.
        /// </summary>
        public string VertexId { get; set; }

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
            if (this.provider.NetworkFlowGraph.Nodes.FindByName(this.textBoxVertexId.Text) != null)
            {
                this.toolTipVertexId.ToolTipTitle = "Please enter vertex name";
                this.toolTipVertexId.Show(
                    "Given Vertex ID already exists! Please enter unique Vertex ID.", this.textBoxVertexId, 3000);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// The text box vertex id text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TextBoxVertexIdTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxVertexId.Text))
            {
                this.toolTipVertexId.ToolTipTitle = "Please enter vertex name";
                this.toolTipVertexId.Show("Empty name is not allowed.", this.textBoxVertexId, 3000);
                this.btnOK.Enabled = false;
                return;
            }

            this.VertexId = this.textBoxVertexId.Text.Trim();
            this.btnOK.Enabled = true;
        }

        #endregion
    }
}