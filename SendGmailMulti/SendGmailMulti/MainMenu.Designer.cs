﻿
namespace SendGmailMulti
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReadMainButton = new System.Windows.Forms.Button();
            this.AppName = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartMainButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.AppName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 426);
            this.panel1.TabIndex = 1;
            // 
            // ReadMainButton
            // 
            this.ReadMainButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadMainButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReadMainButton.Image = global::SendGmailMulti.Properties.Resources.pixlr_bg_result1;
            this.ReadMainButton.Location = new System.Drawing.Point(68, 151);
            this.ReadMainButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReadMainButton.Name = "ReadMainButton";
            this.ReadMainButton.Size = new System.Drawing.Size(163, 47);
            this.ReadMainButton.TabIndex = 3;
            this.ReadMainButton.Text = "Read mail";
            this.ReadMainButton.UseVisualStyleBackColor = true;
            this.ReadMainButton.Click += new System.EventHandler(this.ReadMainButton_Click);
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AppName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.ForeColor = System.Drawing.SystemColors.Control;
            this.AppName.Location = new System.Drawing.Point(56, 11);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(178, 66);
            this.AppName.TabIndex = 2;
            this.AppName.Text = "Mail Spammer\r\n   Application";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Image = global::SendGmailMulti.Properties.Resources.pixlr_bg_result1;
            this.ExitButton.Location = new System.Drawing.Point(67, 231);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(163, 47);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartMainButton
            // 
            this.StartMainButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartMainButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StartMainButton.Image = global::SendGmailMulti.Properties.Resources.pixlr_bg_result1;
            this.StartMainButton.Location = new System.Drawing.Point(67, 69);
            this.StartMainButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartMainButton.Name = "StartMainButton";
            this.StartMainButton.Size = new System.Drawing.Size(163, 47);
            this.StartMainButton.TabIndex = 0;
            this.StartMainButton.Text = "Send mail";
            this.StartMainButton.UseVisualStyleBackColor = true;
            this.StartMainButton.Click += new System.EventHandler(this.StartMainButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SendGmailMulti.Properties.Resources.toi_pham_spammer;
            this.pictureBox1.Location = new System.Drawing.Point(307, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(659, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.ReadMainButton);
            this.panel2.Controls.Add(this.StartMainButton);
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Location = new System.Drawing.Point(12, 106);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 333);
            this.panel2.TabIndex = 4;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartMainButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ReadMainButton;
        private System.Windows.Forms.Panel panel2;
    }
}