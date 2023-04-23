namespace SendGmailMulti
{
    partial class WriteEmailList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteEmailList));
            this.TextBoxW = new System.Windows.Forms.TextBox();
            this.PathTextBoxW = new System.Windows.Forms.TextBox();
            this.OpenButtonW = new System.Windows.Forms.Button();
            this.SaveAsButtonW = new System.Windows.Forms.Button();
            this.PathLabelW = new System.Windows.Forms.Label();
            this.CloseWriteEmailList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxW
            // 
            this.TextBoxW.Location = new System.Drawing.Point(9, 132);
            this.TextBoxW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxW.Multiline = true;
            this.TextBoxW.Name = "TextBoxW";
            this.TextBoxW.Size = new System.Drawing.Size(583, 240);
            this.TextBoxW.TabIndex = 0;
            // 
            // PathTextBoxW
            // 
            this.PathTextBoxW.Location = new System.Drawing.Point(62, 10);
            this.PathTextBoxW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PathTextBoxW.Name = "PathTextBoxW";
            this.PathTextBoxW.Size = new System.Drawing.Size(530, 20);
            this.PathTextBoxW.TabIndex = 1;
            // 
            // OpenButtonW
            // 
            this.OpenButtonW.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenButtonW.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenButtonW.Image = ((System.Drawing.Image)(resources.GetObject("OpenButtonW.Image")));
            this.OpenButtonW.Location = new System.Drawing.Point(408, 94);
            this.OpenButtonW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpenButtonW.Name = "OpenButtonW";
            this.OpenButtonW.Size = new System.Drawing.Size(89, 33);
            this.OpenButtonW.TabIndex = 2;
            this.OpenButtonW.Text = "Open";
            this.OpenButtonW.UseVisualStyleBackColor = true;
            this.OpenButtonW.Click += new System.EventHandler(this.OpenButtonW_Click);
            // 
            // SaveAsButtonW
            // 
            this.SaveAsButtonW.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAsButtonW.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveAsButtonW.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsButtonW.Image")));
            this.SaveAsButtonW.Location = new System.Drawing.Point(502, 94);
            this.SaveAsButtonW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveAsButtonW.Name = "SaveAsButtonW";
            this.SaveAsButtonW.Size = new System.Drawing.Size(89, 33);
            this.SaveAsButtonW.TabIndex = 4;
            this.SaveAsButtonW.Text = "Save as";
            this.SaveAsButtonW.UseVisualStyleBackColor = true;
            this.SaveAsButtonW.Click += new System.EventHandler(this.SaveAsButtonW_Click);
            // 
            // PathLabelW
            // 
            this.PathLabelW.AutoSize = true;
            this.PathLabelW.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabelW.Location = new System.Drawing.Point(9, 3);
            this.PathLabelW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PathLabelW.Name = "PathLabelW";
            this.PathLabelW.Size = new System.Drawing.Size(56, 25);
            this.PathLabelW.TabIndex = 5;
            this.PathLabelW.Text = "Path:";
            // 
            // CloseWriteEmailList
            // 
            this.CloseWriteEmailList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWriteEmailList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseWriteEmailList.Image = ((System.Drawing.Image)(resources.GetObject("CloseWriteEmailList.Image")));
            this.CloseWriteEmailList.Location = new System.Drawing.Point(9, 94);
            this.CloseWriteEmailList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseWriteEmailList.Name = "CloseWriteEmailList";
            this.CloseWriteEmailList.Size = new System.Drawing.Size(89, 33);
            this.CloseWriteEmailList.TabIndex = 6;
            this.CloseWriteEmailList.Text = "Close";
            this.CloseWriteEmailList.UseVisualStyleBackColor = true;
            this.CloseWriteEmailList.Click += new System.EventHandler(this.CloseWriteEmailList_Click);
            // 
            // WriteEmailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 382);
            this.Controls.Add(this.CloseWriteEmailList);
            this.Controls.Add(this.PathLabelW);
            this.Controls.Add(this.SaveAsButtonW);
            this.Controls.Add(this.OpenButtonW);
            this.Controls.Add(this.PathTextBoxW);
            this.Controls.Add(this.TextBoxW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WriteEmailList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Write Email List";
            this.Load += new System.EventHandler(this.WriteEmailList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxW;
        private System.Windows.Forms.TextBox PathTextBoxW;
        private System.Windows.Forms.Button OpenButtonW;
        private System.Windows.Forms.Button SaveAsButtonW;
        private System.Windows.Forms.Label PathLabelW;
        private System.Windows.Forms.Button CloseWriteEmailList;
    }
}