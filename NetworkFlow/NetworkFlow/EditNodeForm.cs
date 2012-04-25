// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EditNodeForm.cs" company="Warsaw University of Technology">
//   Piotr Janaszek
// </copyright>
// <summary>
//   The edit node form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NetworkFlow
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The edit node form.
    /// </summary>
    public partial class EditNodeForm : Form
    {
        #region Constants and Fields

        /// <summary>
        ///   The old vertex id.
        /// </summary>
        private readonly string oldVertexId;

        /// <summary>
        ///   The provider.
        /// </summary>
        private readonly Provider.Provider provider;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EditNodeForm"/> class. 
        /// </summary>
        /// <param name="provider">
        /// The provider. 
        /// </param>
        /// <param name="oldVertexId">
        /// The old vertex id. 
        /// </param>
        public EditNodeForm(Provider.Provider provider, string oldVertexId)
        {
            this.InitializeComponent();
            this.provider = provider;
            this.oldVertexId = oldVertexId;
            this.FillForm();
        }

        #endregion

        #region Enums

        /// <summary>
        /// The node mode.
        /// </summary>
        private enum NodeMode
        {
            /// <summary>
            ///   The normal.
            /// </summary>
            Normal = 0, 

            /// <summary>
            ///   The source.
            /// </summary>
            Source, 

            /// <summary>
            ///   The sink.
            /// </summary>
            Sink
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets Mode.
        /// </summary>
        public int Mode { get; private set; }

        /// <summary>
        /// Gets NewVertexId.
        /// </summary>
        public string NewVertexId { get; private set; }

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
            if (!string.IsNullOrEmpty(this.textBoxVertexId.Text.Trim())
                &&
                (this.textBoxVertexId.Text.Trim().Equals(this.oldVertexId)
                 || this.provider.NetworkFlowGraph.Nodes.FindByName(this.textBoxVertexId.Text) == null))
            {
                this.NewVertexId = this.textBoxVertexId.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.toolTipVertexId.ToolTipTitle = "Please enter vertex name";
                this.toolTipVertexId.Show(
                    "Given Vertex ID already exists! Please enter unique Vertex ID.", this.textBoxVertexId, 3000);
            }
        }

        /// <summary>
        /// The combo box node mode selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender. 
        /// </param>
        /// <param name="e">
        /// The e. 
        /// </param>
        private void ComboBoxNodeModeSelectedIndexChanged(object sender, EventArgs e)
        {
            var nodeMode = (NodeMode)this.comboBoxNodeMode.SelectedIndex;
            switch (nodeMode)
            {
                case NodeMode.Normal:
                    this.Mode = 0;
                    break;
                case NodeMode.Source:
                    this.Mode = 1;
                    break;
                case NodeMode.Sink:
                    this.Mode = 2;
                    break;
            }
        }

        /// <summary>
        /// The fill form.
        /// </summary>
        private void FillForm()
        {
            this.comboBoxNodeMode.SelectedIndex = this.provider.GetNodeMode(this.oldVertexId);
            this.textBoxVertexId.Text = this.oldVertexId;
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

            this.btnOK.Enabled = true;
        }

        #endregion
    }
}