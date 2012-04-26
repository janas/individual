﻿namespace NetworkFlow
{
    partial class EditEdgeForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.labelFlow = new System.Windows.Forms.Label();
            this.maskedTextBoxFlow = new System.Windows.Forms.MaskedTextBox();
            this.toolTipEditEdge = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(84, 54);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 25);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // labelFlow
            // 
            this.labelFlow.AutoSize = true;
            this.labelFlow.Location = new System.Drawing.Point(22, 20);
            this.labelFlow.Name = "labelFlow";
            this.labelFlow.Size = new System.Drawing.Size(57, 13);
            this.labelFlow.TabIndex = 1;
            this.labelFlow.Text = "Enter flow:";
            // 
            // maskedTextBoxFlow
            // 
            this.maskedTextBoxFlow.HidePromptOnLeave = true;
            this.maskedTextBoxFlow.Location = new System.Drawing.Point(105, 17);
            this.maskedTextBoxFlow.Mask = "00";
            this.maskedTextBoxFlow.Name = "maskedTextBoxFlow";
            this.maskedTextBoxFlow.Size = new System.Drawing.Size(142, 20);
            this.maskedTextBoxFlow.TabIndex = 2;
            this.maskedTextBoxFlow.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBoxFlowMaskInputRejected);
            this.maskedTextBoxFlow.TextChanged += new System.EventHandler(this.MaskedTextBoxFlowTextChanged);
            // 
            // EditEdgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 87);
            this.Controls.Add(this.maskedTextBoxFlow);
            this.Controls.Add(this.labelFlow);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditEdgeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Edge Flow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label labelFlow;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFlow;
        private System.Windows.Forms.ToolTip toolTipEditEdge;
    }
}