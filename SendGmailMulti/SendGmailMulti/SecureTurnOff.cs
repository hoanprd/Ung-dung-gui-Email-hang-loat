using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendGmailMulti
{
    public partial class SecureTurnOff : Form
    {
        public SecureTurnOff()
        {
            InitializeComponent();
        }

        private void SecureTurnOff_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            this.CenterToScreen();
        }

        private void TurnOffSecure1Button_Click(object sender, EventArgs e)
        {
            Process.Start("https://myaccount.google.com/lesssecureapps");
        }

        private void TurnOffSecure2Button_Click(object sender, EventArgs e)
        {
            Process.Start("https://myaccount.google.com/apppasswords?utm_source=google-account&utm_medium=myaccountsecurity&utm_campaign=tsv-settings&rapt=AEjHL4O6PusxrQUtum4D0AeNWP43wXffz3qU1TonRLoH0_YpDhN1udoFlqM7pjlk1H9GpiB4RCBzgJRKrBPTVD_m0IEXI2sz2A");
        }
    }
}
