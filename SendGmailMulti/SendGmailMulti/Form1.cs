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
        public SendGmailMulti()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                AttachTextBox.Text = dialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                attach = null;
                try
                {
                    FileInfo file = new FileInfo(AttachTextBox.Text);
                    attach = new Attachment(AttachTextBox.Text);
                }
                catch
                {

                }

                StreamReader sr = new StreamReader(ReceiverTextBox.Text);
                string email;

                while ((email = sr.ReadLine()) != null)
                {
                    GuiMail(UserNameTextBox.Text, email, SubjectTextBox.Text, MessageTextBox.Text, attach);
                }
                sr.Close();
            }
            );
            thread.Start();
        }

        //Hàm gửi mail
        void GuiMail(string from, string to, string subject, string message, Attachment file = null)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);

            if (attach != null)
            {
                mess.Attachments.Add(attach);
            }

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            client.EnableSsl = true;

            client.Credentials = new NetworkCredential(UserNameTextBox.Text, PasswordTextBox.Text);

            client.Send(mess);
        }

        private void MailListButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ReceiverTextBox.Text = dialog.FileName;
            }
        }
    }
}
