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
            Process.Start("https://myaccount.google.com/signinoptions/two-step-verification?pli=1&rapt=AEjHL4MbU9oxp4vnELv8ehHJmLHs3AMLBnXpjERJqhNaNismSG4OyezyRVwart7hhrh9AocqNgpBNXD7op67RVaJCJn_fiLuFw");
            Process.Start("https://youtu.be/oC6v2CoLl9A");
        }
    }
}
