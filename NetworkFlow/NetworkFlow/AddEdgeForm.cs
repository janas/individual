// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddEdgeForm.cs" company="Warsaw University of Technology">
//   Piotr Janaszek
// </copyright>
// <summary>
//   The add edge form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NetworkFlow
{
    using System;
    using System.Windows.Forms;

    using NetworkFlow.Provider.BLL;

    /// <summary>
    /// The add edge form.
    /// </summary>
    public partial class AddEdgeForm : Form
    {
        #region Constants and Fields

        /// <summary>
        /// The provider.
        /// </summary>
        private readonly Provider.Provider provider;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddEdgeForm"/> class.
        /// </summary>
        /// <param name="provider">
        /// The provider.
        /// </param>
        public AddEdgeForm(Provider.Provider provider)
        {
            this.InitializeComponent();
            this.provider = provider;
            this.FillSourceVertexIdComboBox();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets Flow.
        /// </summary>
        public int Flow { get; set; }

        /// <summary>
        /// Gets or sets SourceVertexId.
        /// </summary>
        public string SourceVertexId { get; set; }

        /// <summary>
        /// Gets or sets TargetVertexId.
        /// </summary>
        public string TargetVertexId { get; set; }

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
        /// The combo box source vertex id selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ComboBoxSourceVertexIdSelectedIndexChanged(object sender, EventArgs e)
        {
            var sourceVertex = (GraphNode)this.comboBoxSourceVertexId.SelectedItem;
            this.SourceVertexId = sourceVertex.VertexId;
            this.comboBoxTargetVertexId.Enabled = true;
            this.FillTargetVertexIdComboBox();
        }

        /// <summary>
        /// The combo box target vertex id selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ComboBoxTargetVertexIdSelectedIndexChanged(object sender, EventArgs e)
        {
            var targetVertex = (GraphNode)this.comboBoxTargetVertexId.SelectedItem;
            this.TargetVertexId = targetVertex.VertexId;
            this.VerifyLayout();
        }

        /// <summary>
        /// The fill source vertex id combo box.
        /// </summary>
        private void FillSourceVertexIdComboBox()
        {
            this.comboBoxSourceVertexId.Items.Clear();
            foreach (var node in this.provider.NetworkFlowGraph.Nodes)
            {
                this.comboBoxSourceVertexId.Items.Add(node);
                this.comboBoxSourceVertexId.DisplayMember = "VertexId";
            }
        }

        /// <summary>
        /// The fill target vertex id combo box.
        /// </summary>
        private void FillTargetVertexIdComboBox()
        {
            var sourceVertex = (GraphNode)this.comboBoxSourceVertexId.SelectedItem;
            var graphNodeList = new GraphNodeList();
            foreach (var node in this.provider.NetworkFlowGraph.Nodes)
            {
                if (node.VertexId.Equals(sourceVertex.VertexId))
                {
                    continue;
                }

                graphNodeList.Add(node);
            }

            foreach (var neighbour in sourceVertex.Neighbours)
            {
                GraphNode gnode = neighbour.NodeTo;
                if (graphNodeList.Contains(gnode))
                {
                    graphNodeList.Remove(gnode);
                }
            }

            this.comboBoxTargetVertexId.Items.Clear();
            foreach (var node in graphNodeList)
            {
                this.comboBoxTargetVertexId.Items.Add(node);
                this.comboBoxTargetVertexId.DisplayMember = "VertexId";
            }
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
            this.toolTipEgde.ToolTipTitle = "Invalid input";
            this.toolTipEgde.Show("Only digits (0-9) are allowed.", this.maskedTextBoxFlow, 3000);
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
                this.toolTipEgde.ToolTipTitle = "Flow cannot be empty";
                this.toolTipEgde.Show("Please enter valid flow value.", this.maskedTextBoxFlow, 3000);
                this.VerifyLayout();
                return;
            }

            this.Flow = int.Parse(this.maskedTextBoxFlow.Text);
            this.VerifyLayout();
        }

        /// <summary>
        /// The verify layout.
        /// </summary>
        private void VerifyLayout()
        {
            if (this.comboBoxSourceVertexId.SelectedIndex == -1 || this.comboBoxTargetVertexId.SelectedIndex == -1
                || string.IsNullOrEmpty(this.maskedTextBoxFlow.Text))
            {
                this.btnOK.Enabled = false;
                return;
            }

            this.btnOK.Enabled = true;
        }

        #endregion
    }
}