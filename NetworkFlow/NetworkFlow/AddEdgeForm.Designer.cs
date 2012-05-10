namespace NetworkFlow
{
    partial class AddEdgeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEdgeForm));
            this.labelFlow = new System.Windows.Forms.Label();
            this.maskedTextBoxFlow = new System.Windows.Forms.MaskedTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.toolTipEgde = new System.Windows.Forms.ToolTip(this.components);
            this.labelSourceVertexId = new System.Windows.Forms.Label();
            this.labelTargetVertexId = new System.Windows.Forms.Label();
            this.comboBoxSourceVertexId = new System.Windows.Forms.ComboBox();
            this.comboBoxTargetVertexId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelFlow
            // 
            this.labelFlow.AutoSize = true;
            this.labelFlow.Location = new System.Drawing.Point(12, 76);
            this.labelFlow.Name = "labelFlow";
            this.labelFlow.Size = new System.Drawing.Size(57, 13);
            this.labelFlow.TabIndex = 0;
            this.labelFlow.Text = "Enter flow:";
            // 
            // maskedTextBoxFlow
            // 
            this.maskedTextBoxFlow.HidePromptOnLeave = true;
            this.maskedTextBoxFlow.Location = new System.Drawing.Point(152, 74);
            this.maskedTextBoxFlow.Mask = "00";
            this.maskedTextBoxFlow.Name = "maskedTextBoxFlow";
            this.maskedTextBoxFlow.Size = new System.Drawing.Size(139, 20);
            this.maskedTextBoxFlow.TabIndex = 1;
            this.maskedTextBoxFlow.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBoxFlowMaskInputRejected);
            this.maskedTextBoxFlow.TextChanged += new System.EventHandler(this.MaskedTextBoxFlowTextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(102, 117);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 25);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // labelSourceVertexId
            // 
            this.labelSourceVertexId.AutoSize = true;
            this.labelSourceVertexId.Location = new System.Drawing.Point(12, 20);
            this.labelSourceVertexId.Name = "labelSourceVertexId";
            this.labelSourceVertexId.Size = new System.Drawing.Size(117, 13);
            this.labelSourceVertexId.TabIndex = 5;
            this.labelSourceVertexId.Text = "Enter source Vertex ID:";
            // 
            // labelTargetVertexId
            // 
            this.labelTargetVertexId.AutoSize = true;
            this.labelTargetVertexId.Location = new System.Drawing.Point(12, 48);
            this.labelTargetVertexId.Name = "labelTargetVertexId";
            this.labelTargetVertexId.Size = new System.Drawing.Size(112, 13);
            this.labelTargetVertexId.TabIndex = 6;
            this.labelTargetVertexId.Text = "Enter target Vertex ID:";
            // 
            // comboBoxSourceVertexId
            // 
            this.comboBoxSourceVertexId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSourceVertexId.FormattingEnabled = true;
            this.comboBoxSourceVertexId.Location = new System.Drawing.Point(152, 17);
            this.comboBoxSourceVertexId.Name = "comboBoxSourceVertexId";
            this.comboBoxSourceVertexId.Size = new System.Drawing.Size(139, 21);
            this.comboBoxSourceVertexId.TabIndex = 7;
            this.comboBoxSourceVertexId.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSourceVertexIdSelectedIndexChanged);
            // 
            // comboBoxTargetVertexId
            // 
            this.comboBoxTargetVertexId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTargetVertexId.Enabled = false;
            this.comboBoxTargetVertexId.FormattingEnabled = true;
            this.comboBoxTargetVertexId.Location = new System.Drawing.Point(152, 45);
            this.comboBoxTargetVertexId.Name = "comboBoxTargetVertexId";
            this.comboBoxTargetVertexId.Size = new System.Drawing.Size(139, 21);
            this.comboBoxTargetVertexId.TabIndex = 8;
            this.comboBoxTargetVertexId.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTargetVertexIdSelectedIndexChanged);
            // 
            // AddEdgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 157);
            this.Controls.Add(this.comboBoxTargetVertexId);
            this.Controls.Add(this.comboBoxSourceVertexId);
            this.Controls.Add(this.labelTargetVertexId);
            this.Controls.Add(this.labelSourceVertexId);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.maskedTextBoxFlow);
            this.Controls.Add(this.labelFlow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEdgeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Edge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFlow;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFlow;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ToolTip toolTipEgde;
        private System.Windows.Forms.Label labelSourceVertexId;
        private System.Windows.Forms.Label labelTargetVertexId;
        private System.Windows.Forms.ComboBox comboBoxSourceVertexId;
        private System.Windows.Forms.ComboBox comboBoxTargetVertexId;
    }
}