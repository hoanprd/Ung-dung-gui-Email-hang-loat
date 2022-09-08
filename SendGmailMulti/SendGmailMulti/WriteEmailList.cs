using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SendGmailMulti
{
    public partial class WriteEmailList : Form
    {
        public WriteEmailList()
        {
            InitializeComponent();
        }

        OpenFileDialog open;
        SaveFileDialog save;

        private void OpenButtonW_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                PathTextBoxW.Text = open.FileName;
                StreamReader read = new StreamReader(open.FileName);
                TextBoxW.Text = read.ReadToEnd();
                read.Close();
            }
        }

        private void SaveAsButtonW_Click(object sender, EventArgs e)
        {
            save = new SaveFileDialog();
            save.Filter = "|*.txt";
            save.RestoreDirectory = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(save.FileName);
                write.WriteLine(TextBoxW.Text);
                write.Close();
                MessageBox.Show("Save success!");
            }
        }

        private void CloseWriteEmailList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WriteEmailList_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }
    }
}
