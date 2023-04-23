using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace SendGmailMulti
{
    public partial class ReadMail : Form
    {
        string constr;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adt;

        public ReadMail()
        {
            InitializeComponent();
        }

        public class EmailInfo
        {
            public string Id { get; set; }
            public string From { get; set; }
            public DateTimeOffset TimeReceive { get; set; }
            public string Subject { get; set; }
            public string Body { get; set; }
            public string FileAttactment { get; set; }
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

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            /*var listEmail = new List<EmailInfo>();
            var mailClient = new ImapClient();
            var folder = await mailClient.GetFolderAsync("Inbox");
            await folder.OpenAsync(FolderAccess.ReadWrite);

            try
            {
                mailClient.Connect("imap.gmail.com", 993);
                mailClient.Authenticate(UserNameTextBox.Text, PasswordTextBox.Text);
            }
            catch
            {
                if ((UserNameTextBox.Text == null || PasswordTextBox.Text == ""))
                    MessageBox.Show("User name or password is not correct!\nPlease check your connection and account security", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }*/

            var listEmail = new List<EmailInfo>();
            var mailClient = new ImapClient();
            mailClient.Connect("imap.gmail.com", 993);
            mailClient.Authenticate(UserNameTextBox.Text, PasswordTextBox.Text);
            var folder = await mailClient.GetFolderAsync("Inbox");
            await folder.OpenAsync(FolderAccess.ReadWrite);


            IList<UniqueId> uids = folder.Search(SearchQuery.All);
            foreach (UniqueId uid in uids)
            {
                MimeMessage message = folder.GetMessage(uid);
                var emailInfo = new EmailInfo();
                emailInfo.Id = uid.ToString();
                emailInfo.From = message.From.ToString();
                emailInfo.TimeReceive = message.Date;
                emailInfo.Subject = message.Subject;
                emailInfo.Body = message.TextBody;
                var fileAttactment = new List<string>();


                foreach (MimeEntity attachment in message.Attachments)
                {
                    var fileName = attachment.ContentDisposition?.FileName ?? attachment.ContentType.Name;
                    fileAttactment.Add(fileName);

                    using (var stream = File.Create(fileName))
                    {
                        if (attachment is MessagePart)
                        {
                            var rfc822 = (MessagePart)attachment;

                            rfc822.Message.WriteTo(stream);
                        }
                        else
                        {
                            var part = (MimePart)attachment;

                            part.Content.DecodeTo(stream);
                        }
                    }
                }
                emailInfo.FileAttactment = string.Join("; ", fileAttactment);
                listEmail.Add(emailInfo);

            }
            dataGridView1.DataSource = listEmail;
        }

        public string id { get; set; }

        private void DeleteDatabaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("DELETE FROM gmail WHERE ID = {0}", id);
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Delete successful!");
                        LoadKetNoi();
                        IDTextBox.Clear();
                        NameTextBox.Clear();
                        MailTextBox.Clear();
                        GenderTextBox.Clear();
                        PhoneTextBox.Clear();
                    }
                }
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void UpdateDatabaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("UPDATE gmail SET ID = '{0}', Name = '{1}', Mail = '{2}', Gender = '{3}', Phone = '{4}' WHERE ID = {5}", IDTextBox.Text, NameTextBox.Text, MailTextBox.Text, GenderTextBox.Text, PhoneTextBox.Text, id);
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Update successful!");
                        LoadKetNoi();
                        IDTextBox.Clear();
                        NameTextBox.Clear();
                        MailTextBox.Clear();
                        GenderTextBox.Clear();
                        PhoneTextBox.Clear();
                    }
                }
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void AddDatabaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("INSERT INTO gmail VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", IDTextBox.Text, NameTextBox.Text, MailTextBox.Text, GenderTextBox.Text, PhoneTextBox.Text);
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Add successful!");
                        LoadKetNoi();
                        IDTextBox.Clear();
                        NameTextBox.Clear();
                        MailTextBox.Clear();
                        GenderTextBox.Clear();
                        PhoneTextBox.Clear();
                    }
                }
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        public void MoKetNoi()
        {
            con.Open();
        }

        public void DongKetNoi()
        {
            con.Close();
        }

        public void LoadKetNoi()
        {
            constr = "server=" + SeverDatabaseTextBox.Text + ";user=" + UsernameDatabaseTextBox.Text + ";pwd=" + PasswordDatabaseTextBox.Text + ";database=" + DatabaseNameTextBox.Text + ";port=" + PortDatabaseTextBox.Text + ";";
            con = new MySqlConnection(constr);
            MoKetNoi();
            cmd = new MySqlCommand("select * from gmail", con);
            adt = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView2.DataSource = dt;
            DongKetNoi();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoadKetNoi();
            }
            catch
            {
                DongKetNoi();
                MessageBox.Show("Infomation uncorrect or error from Server!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void ReadMail_Load(object sender, EventArgs e)
        {
            TxtSaveResListPanel.Hide();
            DatabaseAccountPanel.Hide();
            DatabaseEditPanel.Hide();
            dataGridView2.Hide();
            this.Size = new Size(1020, 380);
            this.CenterToScreen();
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }

        private void responseTxtListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtSaveResListPanel.Show();
            DatabaseAccountPanel.Hide();
            DatabaseEditPanel.Hide();
            dataGridView2.Hide();
            this.Size = new Size(1020, 380);
            this.CenterToScreen();
        }

        private void responseDatabaseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtSaveResListPanel.Hide();
            DatabaseAccountPanel.Show();
            DatabaseEditPanel.Show();
            dataGridView2.Show();
            this.Size = new Size(1020, 580);
            this.CenterToScreen();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                IDTextBox.Text = row.Cells[0].Value.ToString();
                NameTextBox.Text = row.Cells[1].Value.ToString();
                MailTextBox.Text = row.Cells[2].Value.ToString();
                GenderTextBox.Text = row.Cells[3].Value.ToString();
                PhoneTextBox.Text = row.Cells[4].Value.ToString();
            }
        }

        SaveFileDialog save;

        private void SavetTxtListResButton_Click(object sender, EventArgs e)
        {
            save = new SaveFileDialog();
            save.Filter = "|*.txt";
            save.RestoreDirectory = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(save.FileName);
                write.WriteLine(TxtResListTextBox.Text);
                write.Close();
                MessageBox.Show("Save success!");
            }
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HowToUse htu = new HowToUse();
            htu.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/hoan.nguyenduy.7967");
        }
    }
}
