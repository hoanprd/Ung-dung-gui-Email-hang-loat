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
using System.Diagnostics;

namespace SendGmailMulti
{
    public partial class SendGmailMulti : Form
    {
        Attachment attach = null;
        bool CheckAccSecur = false;
        string MailList, CCEmail, BCCEmail, MailTemp, CCTemp, BCCTemp;

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
                int tao1 = 0;
                int tao2 = 0;
                int tao3 = 0;

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
                    MailTemp = null;
                    CCTemp = null;
                    BCCTemp = null;

                    if (ReceiverTextBox.Text == null || ReceiverTextBox.Text == "")
                    {
                        //do nothing
                    }
                    else
                    {
                        StreamReader sr = new StreamReader(ReceiverTextBox.Text);
                        while ((MailList = sr.ReadLine()) != null)
                        {
                            if (tao1 != 0)
                            {
                                MailTemp += ", " + MailList;
                            }
                            else
                            {
                                MailTemp += MailList;
                                tao1 = 1;
                            }
                        }

                        sr.Close();
                    }

                    if (CCTextBox.Text == null || CCTextBox.Text == "")
                    {
                        //do nothing
                    }
                    else
                    {
                        StreamReader srCC = new StreamReader(CCTextBox.Text);
                        while ((CCEmail = srCC.ReadLine()) != null)
                        {
                            if (tao2 != 0)
                            {
                                CCTemp += ", " + CCEmail;
                            }
                            else
                            {
                                CCTemp += CCEmail;
                                tao2 = 1;
                            }
                        }

                        srCC.Close();
                    }

                    if (BCCTextBox.Text == null || BCCTextBox.Text == "")
                    {
                        //do nothing
                    }
                    else
                    {
                        StreamReader srBCC = new StreamReader(BCCTextBox.Text);
                        while ((BCCEmail = srBCC.ReadLine()) != null)
                        {
                            if (tao3 != 0)
                            {
                                BCCTemp += ", " + BCCEmail;
                            }
                            else
                            {
                                BCCTemp += BCCEmail;
                                tao3 = 1;
                            }
                        }

                        srBCC.Close();
                    }

                    GuiMail();

                    MessageBox.Show("Done!");
                }
                catch
                {
                    if ((ReceiverTextBox.Text == null || ReceiverTextBox.Text == "") && (CCTextBox.Text == null || CCTextBox.Text == "") && (BCCTextBox.Text == null || BCCTextBox.Text == ""))
                        MessageBox.Show("Error! You haven't choose any receiver!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else if ((ReceiverTextBox.Text == null || ReceiverTextBox.Text == "") && CheckAccSecur == false)
                        MessageBox.Show("User name or password is not correct!\nPlease check your connection and account security", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    else
                        MessageBox.Show("Send unsuccessful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            );
            thread.Start();
        }

        //Hàm gửi mail
        void GuiMail(Attachment file = null)
        {
            MailMessage mess = new MailMessage();

            mess.From = new MailAddress(UserNameTextBox.Text);
            mess.Subject = SubjectTextBox.Text;
            mess.Body = MessageTextBox.Text;

            if (ReceiverTextBox.Text == null || ReceiverTextBox.Text == "")
            {
                //do nothing
            }
            else
            {
                string[] Multi = MailTemp.Split(',');
                foreach (string Multiemailid in Multi)
                {
                    mess.To.Add(new MailAddress(Multiemailid));
                }
            }

            if (CCTextBox.Text == null || CCTextBox.Text == "")
            {
                //do nothing
            }
            else
            {
                MailAddress cc = new MailAddress(CCTemp);
                mess.CC.Add(cc);
            }

            if (BCCTextBox.Text == null || BCCTextBox.Text == "")
            {
                //do nothing
            }
            else
            {
                MailAddress bcc = new MailAddress(BCCTemp);
                mess.Bcc.Add(bcc);
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

        private void CCTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CCTextBox.Text == null || CCTextBox.Text == "")
            {
                ImportantBox1.Show();
            }
            else
            {
                ImportantBox1.Hide();
            }
        }

        private void BCCTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BCCTextBox.Text == null || BCCTextBox.Text == "")
            {
                ImportantBox1.Show();
            }
            else
            {
                ImportantBox1.Hide();
            }
        }

        private void TurnOffSecurityButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://myaccount.google.com/lesssecureapps");
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
