﻿namespace SendGmailMulti
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
            this.TextBoxW = new System.Windows.Forms.TextBox();
            this.PathTextBoxW = new System.Windows.Forms.TextBox();
            this.OpenButtonW = new System.Windows.Forms.Button();
            this.SaveButtonW = new System.Windows.Forms.Button();
            this.SaveAsButtonW = new System.Windows.Forms.Button();
            this.PathLabelW = new System.Windows.Forms.Label();
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
            this.OpenButtonW.Location = new System.Drawing.Point(12, 116);
            this.OpenButtonW.Name = "OpenButtonW";
            this.OpenButtonW.Size = new System.Drawing.Size(119, 41);
            this.OpenButtonW.TabIndex = 2;
            this.OpenButtonW.Text = "Open";
            this.OpenButtonW.UseVisualStyleBackColor = true;
            this.OpenButtonW.Click += new System.EventHandler(this.OpenButtonW_Click);
            // 
            // SaveButtonW
            // 
            this.SaveButtonW.Location = new System.Drawing.Point(137, 116);
            this.SaveButtonW.Name = "SaveButtonW";
            this.SaveButtonW.Size = new System.Drawing.Size(119, 41);
            this.SaveButtonW.TabIndex = 3;
            this.SaveButtonW.Text = "Save";
            this.SaveButtonW.UseVisualStyleBackColor = true;
            this.SaveButtonW.Click += new System.EventHandler(this.SaveButtonW_Click);
            // 
            // SaveAsButtonW
            // 
            this.SaveAsButtonW.Location = new System.Drawing.Point(262, 116);
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
            // WriteEmailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.PathLabelW);
            this.Controls.Add(this.SaveAsButtonW);
            this.Controls.Add(this.SaveButtonW);
            this.Controls.Add(this.OpenButtonW);
            this.Controls.Add(this.PathTextBoxW);
            this.Controls.Add(this.TextBoxW);
            this.Name = "WriteEmailList";
            this.Text = "WriteEmailList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxW;
        private System.Windows.Forms.TextBox PathTextBoxW;
        private System.Windows.Forms.Button OpenButtonW;
        private System.Windows.Forms.Button SaveButtonW;
        private System.Windows.Forms.Button SaveAsButtonW;
        private System.Windows.Forms.Label PathLabelW;
    }
}