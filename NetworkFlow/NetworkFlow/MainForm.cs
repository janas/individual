// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Warsaw University of Technology">
//   Piotr Janaszek
// </copyright>
// <summary>
//   The main form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NetworkFlow
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    using Microsoft.Glee.Drawing;

    using NetworkFlow.Provider.BLL;

    using Color = Microsoft.Glee.Drawing.Color;
    using Graph = Microsoft.Glee.Drawing.Graph;
    using MouseButtons = System.Windows.Forms.MouseButtons;

    /// <summary>
    /// The main form.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Constants and Fields

        /// <summary>
        /// The provider.
        /// </summary>
        private readonly Provider.Provider provider = new Provider.Provider();

        /// <summary>
        /// The network vizualization graph.
        /// </summary>
        private Graph networkVizualizationGraph;

        /// <summary>
        /// The selected object.
        /// </summary>
        private object selectedObject;

        /// <summary>
        /// The selected object attr.
        /// </summary>
        private object selectedObjectAttr;

        /// <summary>
        /// The enable calculate
        /// </summary>
        private bool enableCalculate;

        /// <summary>
        /// The step by step.
        /// </summary>
        private bool stepByStep;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            this.PrepareWindow();
        }

        #endregion

        #region Methods

        /// <summary>
        /// The add edge tool strip menu item click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void AddEdgeToolStripMenuItemClick(object sender, EventArgs e)
        {
            var addEdgeForm = new AddEdgeForm(this.provider);
            addEdgeForm.ShowDialog();
            if (addEdgeForm.DialogResult == DialogResult.OK)
            {
                this.provider.AddDirectedEdge(addEdgeForm.SourceVertexId, addEdgeForm.TargetVertexId, addEdgeForm.Flow);
            }

            this.DrawGraph();
        }

        /// <summary>
        /// The add node tool strip menu item click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void AddNodeToolStripMenuItemClick(object sender, EventArgs e)
        {
            var addNodeForm = new AddNodeForm(this.provider);
            addNodeForm.ShowDialog();
            if (addNodeForm.DialogResult == DialogResult.OK)
            {
                this.provider.AddNode(addNodeForm.VertexId);
            }

            this.DrawGraph();
        }

        /// <summary>
        /// The all context menu strip opening.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void AllContextMenuStripOpening(object sender, CancelEventArgs e)
        {
            if (this.provider.NetworkFlowGraph.Nodes.Count >= 2)
            {
                this.addEdgeToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.addEdgeToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// The background worker export do work.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BackgroundWorkerExportDoWork(object sender, DoWorkEventArgs e)
        {
            var path = e.Argument as string;
            this.provider.ExportGraphToXml(path);
        }

        /// <summary>
        /// The background worker export run worker completed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BackgroundWorkerExportRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.toolStripStatusLabelState.Text = "Ready";
            this.toolStripProgressBar.Visible = false;
        }

        /// <summary>
        /// The background worker loader do work.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BackgroundWorkerLoaderDoWork(object sender, DoWorkEventArgs e)
        {
            var path = e.Argument as string;
            this.provider.LoadFromXml(path);
        }

        /// <summary>
        /// The background worker loader run worker completed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BackgroundWorkerLoaderRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.DrawGraph();
            this.toolStripStatusLabelState.Text = "Ready";
            this.enableCalculate = true;
            this.toolStripProgressBar.Visible = false;
            this.exportGraphToXMLToolStripMenuItem.Enabled = true;
            this.toolStripButtonExportGraphToXML.Enabled = true;
            this.toolStripButtonGraphSummary.Enabled = true;
            this.graphToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// The dinitz blocking tool strip menu item click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void DinitzBlockingToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (this.dinitzBlockingToolStripMenuItem.Checked)
            {
                this.toolStripComboBoxAlgorithm.SelectedIndex = 2;
                this.fordFulkersonToolStripMenuItem.Checked = false;
                this.edmondsKarpToolStripMenuItem.Checked = false;
                return;
            }

            this.fordFulkersonToolStripMenuItem.Checked = false;
            this.edmondsKarpToolStripMenuItem.Checked = false;
            this.dinitzBlockingToolStripMenuItem.Checked = true;
        }

        /// <summary>
        /// The draw graph.
        /// </summary>
        private void DrawGraph()
        {
            this.networkVizualizationGraph = new Graph("Network Flow");
            foreach (GraphNode node in this.provider.NetworkFlowGraph.Nodes)
            {
                if (node.NodeMode == 1)
                {
                    Node srcNode = this.networkVizualizationGraph.AddNode(node.VertexId);

                    // srcNode.Attr.Shape = Shape.Circle;
                    srcNode.Attr.Fillcolor = Color.Yellow;
                    srcNode.Attr.LineWidth = 2;
                    srcNode.Attr.Color = Color.Red;
                }

                if (node.NodeMode == 2)
                {
                    Node srcNode = this.networkVizualizationGraph.AddNode(node.VertexId);

                    // srcNode.Attr.Shape = Shape.Circle;
                    srcNode.Attr.Fillcolor = Color.SkyBlue;
                    srcNode.Attr.LineWidth = 2;
                    srcNode.Attr.Color = Color.DarkSlateBlue;
                }

                if (node.Neighbours == null || node.Neighbours.Count == 0)
                {
                    this.networkVizualizationGraph.AddNode(node.VertexId);
                }

                for (int i = 0; i < node.Neighbours.Count; i++)
                {
                    if (node.Neighbours[i].IsResidual)
                    {
                        continue;
                    }

                    Edge edge = this.networkVizualizationGraph.AddEdge(
                        node.VertexId, 
                        "[" + node.Neighbours[i].MaxCapacity + "|" + node.Neighbours[i].Capacity + "]", 
                        node.Neighbours[i].NodeTo.VertexId);
                    edge.EdgeAttr.ArrowHeadAtTarget = ArrowStyle.Normal;
                    if (node.Neighbours[i].Capacity >= node.Neighbours[i].MaxCapacity)
                    {
                        continue;
                    }

                    edge.EdgeAttr.Color = Color.DarkRed;
                    edge.EdgeAttr.LineWidth = 2;
                }
            }

            this.graphViewer.Graph = this.networkVizualizationGraph;
        }

        /// <summary>
        /// The edit flow tool strip menu item click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void EditFlowToolStripMenuItemClick(object sender, EventArgs e)
        {
            var edge = this.graphViewer.SelectedObject as Edge;
            var editEdgeForm = new EditEdgeForm(edge.Attr.Label);
            editEdgeForm.ShowDialog();
            if (editEdgeForm.DialogResult == DialogResult.OK)
            {
                this.provider.EditEdge(edge.Source, edge.Target, editEdgeForm.Flow);
            }

            this.DrawGraph();
        }

        /// <summary>
        /// The edit node tool strip menu item click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void EditNodeToolStripMenuItemClick(object sender, EventArgs e)
        {
            string oldVertexId = (this.selectedObject as Node).Attr.Label;
            var editNodeForm = new EditNodeForm(this.provider, oldVertexId);
            editNodeForm.ShowDialog();
            if (editNodeForm.DialogResult == DialogResult.OK)
            {
                this.provider.EditNode(oldVertexId, editNodeForm.NewVertexId, editNodeForm.Mode);
            }

            this.DrawGraph();
        }

        /// <summary>
        /// The edmonds karp tool strip menu item click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void EdmondsKarpToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (this.edmondsKarpToolStripMenuItem.Checked)
            {
                this.toolStripComboBoxAlgorithm.SelectedIndex = 1;
                this.fordFulkersonToolStripMenuItem.Checked = false;
                this.dinitzBlockingToolStripMenuItem.Checked = false;
                return;
            }

            this.fordFulkersonToolStripMenuItem.Checked = false;
            this.edmondsKarpToolStripMenuItem.Checked = true;
            this.dinitzBlockingToolStripMenuItem.Checked = false;
        }

        /// <summary>
        /// The exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// The export graph to xml tool strip menu item click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ExportGraphToXmlToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.saveFileDialog.Title = "Export graph to XML file";
            this.saveFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            this.saveFileDialog.FilterIndex = 1;
            this.saveFileDialog.FileName = "NetworkFlowGraph";
            this.saveFileDialog.DefaultExt = "xml";
            DialogResult result = this.saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.toolStripProgressBar.Visible = true;
                this.toolStripStatusLabelState.Text = "Exporting graph...";
                this.backgroundWorkerExport.RunWorkerAsync(this.saveFileDialog.FileName);
                Application.DoEvents();
            }
        }

        /// <summary>
        /// The export results tool strip menu item click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ExportResultsToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.saveFileDialog.Title = "Export results to XML file";
            this.saveFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            this.saveFileDialog.FilterIndex = 1;
            this.saveFileDialog.FileName = "FlowResults";
            this.saveFileDialog.DefaultExt = "xml";
            DialogResult result = this.saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.provider.ExportResultsToXml(this.saveFileDialog.FileName);
            }
        }

        /// <summary>
        /// The ford fulkerson tool strip menu item click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void FordFulkersonToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (this.fordFulkersonToolStripMenuItem.Checked)
            {
                this.toolStripComboBoxAlgorithm.SelectedIndex = 0;
                this.edmondsKarpToolStripMenuItem.Checked = false;
                this.dinitzBlockingToolStripMenuItem.Checked = false;
                return;
            }

            this.fordFulkersonToolStripMenuItem.Checked = true;
            this.edmondsKarpToolStripMenuItem.Checked = false;
            this.dinitzBlockingToolStripMenuItem.Checked = false;
        }

        /// <summary>
        /// The graph viewer mouse click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void GraphViewerMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && this.selectedObject is Node)
            {
                Point point = this.graphViewer.PointToScreen(e.Location);
                point.Y += 28;
                this.editNodeToolStripMenuItem.Visible = true;
                this.removeNodeToolStripMenuItem.Visible = true;
                this.nodeContextMenuStrip.Show(point);
            }

            if (e.Button == MouseButtons.Right && this.selectedObject is Edge)
            {
                Point point = this.graphViewer.PointToScreen(e.Location);
                point.Y += 28;
                this.editFlowToolStripMenuItem.Visible = true;
                this.removeEdgeToolStripMenuItem.Visible = true;
                this.edgeContextMenuStrip.Show(point);
            }

            if (e.Button == MouseButtons.Right && (this.provider.NetworkFlowGraph != null)
                && !(this.selectedObject is Node) && !(this.selectedObject is Edge))
            {
                Point point = this.graphViewer.PointToScreen(e.Location);
                point.Y += 28;
                this.allContextMenuStrip.Show(point);
            }
        }

        /// <summary>
        /// The graph viewer selection changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void GraphViewerSelectionChanged(object sender, EventArgs e)
        {
            if (this.selectedObject != null)
            {
                if (this.selectedObject is Edge)
                {
                    (this.selectedObject as Edge).Attr = this.selectedObjectAttr as EdgeAttr;
                }
                else if (this.selectedObject is Node)
                {
                    (this.selectedObject as Node).Attr = this.selectedObjectAttr as NodeAttr;
                }

                this.selectedObject = null;
            }

            if (this.graphViewer.SelectedObject == null)
            {
                this.graphViewer.SetToolTip(this.toolTip, string.Empty);
            }
            else
            {
                this.selectedObject = this.graphViewer.SelectedObject;
                if (this.selectedObject is Edge)
                {
                    this.selectedObjectAttr = (this.graphViewer.SelectedObject as Edge).Attr.Clone();
                    (this.graphViewer.SelectedObject as Edge).Attr.Color = Color.Magenta;
                    (this.graphViewer.SelectedObject as Edge).Attr.Fontcolor = Color.Magenta;

                    var edge = this.graphViewer.SelectedObject as Edge;
                    this.graphViewer.SetToolTip(
                        this.toolTip,
                        string.Format(
                        "Edge from {0} to {1}" + Environment.NewLine + "Maximum capacity | left capacity: {2}",
                            edge.Source,
                            edge.Target,
                            edge.Attr.Label));
                }
                else if (this.selectedObject is Node)
                {
                    this.selectedObjectAttr = (this.graphViewer.SelectedObject as Node).Attr.Clone();
                    (this.graphViewer.SelectedObject as Node).Attr.Color = Color.Magenta;
                    (this.graphViewer.SelectedObject as Node).Attr.Fontcolor = Color.Magenta;

                    this.graphViewer.SetToolTip(
                        this.toolTip, string.Format("Node {0}", (this.selectedObject as Node).Attr.Label));
                }
            }

            this.graphViewer.Invalidate();
        }

        /// <summary>
        /// The load from xml tool strip menu item click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void LoadFromXmlToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.openFileDialog.Title = "Open network graph from XML file";
            this.openFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            this.openFileDialog.FilterIndex = 1;
            this.openFileDialog.FileName = string.Empty;
            DialogResult result = this.openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.toolStripProgressBar.Visible = true;
                this.toolStripStatusLabelState.Text = "Opening...";
                this.backgroundWorkerLoader.RunWorkerAsync(this.openFileDialog.FileName);
                Application.DoEvents();
            }
        }

        /// <summary>
        /// The new graph tool strip menu item click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void NewGraphToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (this.provider.NetworkFlowGraph != null)
            {
                if (
                    MessageBox.Show(
                        "It appears that you are working with another graph. Do you really want to create a new one?", 
                        "Confirm delete", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.provider.CreateNewGraph();
                    this.exportGraphToXMLToolStripMenuItem.Enabled = true;
                    this.DrawGraph();
                }
            }
            else
            {
                this.provider.CreateNewGraph();
                this.exportGraphToXMLToolStripMenuItem.Enabled = true;
                this.toolStripButtonExportGraphToXML.Enabled = true;
                this.toolStripButtonGraphSummary.Enabled = true;
                this.graphToolStripMenuItem.Enabled = true;
                this.DrawGraph();
            }
        }

        /// <summary>
        /// The prepare window.
        /// </summary>
        private void PrepareWindow()
        {
            this.toolStripStatusLabelValue.Text = "?";
            this.toolStripProgressBar.Visible = false;
            this.toolStripStatusLabelState.Text = "Ready";
            this.toolStripComboBoxAlgorithm.SelectedIndex = 0;
        }

        /// <summary>
        /// The remove edge tool strip menu item click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void RemoveEdgeToolStripMenuItemClick(object sender, EventArgs e)
        {
            var edge = this.graphViewer.SelectedObject as Edge;
            this.provider.RemoveEdge(edge.Source, edge.Target);
            this.DrawGraph();
        }

        /// <summary>
        /// The remove node tool strip menu item click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void RemoveNodeToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.provider.RemoveNode((this.selectedObject as Node).Attr.Label);
            this.DrawGraph();
        }

        /// <summary>
        /// The reset graph tool strip menu item click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ResetGraphToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.provider.ResetGraph();
            this.DrawGraph();
            this.toolStripStatusLabelValue.Text = "?";
            this.toolStripButtonExportResults.Enabled = false;
            this.exportResultsToolStripMenuItem.Enabled = false;
            if (this.enableCalculate)
            {
                this.toolStripButtonCalculateFlow.Enabled = true;
                this.calculateMaximumFlowToolStripMenuItem.Enabled = true;
            }
        }

        /// <summary>
        /// The set labels.
        /// </summary>
        /// <param name="flow">
        /// The flow.
        /// </param>
        private void SetLabels(int flow)
        {
            if (flow == -1)
            {
                this.toolStripButtonCalculateFlow.Enabled = false;
                this.calculateMaximumFlowToolStripMenuItem.Enabled = false;
                this.DrawGraph();
                this.toolStripStatusLabelResult.Text = "Maximum flow:";
            }
            else
            {
                this.DrawGraph();
                this.toolStripStatusLabelResult.Text = "Partial flow:";
                this.toolStripStatusLabelValue.Text = flow.ToString();
            }
        }

        /// <summary>
        /// The step by step tool strip menu item click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void StepByStepToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (this.stepByStepToolStripMenuItem.Checked)
            {
                this.stepByStep = true;
                return;
            }

            this.stepByStep = false;
        }

        /// <summary>
        /// The tool strip button about click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ToolStripButtonAboutClick(object sender, EventArgs e)
        {
            var about = new AboutForm();
            about.ShowDialog();
        }

        /// <summary>
        /// The tool strip button calculate flow click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ToolStripButtonCalculateFlowClick(object sender, EventArgs e)
        {
            if (!this.stepByStep)
            {
                int flow = 0;
                if (this.toolStripComboBoxAlgorithm.SelectedIndex == 0)
                {
                    flow = this.provider.FordFulkerson();
                }

                if (this.toolStripComboBoxAlgorithm.SelectedIndex == 1)
                {
                    flow = this.provider.EdmondsKarp();
                }

                if (this.toolStripComboBoxAlgorithm.SelectedIndex == 2)
                {
                    flow = this.provider.DinitzBlocking();
                }

                this.DrawGraph();
                this.toolStripStatusLabelResult.Text = "Maximum flow:";
                this.toolStripStatusLabelValue.Text = flow.ToString();
            }
            else
            {
                if (this.toolStripComboBoxAlgorithm.SelectedIndex == 0)
                {
                    int partialFlow = this.provider.StepByStepFordFulkerson();
                    this.SetLabels(partialFlow);
                }

                if (this.toolStripComboBoxAlgorithm.SelectedIndex == 1)
                {
                    int partialFlow = this.provider.StepByStepEdmondsKarp();
                    this.SetLabels(partialFlow);
                }

                if (this.toolStripComboBoxAlgorithm.SelectedIndex == 2)
                {
                    int partialFlow = this.provider.StepByStepDinitzBlocking();
                    this.SetLabels(partialFlow);
                }
            }

            this.toolStripButtonExportResults.Enabled = true;
            this.exportResultsToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// The tool strip button graph summary click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ToolStripButtonGraphSummaryClick(object sender, EventArgs e)
        {
            var graphSummary = new GraphSummary(this.provider);
            graphSummary.ShowDialog();
        }

        /// <summary>
        /// The tool strip combo box algorithm selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ToolStripComboBoxAlgorithmSelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = (ToolStripComboBox)sender;
            int index = cmb.SelectedIndex;
            switch (index)
            {
                case 0:
                    this.fordFulkersonToolStripMenuItem.Checked = true;
                    this.edmondsKarpToolStripMenuItem.Checked = false;
                    this.dinitzBlockingToolStripMenuItem.Checked = false;
                    break;

                case 1:
                    this.fordFulkersonToolStripMenuItem.Checked = false;
                    this.edmondsKarpToolStripMenuItem.Checked = true;
                    this.dinitzBlockingToolStripMenuItem.Checked = false;
                    break;

                case 2:
                    this.fordFulkersonToolStripMenuItem.Checked = false;
                    this.edmondsKarpToolStripMenuItem.Checked = false;
                    this.dinitzBlockingToolStripMenuItem.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// The button test_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void buttonTest_Click(object sender, EventArgs e)
        {
            this.provider.CreateNewGraph();

            /*provider.AddNode("vertex1", 1);
            provider.AddNode("vertex2");
            provider.AddNode("vertex3");
            provider.AddNode("vertex4");
            provider.AddNode("no edge", 2);
            this.provider.AddDirectedEdge("vertex1", "vertex2", 5);
            this.provider.AddDirectedEdge("vertex1", "vertex3", 4);
            this.provider.AddDirectedEdge("vertex3", "vertex1", 0);
            this.provider.AddDirectedEdge("vertex2", "vertex4", 6);
            this.provider.AddDirectedEdge("vertex3", "no edge", 5);
            this.provider.AddDirectedEdge("vertex4", "no edge", 5);*/
            this.provider.AddNode("s", 1);
            this.provider.AddNode("1");
            this.provider.AddNode("2");
            this.provider.AddNode("3");
            this.provider.AddNode("4");
            this.provider.AddNode("t", 2);
            this.provider.AddDirectedEdge("s", "1", 10);
            this.provider.AddDirectedEdge("s", "2", 10);
            this.provider.AddDirectedEdge("1", "2", 2);
            this.provider.AddDirectedEdge("1", "3", 4);
            this.provider.AddDirectedEdge("1", "4", 8);
            this.provider.AddDirectedEdge("2", "4", 9);
            this.provider.AddDirectedEdge("4", "3", 6);
            this.provider.AddDirectedEdge("3", "t", 10);
            this.provider.AddDirectedEdge("4", "t", 10);
            this.DrawGraph();
        }

        #endregion
    }
}