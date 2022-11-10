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
    public partial class LoopSetting : Form
    {
        public LoopSetting()
        {
            InitializeComponent();
            LoopTimeNum.Value = new decimal(SendGmailMulti.LoopTime);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendGmailMulti.LoopTime = Convert.ToInt32(LoopTimeNum.Value);
            this.Hide();
        }

        private void LoopSetting_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            ControlBox = false;
        }
    }
}
