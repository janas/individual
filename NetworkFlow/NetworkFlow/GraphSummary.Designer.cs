namespace NetworkFlow
{
    partial class GraphSummary
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
            this.labelNoOfNodes = new System.Windows.Forms.Label();
            this.labelNoOfEdges = new System.Windows.Forms.Label();
            this.labelSrcNode = new System.Windows.Forms.Label();
            this.labelSinkNode = new System.Windows.Forms.Label();
            this.labelMaxFlow = new System.Windows.Forms.Label();
            this.labelNodesValue = new System.Windows.Forms.Label();
            this.labelEdgesValue = new System.Windows.Forms.Label();
            this.labelSrcNodeValue = new System.Windows.Forms.Label();
            this.labelSinkNodeValue = new System.Windows.Forms.Label();
            this.labelMaxFlowValue = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNoOfNodes
            // 
            this.labelNoOfNodes.AutoSize = true;
            this.labelNoOfNodes.Location = new System.Drawing.Point(25, 30);
            this.labelNoOfNodes.Name = "labelNoOfNodes";
            this.labelNoOfNodes.Size = new System.Drawing.Size(93, 13);
            this.labelNoOfNodes.TabIndex = 0;
            this.labelNoOfNodes.Text = "Number of Nodes:";
            // 
            // labelNoOfEdges
            // 
            this.labelNoOfEdges.AutoSize = true;
            this.labelNoOfEdges.Location = new System.Drawing.Point(25, 53);
            this.labelNoOfEdges.Name = "labelNoOfEdges";
            this.labelNoOfEdges.Size = new System.Drawing.Size(92, 13);
            this.labelNoOfEdges.TabIndex = 1;
            this.labelNoOfEdges.Text = "Number of Edges:";
            // 
            // labelSrcNode
            // 
            this.labelSrcNode.AutoSize = true;
            this.labelSrcNode.Location = new System.Drawing.Point(25, 76);
            this.labelSrcNode.Name = "labelSrcNode";
            this.labelSrcNode.Size = new System.Drawing.Size(73, 13);
            this.labelSrcNode.TabIndex = 2;
            this.labelSrcNode.Text = "Source Node:";
            // 
            // labelSinkNode
            // 
            this.labelSinkNode.AutoSize = true;
            this.labelSinkNode.Location = new System.Drawing.Point(25, 99);
            this.labelSinkNode.Name = "labelSinkNode";
            this.labelSinkNode.Size = new System.Drawing.Size(60, 13);
            this.labelSinkNode.TabIndex = 3;
            this.labelSinkNode.Text = "Sink Node:";
            // 
            // labelMaxFlow
            // 
            this.labelMaxFlow.AutoSize = true;
            this.labelMaxFlow.Location = new System.Drawing.Point(25, 122);
            this.labelMaxFlow.Name = "labelMaxFlow";
            this.labelMaxFlow.Size = new System.Drawing.Size(79, 13);
            this.labelMaxFlow.TabIndex = 4;
            this.labelMaxFlow.Text = "Maximum Flow:";
            // 
            // labelNodesValue
            // 
            this.labelNodesValue.AutoSize = true;
            this.labelNodesValue.Location = new System.Drawing.Point(140, 30);
            this.labelNodesValue.Name = "labelNodesValue";
            this.labelNodesValue.Size = new System.Drawing.Size(35, 13);
            this.labelNodesValue.TabIndex = 5;
            this.labelNodesValue.Text = "label1";
            // 
            // labelEdgesValue
            // 
            this.labelEdgesValue.AutoSize = true;
            this.labelEdgesValue.Location = new System.Drawing.Point(140, 54);
            this.labelEdgesValue.Name = "labelEdgesValue";
            this.labelEdgesValue.Size = new System.Drawing.Size(35, 13);
            this.labelEdgesValue.TabIndex = 6;
            this.labelEdgesValue.Text = "label2";
            // 
            // labelSrcNodeValue
            // 
            this.labelSrcNodeValue.AutoSize = true;
            this.labelSrcNodeValue.Location = new System.Drawing.Point(140, 78);
            this.labelSrcNodeValue.Name = "labelSrcNodeValue";
            this.labelSrcNodeValue.Size = new System.Drawing.Size(35, 13);
            this.labelSrcNodeValue.TabIndex = 7;
            this.labelSrcNodeValue.Text = "label3";
            // 
            // labelSinkNodeValue
            // 
            this.labelSinkNodeValue.AutoSize = true;
            this.labelSinkNodeValue.Location = new System.Drawing.Point(140, 100);
            this.labelSinkNodeValue.Name = "labelSinkNodeValue";
            this.labelSinkNodeValue.Size = new System.Drawing.Size(35, 13);
            this.labelSinkNodeValue.TabIndex = 8;
            this.labelSinkNodeValue.Text = "label4";
            // 
            // labelMaxFlowValue
            // 
            this.labelMaxFlowValue.AutoSize = true;
            this.labelMaxFlowValue.Location = new System.Drawing.Point(140, 122);
            this.labelMaxFlowValue.Name = "labelMaxFlowValue";
            this.labelMaxFlowValue.Size = new System.Drawing.Size(35, 13);
            this.labelMaxFlowValue.TabIndex = 9;
            this.labelMaxFlowValue.Text = "label5";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(77, 167);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // GraphSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 212);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labelMaxFlowValue);
            this.Controls.Add(this.labelSinkNodeValue);
            this.Controls.Add(this.labelSrcNodeValue);
            this.Controls.Add(this.labelEdgesValue);
            this.Controls.Add(this.labelNodesValue);
            this.Controls.Add(this.labelMaxFlow);
            this.Controls.Add(this.labelSinkNode);
            this.Controls.Add(this.labelSrcNode);
            this.Controls.Add(this.labelNoOfEdges);
            this.Controls.Add(this.labelNoOfNodes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GraphSummary";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Graph Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNoOfNodes;
        private System.Windows.Forms.Label labelNoOfEdges;
        private System.Windows.Forms.Label labelSrcNode;
        private System.Windows.Forms.Label labelSinkNode;
        private System.Windows.Forms.Label labelMaxFlow;
        private System.Windows.Forms.Label labelNodesValue;
        private System.Windows.Forms.Label labelEdgesValue;
        private System.Windows.Forms.Label labelSrcNodeValue;
        private System.Windows.Forms.Label labelSinkNodeValue;
        private System.Windows.Forms.Label labelMaxFlowValue;
        private System.Windows.Forms.Button btnOK;
    }
}