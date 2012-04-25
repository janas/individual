// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GraphSummary.cs" company="Warsaw University of Technology">
//   Piotr Janaszek
// </copyright>
// <summary>
//   The graph summary.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NetworkFlow
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The graph summary.
    /// </summary>
    public partial class GraphSummary : Form
    {
        #region Constants and Fields

        /// <summary>
        /// The provider.
        /// </summary>
        private readonly Provider.Provider provider;

        #endregion

        #region Constructors and Destructors
        
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphSummary"/> class. 
        /// </summary>
        /// <param name="provider">
        /// The provider.
        /// </param>
        public GraphSummary(Provider.Provider provider)
        {
            this.InitializeComponent();
            this.provider = provider;
            this.PrepareDialog();
        }

        #endregion

        #region Methods

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
            this.Close();
        }

        /// <summary>
        /// The prepare dialog.
        /// </summary>
        private void PrepareDialog()
        {
            if (this.provider.NetworkFlowGraph.Source == null)
            {
                this.labelSrcNodeValue.Text = "Not set";
            }

            if (this.provider.NetworkFlowGraph.Sink == null)
            {
                this.labelSinkNodeValue.Text = "Not set";
            }

            if (this.provider.NetworkFlowGraph.Source != null)
            {
                this.labelSrcNodeValue.Text = this.provider.NetworkFlowGraph.Source;
            }

            if (this.provider.NetworkFlowGraph.Sink != null)
            {
                this.labelSinkNodeValue.Text = this.provider.NetworkFlowGraph.Sink;
            }

            this.labelNodesValue.Text = this.provider.NetworkFlowGraph.Count.ToString();
            this.labelEdgesValue.Text = this.provider.NetworkFlowGraph.Edges.ToString();
            this.labelMaxFlowValue.Text = this.provider.NetworkFlowGraph.MaximumFlow.ToString();
        }

        #endregion
    }
}