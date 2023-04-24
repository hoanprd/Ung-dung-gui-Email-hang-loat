
namespace SendGmailMulti
{
    partial class SecureTurnOff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecureTurnOff));
            this.TurnOffSecure1Button = new System.Windows.Forms.Button();
            this.TurnOffSecure2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TurnOffSecure1Button
            // 
            this.TurnOffSecure1Button.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnOffSecure1Button.Location = new System.Drawing.Point(12, 12);
            this.TurnOffSecure1Button.Name = "TurnOffSecure1Button";
            this.TurnOffSecure1Button.Size = new System.Drawing.Size(458, 77);
            this.TurnOffSecure1Button.TabIndex = 0;
            this.TurnOffSecure1Button.Text = "Allow third-party apps";
            this.TurnOffSecure1Button.UseVisualStyleBackColor = true;
            this.TurnOffSecure1Button.Click += new System.EventHandler(this.TurnOffSecure1Button_Click);
            // 
            // TurnOffSecure2Button
            // 
            this.TurnOffSecure2Button.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnOffSecure2Button.Location = new System.Drawing.Point(12, 114);
            this.TurnOffSecure2Button.Name = "TurnOffSecure2Button";
            this.TurnOffSecure2Button.Size = new System.Drawing.Size(458, 77);
            this.TurnOffSecure2Button.TabIndex = 1;
            this.TurnOffSecure2Button.Text = "Generate app password";
            this.TurnOffSecure2Button.UseVisualStyleBackColor = true;
            this.TurnOffSecure2Button.Click += new System.EventHandler(this.TurnOffSecure2Button_Click);
            // 
            // SecureTurnOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 203);
            this.Controls.Add(this.TurnOffSecure2Button);
            this.Controls.Add(this.TurnOffSecure1Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SecureTurnOff";
            this.Text = "SecureTurnOff";
            this.Load += new System.EventHandler(this.SecureTurnOff_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TurnOffSecure1Button;
        private System.Windows.Forms.Button TurnOffSecure2Button;
    }
}