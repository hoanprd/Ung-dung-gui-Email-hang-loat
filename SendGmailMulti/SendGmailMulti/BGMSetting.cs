using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendGmailMulti
{
    public partial class BGMSetting : Form
    {
        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
        SendGmailMulti sgm = new SendGmailMulti();
        public static int SoundValue = 20;
        public bool Play;

        public BGMSetting()
        {
            InitializeComponent();

            SoundTrackBar.Value = SoundValue;
        }

        private void PlayMusicButton_Click(object sender, EventArgs e)
        {
            Play = true;
            sgm.PlayMusic(Play);
        }

        private void StopMusicButton_Click(object sender, EventArgs e)
        {
            Play = false;
            sgm.PlayMusic(Play);
        }

        private void SoundTrackBar_Scroll(object sender, EventArgs e)
        {
            SoundValue = SoundTrackBar.Value;
            defaultPlaybackDevice.Volume = BGMSetting.SoundValue;
        }
    }
}
