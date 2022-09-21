using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendGmailMulti
{
    public partial class SendGmailMulti : Form
    {
        Attachment attach = null;
        //bool CheckAccCorrect = false;
        bool CheckAccSecur = false, stopccbcc = false;
        string CCEmail, BCCEmail, CCTemp, BCCTemp;

        public SendGmailMulti()
        {
            InitializeComponent();
        }

        List<string> _lstFilePath;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _lstFilePath = new List<string>();
                foreach (var item in dialog.FileNames)
                {
                    _lstFilePath.Add(item);
                    if (!File.Exists(item))
                    {
                        MessageBox.Show("File does not exits!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            int fileNumber = dialog.FileNames.Count();
            AttachTextBox.Text = "Number of files " + fileNumber.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckAccSecur = false;

            Thread thread = new Thread(() =>
            {
                attach = null;
                stopccbcc = false;
                //int dem = 0;
                int tao = 0;

                try
                {
                    FileInfo file = new FileInfo(AttachTextBox.Text);
                    attach = new Attachment(AttachTextBox.Text);
                }
                catch
                {

                }

                try
                {
                    StreamReader sr = new StreamReader(ReceiverTextBox.Text);
                    StreamReader srCC = new StreamReader(CCTextBox.Text);
                    StreamReader srBCC = new StreamReader(BCCTextBox.Text);
                    CCTemp = null;
                    BCCTemp = null;

                    string email;
                    
                    while ((CCEmail = srCC.ReadLine()) != null)
                    {
                        if (tao != 0)
                        {
                            CCTemp += ", " + CCEmail;
                        }
                        else
                        {
                            CCTemp += CCEmail;
                            tao = 1;
                        }
                    }

                    while ((BCCEmail = srBCC.ReadLine()) != null)
                    {
                        if (tao != 0)
                        {
                            BCCTemp += ", " + BCCEmail;
                        }
                        else
                        {
                            BCCTemp += BCCEmail;
                            tao = 1;
                        }
                    }

                    while ((email = sr.ReadLine()) != null)
                    {
                        GuiMail(UserNameTextBox.Text, email, SubjectTextBox.Text, MessageTextBox.Text, attach);
                        //dem++;
                    }

                    sr.Close();

                    //MessageBox.Show("Done! You have send " + dem.ToString() + " mail");
                    MessageBox.Show("Done!");
                }
                catch
                {
                    if ((ReceiverTextBox.Text == null || ReceiverTextBox.Text == "") && (CCTextBox.Text == null || CCTextBox.Text == ""))
                        MessageBox.Show("Error! You haven't choose any receiver!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else if ((ReceiverTextBox.Text == null || ReceiverTextBox.Text == "") && CheckAccSecur == false)
                        MessageBox.Show("User name or password is not correct!\nPlease check your connection and account security", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            );
            thread.Start();
        }

        //Hàm gửi mail
        void GuiMail(string from, string to, string subject, string message, Attachment file = null)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);

            if (stopccbcc == false)
            {
                stopccbcc = true;
                MailAddress cc = new MailAddress(CCTemp);
                MailAddress bcc = new MailAddress(BCCTemp);

                mess.CC.Add(cc);
                mess.Bcc.Add(bcc);
            }

            if (attach != null)
            {
                mess.Attachments.Add(attach);
            }

            if (_lstFilePath != null)
            {
                string[] files = _lstFilePath.ToArray();
                Attachment attachment;
                foreach (var item in files)
                {
                    attachment = new Attachment(item);
                    mess.Attachments.Add(attachment);
                }
            }

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            client.EnableSsl = true;

            client.Credentials = new NetworkCredential(UserNameTextBox.Text, PasswordTextBox.Text);

            client.Send(mess);

            CheckAccSecur = true;
        }

        private void MailListButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ReceiverTextBox.Text = dialog.FileName;
                //CheckAccCorrect = true;
            }
        }

        private void MakeEmailListButton_Click(object sender, EventArgs e)
        {
            WriteEmailList wel = new WriteEmailList();
            wel.Show();
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }

        private void SendGmailMulti_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            ControlBox = false;
        }

        private void ReceiverTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ReceiverTextBox.Text == null || ReceiverTextBox.Text == "")
            {
                ImportantBox1.Show();
            }
            else
            {
                ImportantBox1.Hide();
            }
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == null || UserNameTextBox.Text == "")
            {
                ImportantBox2.Show();
            }
            else
            {
                ImportantBox2.Hide();
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == null || PasswordTextBox.Text == "")
            {
                ImportantBox3.Show();
            }
            else
            {
                ImportantBox3.Hide();
            }
        }

        private void MailListCCButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CCTextBox.Text = dialog.FileName;
                //CheckAccCorrect = true;
            }
        }

        private void MailListBCCButon_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BCCTextBox.Text = dialog.FileName;
                //CheckAccCorrect = true;
            }
        }
    }
}
