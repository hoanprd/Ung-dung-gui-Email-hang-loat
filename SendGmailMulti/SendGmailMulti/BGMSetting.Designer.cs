
namespace SendGmailMulti
{
    partial class BGMSetting
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
            this.PlayMusicButton = new System.Windows.Forms.Button();
            this.StopMusicButton = new System.Windows.Forms.Button();
            this.SoundTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.SoundTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayMusicButton
            // 
            this.PlayMusicButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayMusicButton.Location = new System.Drawing.Point(123, 12);
            this.PlayMusicButton.Name = "PlayMusicButton";
            this.PlayMusicButton.Size = new System.Drawing.Size(144, 44);
            this.PlayMusicButton.TabIndex = 1;
            this.PlayMusicButton.Text = "Play music";
            this.PlayMusicButton.UseVisualStyleBackColor = true;
            this.PlayMusicButton.Click += new System.EventHandler(this.PlayMusicButton_Click);
            // 
            // StopMusicButton
            // 
            this.StopMusicButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopMusicButton.Location = new System.Drawing.Point(123, 62);
            this.StopMusicButton.Name = "StopMusicButton";
            this.StopMusicButton.Size = new System.Drawing.Size(144, 44);
            this.StopMusicButton.TabIndex = 2;
            this.StopMusicButton.Text = "Stop music";
            this.StopMusicButton.UseVisualStyleBackColor = true;
            this.StopMusicButton.Click += new System.EventHandler(this.StopMusicButton_Click);
            // 
            // SoundTrackBar
            // 
            this.SoundTrackBar.Location = new System.Drawing.Point(123, 115);
            this.SoundTrackBar.Maximum = 100;
            this.SoundTrackBar.Name = "SoundTrackBar";
            this.SoundTrackBar.Size = new System.Drawing.Size(144, 56);
            this.SoundTrackBar.TabIndex = 3;
            this.SoundTrackBar.Value = 20;
            this.SoundTrackBar.Scroll += new System.EventHandler(this.SoundTrackBar_Scroll);
            // 
            // BGMSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 183);
            this.Controls.Add(this.SoundTrackBar);
            this.Controls.Add(this.StopMusicButton);
            this.Controls.Add(this.PlayMusicButton);
            this.Name = "BGMSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BGMSetting";
            ((System.ComponentModel.ISupportInitialize)(this.SoundTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayMusicButton;
        private System.Windows.Forms.Button StopMusicButton;
        private System.Windows.Forms.TrackBar SoundTrackBar;
    }
}