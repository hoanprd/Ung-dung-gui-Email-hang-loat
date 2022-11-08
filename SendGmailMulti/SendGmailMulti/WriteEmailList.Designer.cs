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
            this.TextBoxW.Location = new System.Drawing.Point(12, 163);
            this.TextBoxW.Multiline = true;
            this.TextBoxW.Name = "TextBoxW";
            this.TextBoxW.Size = new System.Drawing.Size(776, 295);
            this.TextBoxW.TabIndex = 0;
            // 
            // PathTextBoxW
            // 
            this.PathTextBoxW.Location = new System.Drawing.Point(83, 12);
            this.PathTextBoxW.Name = "PathTextBoxW";
            this.PathTextBoxW.Size = new System.Drawing.Size(705, 22);
            this.PathTextBoxW.TabIndex = 1;
            // 
            // OpenButtonW
            // 
            this.OpenButtonW.Location = new System.Drawing.Point(544, 116);
            this.OpenButtonW.Name = "OpenButtonW";
            this.OpenButtonW.Size = new System.Drawing.Size(119, 41);
            this.OpenButtonW.TabIndex = 2;
            this.OpenButtonW.Text = "Open";
            this.OpenButtonW.UseVisualStyleBackColor = true;
            this.OpenButtonW.Click += new System.EventHandler(this.OpenButtonW_Click);
            // 
            // SaveAsButtonW
            // 
            this.SaveAsButtonW.Location = new System.Drawing.Point(669, 116);
            this.SaveAsButtonW.Name = "SaveAsButtonW";
            this.SaveAsButtonW.Size = new System.Drawing.Size(119, 41);
            this.SaveAsButtonW.TabIndex = 4;
            this.SaveAsButtonW.Text = "Save as";
            this.SaveAsButtonW.UseVisualStyleBackColor = true;
            this.SaveAsButtonW.Click += new System.EventHandler(this.SaveAsButtonW_Click);
            // 
            // PathLabelW
            // 
            this.PathLabelW.AutoSize = true;
            this.PathLabelW.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabelW.Location = new System.Drawing.Point(12, 4);
            this.PathLabelW.Name = "PathLabelW";
            this.PathLabelW.Size = new System.Drawing.Size(73, 33);
            this.PathLabelW.TabIndex = 5;
            this.PathLabelW.Text = "Path:";
            // 
            // CloseWriteEmailList
            // 
            this.CloseWriteEmailList.Location = new System.Drawing.Point(12, 116);
            this.CloseWriteEmailList.Name = "CloseWriteEmailList";
            this.CloseWriteEmailList.Size = new System.Drawing.Size(119, 41);
            this.CloseWriteEmailList.TabIndex = 6;
            this.CloseWriteEmailList.Text = "Close";
            this.CloseWriteEmailList.UseVisualStyleBackColor = true;
            this.CloseWriteEmailList.Click += new System.EventHandler(this.CloseWriteEmailList_Click);
            // 
            // WriteEmailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.CloseWriteEmailList);
            this.Controls.Add(this.PathLabelW);
            this.Controls.Add(this.SaveAsButtonW);
            this.Controls.Add(this.OpenButtonW);
            this.Controls.Add(this.PathTextBoxW);
            this.Controls.Add(this.TextBoxW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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