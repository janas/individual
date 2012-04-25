namespace NetworkFlow
{
    partial class AddNodeForm
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
            this.labelVertexId = new System.Windows.Forms.Label();
            this.textBoxVertexId = new System.Windows.Forms.TextBox();
            this.toolTipVertexId = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(84, 54);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 25);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // labelVertexId
            // 
            this.labelVertexId.AutoSize = true;
            this.labelVertexId.Location = new System.Drawing.Point(12, 20);
            this.labelVertexId.Name = "labelVertexId";
            this.labelVertexId.Size = new System.Drawing.Size(105, 13);
            this.labelVertexId.TabIndex = 1;
            this.labelVertexId.Text = "Enter new Vertex ID:";
            // 
            // textBoxVertexId
            // 
            this.textBoxVertexId.Location = new System.Drawing.Point(120, 17);
            this.textBoxVertexId.Name = "textBoxVertexId";
            this.textBoxVertexId.Size = new System.Drawing.Size(135, 20);
            this.textBoxVertexId.TabIndex = 2;
            this.textBoxVertexId.TextChanged += new System.EventHandler(this.TextBoxVertexIdTextChanged);
            // 
            // AddNodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 87);
            this.Controls.Add(this.textBoxVertexId);
            this.Controls.Add(this.labelVertexId);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNodeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Node";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label labelVertexId;
        private System.Windows.Forms.TextBox textBoxVertexId;
        private System.Windows.Forms.ToolTip toolTipVertexId;
    }
}