
namespace SendGmailMulti
{
    partial class SendGmailMulti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendGmailMulti));
            this.AttachTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReceiverTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AttachButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.MailListButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.PathPanel = new System.Windows.Forms.Panel();
            this.MakeEmailListButton = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.PictureBoxMain = new System.Windows.Forms.PictureBox();
            this.BackToMenuButton = new System.Windows.Forms.Button();
            this.AccountPanel.SuspendLayout();
            this.PathPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // AttachTextBox
            // 
            this.AttachTextBox.Location = new System.Drawing.Point(116, 19);
            this.AttachTextBox.Name = "AttachTextBox";
            this.AttachTextBox.Size = new System.Drawing.Size(188, 22);
            this.AttachTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Receiver:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReceiverTextBox
            // 
            this.ReceiverTextBox.Location = new System.Drawing.Point(116, 70);
            this.ReceiverTextBox.Name = "ReceiverTextBox";
            this.ReceiverTextBox.ReadOnly = true;
            this.ReceiverTextBox.Size = new System.Drawing.Size(369, 22);
            this.ReceiverTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject:";
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(116, 14);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(369, 22);
            this.SubjectTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "User name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(108, 12);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(369, 22);
            this.UserNameTextBox.TabIndex = 7;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(108, 74);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(369, 22);
            this.PasswordTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Message:";
            // 
            // AttachButton
            // 
            this.AttachButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttachButton.Location = new System.Drawing.Point(509, 12);
            this.AttachButton.Name = "AttachButton";
            this.AttachButton.Size = new System.Drawing.Size(99, 34);
            this.AttachButton.TabIndex = 10;
            this.AttachButton.Text = "Attach";
            this.AttachButton.UseVisualStyleBackColor = true;
            this.AttachButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(453, 485);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(100, 30);
            this.SendButton.TabIndex = 11;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(15, 80);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(509, 225);
            this.MessageTextBox.TabIndex = 12;
            // 
            // MailListButton
            // 
            this.MailListButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailListButton.Location = new System.Drawing.Point(509, 63);
            this.MailListButton.Name = "MailListButton";
            this.MailListButton.Size = new System.Drawing.Size(99, 34);
            this.MailListButton.TabIndex = 13;
            this.MailListButton.Text = "Mail list";
            this.MailListButton.UseVisualStyleBackColor = true;
            this.MailListButton.Click += new System.EventHandler(this.MailListButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "File path:";
            // 
            // AccountPanel
            // 
            this.AccountPanel.Controls.Add(this.label3);
            this.AccountPanel.Controls.Add(this.label4);
            this.AccountPanel.Controls.Add(this.UserNameTextBox);
            this.AccountPanel.Controls.Add(this.PasswordTextBox);
            this.AccountPanel.Location = new System.Drawing.Point(12, 21);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(541, 110);
            this.AccountPanel.TabIndex = 15;
            this.AccountPanel.Tag = "";
            // 
            // PathPanel
            // 
            this.PathPanel.Controls.Add(this.MakeEmailListButton);
            this.PathPanel.Controls.Add(this.AttachTextBox);
            this.PathPanel.Controls.Add(this.label1);
            this.PathPanel.Controls.Add(this.label6);
            this.PathPanel.Controls.Add(this.ReceiverTextBox);
            this.PathPanel.Controls.Add(this.MailListButton);
            this.PathPanel.Controls.Add(this.AttachButton);
            this.PathPanel.Location = new System.Drawing.Point(602, 21);
            this.PathPanel.Name = "PathPanel";
            this.PathPanel.Size = new System.Drawing.Size(616, 176);
            this.PathPanel.TabIndex = 16;
            // 
            // MakeEmailListButton
            // 
            this.MakeEmailListButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeEmailListButton.Location = new System.Drawing.Point(200, 111);
            this.MakeEmailListButton.Name = "MakeEmailListButton";
            this.MakeEmailListButton.Size = new System.Drawing.Size(219, 46);
            this.MakeEmailListButton.TabIndex = 15;
            this.MakeEmailListButton.Text = "Make new list";
            this.MakeEmailListButton.UseVisualStyleBackColor = true;
            this.MakeEmailListButton.Click += new System.EventHandler(this.MakeEmailListButton_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.SubjectTextBox);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.label5);
            this.InfoPanel.Controls.Add(this.MessageTextBox);
            this.InfoPanel.Location = new System.Drawing.Point(12, 161);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(541, 318);
            this.InfoPanel.TabIndex = 17;
            // 
            // PictureBoxMain
            // 
            this.PictureBoxMain.Image = global::SendGmailMulti.Properties.Resources.toi_pham_spammer;
            this.PictureBoxMain.Location = new System.Drawing.Point(602, 216);
            this.PictureBoxMain.Name = "PictureBoxMain";
            this.PictureBoxMain.Size = new System.Drawing.Size(616, 299);
            this.PictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxMain.TabIndex = 18;
            this.PictureBoxMain.TabStop = false;
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMenuButton.Location = new System.Drawing.Point(12, 485);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(100, 30);
            this.BackToMenuButton.TabIndex = 19;
            this.BackToMenuButton.Text = "BACK";
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // SendGmailMulti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 527);
            this.Controls.Add(this.BackToMenuButton);
            this.Controls.Add(this.PictureBoxMain);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.PathPanel);
            this.Controls.Add(this.AccountPanel);
            this.Controls.Add(this.SendButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendGmailMulti";
            this.Text = "Send gmail multi";
            this.Load += new System.EventHandler(this.SendGmailMulti_Load);
            this.AccountPanel.ResumeLayout(false);
            this.AccountPanel.PerformLayout();
            this.PathPanel.ResumeLayout(false);
            this.PathPanel.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox AttachTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReceiverTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AttachButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button MailListButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel AccountPanel;
        private System.Windows.Forms.Panel PathPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button MakeEmailListButton;
        private System.Windows.Forms.PictureBox PictureBoxMain;
        private System.Windows.Forms.Button BackToMenuButton;
    }
}

