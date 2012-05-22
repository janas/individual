namespace NetworkFlow
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportGraphToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fordFulkersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edmondsKarpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinitzBlockingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepByStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateMaximumFlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editFlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEdgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEdgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphViewer = new Microsoft.Glee.GraphViewerGdi.GViewer();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAlign = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewGraph = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLoadFromXML = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExportGraphToXML = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExportResults = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonGraphSummary = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelAlgorithm = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxAlgorithm = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonCalculateFlow = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorkerLoader = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerExport = new System.ComponentModel.BackgroundWorker();
            this.menuStrip.SuspendLayout();
            this.edgeContextMenuStrip.SuspendLayout();
            this.nodeContextMenuStrip.SuspendLayout();
            this.allContextMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.processToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(684, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGraphToolStripMenuItem,
            this.loadFromXMLToolStripMenuItem,
            this.toolStripMenuItemSeparator1,
            this.exportGraphToXMLToolStripMenuItem,
            this.exportResultsToolStripMenuItem,
            this.toolStripMenuItemSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newGraphToolStripMenuItem
            // 
            this.newGraphToolStripMenuItem.Name = "newGraphToolStripMenuItem";
            this.newGraphToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newGraphToolStripMenuItem.Text = "&New Graph";
            this.newGraphToolStripMenuItem.Click += new System.EventHandler(this.NewGraphToolStripMenuItemClick);
            // 
            // loadFromXMLToolStripMenuItem
            // 
            this.loadFromXMLToolStripMenuItem.Name = "loadFromXMLToolStripMenuItem";
            this.loadFromXMLToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.loadFromXMLToolStripMenuItem.Text = "&Load From XML";
            this.loadFromXMLToolStripMenuItem.Click += new System.EventHandler(this.LoadFromXmlToolStripMenuItemClick);
            // 
            // toolStripMenuItemSeparator1
            // 
            this.toolStripMenuItemSeparator1.Name = "toolStripMenuItemSeparator1";
            this.toolStripMenuItemSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // exportGraphToXMLToolStripMenuItem
            // 
            this.exportGraphToXMLToolStripMenuItem.Enabled = false;
            this.exportGraphToXMLToolStripMenuItem.Name = "exportGraphToXMLToolStripMenuItem";
            this.exportGraphToXMLToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exportGraphToXMLToolStripMenuItem.Text = "Export &Graph to XML";
            this.exportGraphToXMLToolStripMenuItem.Click += new System.EventHandler(this.ExportGraphToXmlToolStripMenuItemClick);
            // 
            // exportResultsToolStripMenuItem
            // 
            this.exportResultsToolStripMenuItem.Enabled = false;
            this.exportResultsToolStripMenuItem.Name = "exportResultsToolStripMenuItem";
            this.exportResultsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exportResultsToolStripMenuItem.Text = "Export &Results";
            this.exportResultsToolStripMenuItem.Click += new System.EventHandler(this.ExportResultsToolStripMenuItemClick);
            // 
            // toolStripMenuItemSeparator2
            // 
            this.toolStripMenuItemSeparator2.Name = "toolStripMenuItemSeparator2";
            this.toolStripMenuItemSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripMenuItem,
            this.chooseAlgorithmToolStripMenuItem,
            this.stepByStepToolStripMenuItem,
            this.resetGraphToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.Enabled = false;
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.graphToolStripMenuItem.Text = "Gra&ph";
            this.graphToolStripMenuItem.Click += new System.EventHandler(this.ToolStripButtonGraphSummaryClick);
            // 
            // chooseAlgorithmToolStripMenuItem
            // 
            this.chooseAlgorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fordFulkersonToolStripMenuItem,
            this.edmondsKarpToolStripMenuItem,
            this.dinitzBlockingToolStripMenuItem});
            this.chooseAlgorithmToolStripMenuItem.Name = "chooseAlgorithmToolStripMenuItem";
            this.chooseAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.chooseAlgorithmToolStripMenuItem.Text = "&Choose Algorithm";
            // 
            // fordFulkersonToolStripMenuItem
            // 
            this.fordFulkersonToolStripMenuItem.CheckOnClick = true;
            this.fordFulkersonToolStripMenuItem.Name = "fordFulkersonToolStripMenuItem";
            this.fordFulkersonToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.fordFulkersonToolStripMenuItem.Text = "F&ord-Fulkerson";
            this.fordFulkersonToolStripMenuItem.Click += new System.EventHandler(this.FordFulkersonToolStripMenuItemClick);
            // 
            // edmondsKarpToolStripMenuItem
            // 
            this.edmondsKarpToolStripMenuItem.CheckOnClick = true;
            this.edmondsKarpToolStripMenuItem.Name = "edmondsKarpToolStripMenuItem";
            this.edmondsKarpToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.edmondsKarpToolStripMenuItem.Text = "E&dmonds-Karp";
            this.edmondsKarpToolStripMenuItem.Click += new System.EventHandler(this.EdmondsKarpToolStripMenuItemClick);
            // 
            // dinitzBlockingToolStripMenuItem
            // 
            this.dinitzBlockingToolStripMenuItem.CheckOnClick = true;
            this.dinitzBlockingToolStripMenuItem.Name = "dinitzBlockingToolStripMenuItem";
            this.dinitzBlockingToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.dinitzBlockingToolStripMenuItem.Text = "D&initz Blocking";
            this.dinitzBlockingToolStripMenuItem.Click += new System.EventHandler(this.DinitzBlockingToolStripMenuItemClick);
            // 
            // stepByStepToolStripMenuItem
            // 
            this.stepByStepToolStripMenuItem.CheckOnClick = true;
            this.stepByStepToolStripMenuItem.Name = "stepByStepToolStripMenuItem";
            this.stepByStepToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.stepByStepToolStripMenuItem.Text = "&Step by Step";
            this.stepByStepToolStripMenuItem.Click += new System.EventHandler(this.StepByStepToolStripMenuItemClick);
            // 
            // resetGraphToolStripMenuItem
            // 
            this.resetGraphToolStripMenuItem.Name = "resetGraphToolStripMenuItem";
            this.resetGraphToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.resetGraphToolStripMenuItem.Text = "Rese&t Graph";
            this.resetGraphToolStripMenuItem.Click += new System.EventHandler(this.ResetGraphToolStripMenuItemClick);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateMaximumFlowToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "&Process";
            // 
            // calculateMaximumFlowToolStripMenuItem
            // 
            this.calculateMaximumFlowToolStripMenuItem.Enabled = false;
            this.calculateMaximumFlowToolStripMenuItem.Name = "calculateMaximumFlowToolStripMenuItem";
            this.calculateMaximumFlowToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.calculateMaximumFlowToolStripMenuItem.Text = "Calculate &Maximum Flow";
            this.calculateMaximumFlowToolStripMenuItem.Click += new System.EventHandler(this.ToolStripButtonCalculateFlowClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.ToolStripButtonAboutClick);
            // 
            // edgeContextMenuStrip
            // 
            this.edgeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editFlowToolStripMenuItem,
            this.removeEdgeToolStripMenuItem});
            this.edgeContextMenuStrip.Name = "edgeContextMenuStrip";
            this.edgeContextMenuStrip.Size = new System.Drawing.Size(147, 48);
            // 
            // editFlowToolStripMenuItem
            // 
            this.editFlowToolStripMenuItem.Name = "editFlowToolStripMenuItem";
            this.editFlowToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editFlowToolStripMenuItem.Text = "Edit Flow";
            this.editFlowToolStripMenuItem.Click += new System.EventHandler(this.EditFlowToolStripMenuItemClick);
            // 
            // removeEdgeToolStripMenuItem
            // 
            this.removeEdgeToolStripMenuItem.Name = "removeEdgeToolStripMenuItem";
            this.removeEdgeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.removeEdgeToolStripMenuItem.Text = "Remove Edge";
            this.removeEdgeToolStripMenuItem.Click += new System.EventHandler(this.RemoveEdgeToolStripMenuItemClick);
            // 
            // nodeContextMenuStrip
            // 
            this.nodeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editNodeToolStripMenuItem,
            this.removeNodeToolStripMenuItem});
            this.nodeContextMenuStrip.Name = "nodeContextMenuStrip";
            this.nodeContextMenuStrip.Size = new System.Drawing.Size(150, 48);
            // 
            // editNodeToolStripMenuItem
            // 
            this.editNodeToolStripMenuItem.Name = "editNodeToolStripMenuItem";
            this.editNodeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.editNodeToolStripMenuItem.Text = "Edit Node";
            this.editNodeToolStripMenuItem.Click += new System.EventHandler(this.EditNodeToolStripMenuItemClick);
            // 
            // removeNodeToolStripMenuItem
            // 
            this.removeNodeToolStripMenuItem.Name = "removeNodeToolStripMenuItem";
            this.removeNodeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.removeNodeToolStripMenuItem.Text = "Remove Node";
            this.removeNodeToolStripMenuItem.Click += new System.EventHandler(this.RemoveNodeToolStripMenuItemClick);
            // 
            // allContextMenuStrip
            // 
            this.allContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNodeToolStripMenuItem,
            this.addEdgeToolStripMenuItem});
            this.allContextMenuStrip.Name = "allContextMenuStrip";
            this.allContextMenuStrip.Size = new System.Drawing.Size(129, 48);
            this.allContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.AllContextMenuStripOpening);
            // 
            // addNodeToolStripMenuItem
            // 
            this.addNodeToolStripMenuItem.Name = "addNodeToolStripMenuItem";
            this.addNodeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addNodeToolStripMenuItem.Text = "Add Node";
            this.addNodeToolStripMenuItem.Click += new System.EventHandler(this.AddNodeToolStripMenuItemClick);
            // 
            // addEdgeToolStripMenuItem
            // 
            this.addEdgeToolStripMenuItem.Name = "addEdgeToolStripMenuItem";
            this.addEdgeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addEdgeToolStripMenuItem.Text = "Add Edge";
            this.addEdgeToolStripMenuItem.Click += new System.EventHandler(this.AddEdgeToolStripMenuItemClick);
            // 
            // graphViewer
            // 
            this.graphViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.graphViewer.AsyncLayout = false;
            this.graphViewer.AutoScroll = true;
            this.graphViewer.BackwardEnabled = false;
            this.graphViewer.ForwardEnabled = false;
            this.graphViewer.Graph = null;
            this.graphViewer.Location = new System.Drawing.Point(12, 65);
            this.graphViewer.MouseHitDistance = 0.05D;
            this.graphViewer.Name = "graphViewer";
            this.graphViewer.NavigationVisible = true;
            this.graphViewer.PanButtonPressed = false;
            this.graphViewer.SaveButtonVisible = true;
            this.graphViewer.Size = new System.Drawing.Size(660, 372);
            this.graphViewer.TabIndex = 4;
            this.graphViewer.ZoomF = 1D;
            this.graphViewer.ZoomFraction = 0.5D;
            this.graphViewer.ZoomWindowThreshold = 0.05D;
            this.graphViewer.SelectionChanged += new System.EventHandler(this.GraphViewerSelectionChanged);
            this.graphViewer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GraphViewerMouseClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelResult,
            this.toolStripStatusLabelValue,
            this.toolStripStatusLabelAlign,
            this.toolStripStatusLabelState,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 440);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(684, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabelResult
            // 
            this.toolStripStatusLabelResult.Name = "toolStripStatusLabelResult";
            this.toolStripStatusLabelResult.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabelResult.Text = "Maximum flow:";
            // 
            // toolStripStatusLabelValue
            // 
            this.toolStripStatusLabelValue.Name = "toolStripStatusLabelValue";
            this.toolStripStatusLabelValue.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelValue.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabelAlign
            // 
            this.toolStripStatusLabelAlign.Name = "toolStripStatusLabelAlign";
            this.toolStripStatusLabelAlign.Size = new System.Drawing.Size(241, 17);
            this.toolStripStatusLabelAlign.Spring = true;
            // 
            // toolStripStatusLabelState
            // 
            this.toolStripStatusLabelState.Name = "toolStripStatusLabelState";
            this.toolStripStatusLabelState.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelState.Text = "toolStripStatusLabel2";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewGraph,
            this.toolStripButtonLoadFromXML,
            this.toolStripButtonExportGraphToXML,
            this.toolStripButtonExportResults,
            this.toolStripSeparator1,
            this.toolStripButtonGraphSummary,
            this.toolStripLabelAlgorithm,
            this.toolStripComboBoxAlgorithm,
            this.toolStripButtonCalculateFlow,
            this.toolStripSeparator2,
            this.toolStripButtonAbout,
            this.toolStripButtonExit});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(684, 38);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonNewGraph
            // 
            this.toolStripButtonNewGraph.AutoSize = false;
            this.toolStripButtonNewGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewGraph.Image = global::NetworkFlow.Properties.Resources.new_graph_icon;
            this.toolStripButtonNewGraph.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonNewGraph.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewGraph.Name = "toolStripButtonNewGraph";
            this.toolStripButtonNewGraph.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonNewGraph.Text = "New Graph";
            this.toolStripButtonNewGraph.Click += new System.EventHandler(this.NewGraphToolStripMenuItemClick);
            // 
            // toolStripButtonLoadFromXML
            // 
            this.toolStripButtonLoadFromXML.AutoSize = false;
            this.toolStripButtonLoadFromXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLoadFromXML.Image = global::NetworkFlow.Properties.Resources.open_graph_icon;
            this.toolStripButtonLoadFromXML.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonLoadFromXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadFromXML.Name = "toolStripButtonLoadFromXML";
            this.toolStripButtonLoadFromXML.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonLoadFromXML.Text = "Load From XML";
            this.toolStripButtonLoadFromXML.Click += new System.EventHandler(this.LoadFromXmlToolStripMenuItemClick);
            // 
            // toolStripButtonExportGraphToXML
            // 
            this.toolStripButtonExportGraphToXML.AutoSize = false;
            this.toolStripButtonExportGraphToXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExportGraphToXML.Enabled = false;
            this.toolStripButtonExportGraphToXML.Image = global::NetworkFlow.Properties.Resources.save_graph_icon;
            this.toolStripButtonExportGraphToXML.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonExportGraphToXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExportGraphToXML.Name = "toolStripButtonExportGraphToXML";
            this.toolStripButtonExportGraphToXML.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonExportGraphToXML.Text = "Export Graph to XML";
            this.toolStripButtonExportGraphToXML.Click += new System.EventHandler(this.ExportGraphToXmlToolStripMenuItemClick);
            // 
            // toolStripButtonExportResults
            // 
            this.toolStripButtonExportResults.AutoSize = false;
            this.toolStripButtonExportResults.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExportResults.Enabled = false;
            this.toolStripButtonExportResults.Image = global::NetworkFlow.Properties.Resources.save_results_icon;
            this.toolStripButtonExportResults.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonExportResults.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExportResults.Name = "toolStripButtonExportResults";
            this.toolStripButtonExportResults.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonExportResults.Text = "Export Results";
            this.toolStripButtonExportResults.Click += new System.EventHandler(this.ExportResultsToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButtonGraphSummary
            // 
            this.toolStripButtonGraphSummary.AutoSize = false;
            this.toolStripButtonGraphSummary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGraphSummary.Enabled = false;
            this.toolStripButtonGraphSummary.Image = global::NetworkFlow.Properties.Resources.graph_icon;
            this.toolStripButtonGraphSummary.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonGraphSummary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGraphSummary.Name = "toolStripButtonGraphSummary";
            this.toolStripButtonGraphSummary.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonGraphSummary.Text = "Graph Summary";
            this.toolStripButtonGraphSummary.Click += new System.EventHandler(this.ToolStripButtonGraphSummaryClick);
            // 
            // toolStripLabelAlgorithm
            // 
            this.toolStripLabelAlgorithm.Name = "toolStripLabelAlgorithm";
            this.toolStripLabelAlgorithm.Size = new System.Drawing.Size(64, 35);
            this.toolStripLabelAlgorithm.Text = "Algorithm:";
            // 
            // toolStripComboBoxAlgorithm
            // 
            this.toolStripComboBoxAlgorithm.AutoSize = false;
            this.toolStripComboBoxAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxAlgorithm.Items.AddRange(new object[] {
            "Ford-Fulkerson",
            "Edmonds-Karp",
            "Dinitz Blocking"});
            this.toolStripComboBoxAlgorithm.Name = "toolStripComboBoxAlgorithm";
            this.toolStripComboBoxAlgorithm.Size = new System.Drawing.Size(110, 23);
            this.toolStripComboBoxAlgorithm.SelectedIndexChanged += new System.EventHandler(this.ToolStripComboBoxAlgorithmSelectedIndexChanged);
            // 
            // toolStripButtonCalculateFlow
            // 
            this.toolStripButtonCalculateFlow.AutoSize = false;
            this.toolStripButtonCalculateFlow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCalculateFlow.Enabled = false;
            this.toolStripButtonCalculateFlow.Image = global::NetworkFlow.Properties.Resources.calculate_flow_icon;
            this.toolStripButtonCalculateFlow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonCalculateFlow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCalculateFlow.Name = "toolStripButtonCalculateFlow";
            this.toolStripButtonCalculateFlow.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonCalculateFlow.Text = "Calculate Maximum Flow";
            this.toolStripButtonCalculateFlow.Click += new System.EventHandler(this.ToolStripButtonCalculateFlowClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.AutoSize = false;
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = global::NetworkFlow.Properties.Resources.about_icon;
            this.toolStripButtonAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonAbout.Text = "About";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.ToolStripButtonAboutClick);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.AutoSize = false;
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = global::NetworkFlow.Properties.Resources.exit_icon;
            this.toolStripButtonExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonExit.Text = "Exit";
            this.toolStripButtonExit.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // backgroundWorkerLoader
            // 
            this.backgroundWorkerLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerLoaderDoWork);
            this.backgroundWorkerLoader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerLoaderRunWorkerCompleted);
            // 
            // backgroundWorkerExport
            // 
            this.backgroundWorkerExport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerExportDoWork);
            this.backgroundWorkerExport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerExportRunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.graphViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Flow";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.edgeContextMenuStrip.ResumeLayout(false);
            this.nodeContextMenuStrip.ResumeLayout(false);
            this.allContextMenuStrip.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItemSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItemSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseAlgorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fordFulkersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edmondsKarpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinitzBlockingToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip edgeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editFlowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEdgeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip nodeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNodeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip allContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEdgeToolStripMenuItem;
        private Microsoft.Glee.GraphViewerGdi.GViewer graphViewer;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateMaximumFlowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportGraphToXMLToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewGraph;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadFromXML;
        private System.Windows.Forms.ToolStripButton toolStripButtonExportGraphToXML;
        private System.Windows.Forms.ToolStripButton toolStripButtonExportResults;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxAlgorithm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripButton toolStripButtonCalculateFlow;
        private System.Windows.Forms.ToolStripLabel toolStripLabelAlgorithm;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStripButton toolStripButtonGraphSummary;
        private System.Windows.Forms.ToolStripMenuItem stepByStepToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelResult;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelValue;
        private System.Windows.Forms.ToolStripMenuItem resetGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAlign;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelState;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoader;
        private System.ComponentModel.BackgroundWorker backgroundWorkerExport;
    }
}