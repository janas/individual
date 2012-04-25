namespace NetworkFlow
{
    partial class EditNodeForm
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
            this.labelVertexId = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.textBoxVertexId = new System.Windows.Forms.TextBox();
            this.toolTipVertexId = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxNodeMode = new System.Windows.Forms.ComboBox();
            this.labelNodeMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelVertexId
            // 
            this.labelVertexId.AutoSize = true;
            this.labelVertexId.Location = new System.Drawing.Point(12, 20);
            this.labelVertexId.Name = "labelVertexId";
            this.labelVertexId.Size = new System.Drawing.Size(105, 13);
            this.labelVertexId.TabIndex = 0;
            this.labelVertexId.Text = "Enter new Vertex ID:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(84, 79);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 25);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // textBoxVertexId
            // 
            this.textBoxVertexId.Location = new System.Drawing.Point(120, 17);
            this.textBoxVertexId.Name = "textBoxVertexId";
            this.textBoxVertexId.Size = new System.Drawing.Size(135, 20);
            this.textBoxVertexId.TabIndex = 2;
            this.textBoxVertexId.TextChanged += new System.EventHandler(this.TextBoxVertexIdTextChanged);
            // 
            // comboBoxNodeMode
            // 
            this.comboBoxNodeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNodeMode.FormattingEnabled = true;
            this.comboBoxNodeMode.Items.AddRange(new object[] {
            "Normal",
            "Source",
            "Sink"});
            this.comboBoxNodeMode.Location = new System.Drawing.Point(120, 45);
            this.comboBoxNodeMode.Name = "comboBoxNodeMode";
            this.comboBoxNodeMode.Size = new System.Drawing.Size(135, 21);
            this.comboBoxNodeMode.TabIndex = 3;
            this.comboBoxNodeMode.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNodeModeSelectedIndexChanged);
            // 
            // labelNodeMode
            // 
            this.labelNodeMode.AutoSize = true;
            this.labelNodeMode.Location = new System.Drawing.Point(12, 48);
            this.labelNodeMode.Name = "labelNodeMode";
            this.labelNodeMode.Size = new System.Drawing.Size(102, 13);
            this.labelNodeMode.TabIndex = 4;
            this.labelNodeMode.Text = "Choose node mode:";
            // 
            // EditNodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 117);
            this.Controls.Add(this.labelNodeMode);
            this.Controls.Add(this.comboBoxNodeMode);
            this.Controls.Add(this.textBoxVertexId);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labelVertexId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditNodeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit selected Vertex ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVertexId;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textBoxVertexId;
        private System.Windows.Forms.ToolTip toolTipVertexId;
        private System.Windows.Forms.ComboBox comboBoxNodeMode;
        private System.Windows.Forms.Label labelNodeMode;
    }
}