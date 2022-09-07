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
    public partial class MainMenu : Form
    {
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void StartMainButton_Click(object sender, EventArgs e)
        {
            //MainMenu mm = new MainMenu();
            SendGmailMulti sgm = new SendGmailMulti();
            //mm.Hide();
            sgm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
