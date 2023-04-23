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
    public partial class HowToUse : Form
    {
        public HowToUse()
        {
            InitializeComponent();

            HowToUseTextBox.Text = "Login your gmail account and turn off security\n *Send by using .txt\n  - Choose receiver from your computer browser or make a new list.\n  - You can make a list CC or BCC if you want to.\n *Send by using database\n  - Click sending mode to database.\n - Connect to database and you can add, delete, update it. - Double click each field to add to CC or BCC list.\n For read mail you have to login then you can response by creating a txt file or edit database";
        }
    }
}
