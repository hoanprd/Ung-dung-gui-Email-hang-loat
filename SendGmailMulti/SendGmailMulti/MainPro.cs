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
using MySql.Data.MySqlClient;
using System.Media;
using System.Windows.Media;
using AudioSwitcher.AudioApi.CoreAudio;
using System.IO.Ports;

namespace SendGmailMulti
{
    public partial class SendGmailMulti : Form
    {
        Attachment attach = null;
        bool CheckAccSecur = false;
        string MailList, CCEmail, BCCEmail, MailTemp, CCTemp, BCCTemp;
        int dtIndex = 0;
        public static int LoopTime = 1;
        private SoundPlayer sp;
        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;

        string constr;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adt;

        static int tao4 = 0;
        static int tao5 = 0;
        static int tao6 = 0;
        bool conneted = false;

        public SendGmailMulti()
        {
            InitializeComponent();

            sp = new SoundPlayer("Rong thieng.wav");
            defaultPlaybackDevice.Volume = BGMSetting.SoundValue;
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


                string checkbox = SendFromDatabaseCheckBox.CheckState == CheckState.Checked ? "on" : SendFromDatabaseCheckBox.CheckState == CheckState.Unchecked ?
                "off" : "non";

                if (checkbox == "on")
                {
                    try
                    {
                        for (int i = 1; i <= LoopTime; i++)
                            GuiMailDatabase();

                        MessageBox.Show("Done!\nNumber of loop: " + LoopTime.ToString(), "Result");
                    }
                    catch
                    {
                        if ((ReceiverTextBox.Text == null || ReceiverTextBox.Text == "") && CheckAccSecur == false)
                            MessageBox.Show("User name or password is not correct!\nPlease check your connection and account security", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        else
                            MessageBox.Show("Send unsuccessful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
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

                        for (int i = 1; i <= LoopTime; i++)
                            GuiMail();

                        MessageBox.Show("Done!\nNumber of loop: " + LoopTime.ToString(), "Result");
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
                    mess.IsBodyHtml = true;
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
                mess.IsBodyHtml = true;
                mess.CC.Add(cc);
            }

            if (BCCTextBox.Text == null || BCCTextBox.Text == "")
            {
                //do nothing
            }
            else
            {
                MailAddress bcc = new MailAddress(BCCTemp);
                mess.IsBodyHtml = true;
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

        //Hàm gửi Mail bằng Database
        void GuiMailDatabase(Attachment file = null)
        {
            MailMessage mess = new MailMessage();

            mess.From = new MailAddress(UserNameTextBox.Text);
            mess.Subject = SubjectTextBox.Text;
            mess.Body = MessageTextBox.Text;

            if (tao4 != 0)
            {
                string[] Multi = MailTemp.Split(',');
                foreach (string Multiemailid in Multi)
                {
                    mess.IsBodyHtml = true;
                    mess.To.Add(new MailAddress(Multiemailid));
                }
            }

            if (tao5 != 0)
            {
                MailAddress cc = new MailAddress(CCTemp);
                mess.IsBodyHtml = true;
                mess.CC.Add(cc);
            }

            if (tao6 != 0)
            {
                MailAddress bcc = new MailAddress(BCCTemp);
                mess.IsBodyHtml = true;
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
            //this.Size = new Size(1300, 510);
            DatabaseEditPanel.Hide();
            DatabaseAccountPanel.Hide();
            this.Size = new Size(820, 510);
            this.CenterToScreen();
        }

        private void CCTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((ReceiverTextBox.Text == null || ReceiverTextBox.Text == "") && (CCTextBox.Text == null || CCTextBox.Text == "") && (BCCTextBox.Text == null || BCCTextBox.Text == ""))
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
            if ((ReceiverTextBox.Text == null || ReceiverTextBox.Text == "") && (CCTextBox.Text == null || CCTextBox.Text == "") && (BCCTextBox.Text == null || BCCTextBox.Text == ""))
            {
                ImportantBox1.Show();
            }
            else
            {
                ImportantBox1.Hide();
            }
        }

        private void ReceiverTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((ReceiverTextBox.Text == null || ReceiverTextBox.Text == "") && (CCTextBox.Text == null || CCTextBox.Text == "") && (BCCTextBox.Text == null || BCCTextBox.Text == ""))
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
        public string id { get; set; }

        private void DatabaseGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DatabaseGridView.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                IDTextBox.Text = row.Cells[0].Value.ToString();
                NameTextBox.Text = row.Cells[1].Value.ToString();
                MailTextBox.Text = row.Cells[2].Value.ToString();
                GenderTextBox.Text = row.Cells[3].Value.ToString();
                PhoneTextBox.Text = row.Cells[4].Value.ToString();
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

        private void AddToCC_Click(object sender, EventArgs e)
        {
            if (conneted == true)
            {
                CCEmail = MailTextBox.Text;
                if (tao5 != 0)
                {
                    CCTemp += ", " + CCEmail;
                }
                else
                {
                    CCTemp += CCEmail;
                    tao5 = 1;
                }
                CCDatabaseListTextBox.Text = CCTemp;

                MessageBox.Show("Add to CC list successful!");
            }
            else
                MessageBox.Show("Database unconnect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void AddToBCC_Click(object sender, EventArgs e)
        {
            if (conneted == true)
            {
                BCCEmail = MailTextBox.Text;
                if (tao6 != 0)
                {
                    BCCTemp += ", " + BCCEmail;
                }
                else
                {
                    BCCTemp += BCCEmail;
                    tao6 = 1;
                }
                BCCDatabaseListTextBox.Text = BCCTemp;

                MessageBox.Show("Add to BCC list successful!");
            }
            else
                MessageBox.Show("Database unconnect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void DatabaseGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DatabaseGridView.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
            }
        }

        private void SendFromDatabaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string checkbox = SendFromDatabaseCheckBox.CheckState == CheckState.Checked ? "on" : SendFromDatabaseCheckBox.CheckState == CheckState.Unchecked ?
                "off" : "non";
            if (checkbox == "on")
            {
                DatabaseEditPanel.Show();
                DatabaseAccountPanel.Show();
                this.Size = new Size(1300, 510);
                this.CenterToScreen();
            }
            else
            {
                DatabaseEditPanel.Hide();
                DatabaseAccountPanel.Hide();
                this.Size = new Size(820, 510);
                this.CenterToScreen();
            }
        }

        private void loopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoopSetting ls = new LoopSetting();
            ls.Show();
        }

        private void ReceiverDatabaseUpdateButton_Click(object sender, EventArgs e)
        {
            if (conneted == true)
            {
                MailTemp = ReceiverDatabaseListTextBox.Text;
                CCTemp = CCDatabaseListTextBox.Text;
                BCCTemp = BCCDatabaseListTextBox.Text;

                MessageBox.Show("Receiver list update successful!");
            }
            else
                MessageBox.Show("Database unconnect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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

        private void bGMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BGMSetting bgms = new BGMSetting();
            bgms.Show();
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

        private void turnOffSecurityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://myaccount.google.com/lesssecureapps");
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

        //Database
        public void MoKetNoi()
        {
            con.Open();
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
            DatabaseGridView.DataSource = dt;
            DongKetNoi();
            MailTemp = null;
            CCTemp = null;
            BCCTemp = null;
            tao4 = 0;
            tao5 = 0;
            tao6 = 0;
            conneted = true;
            MailTemp = null;
            ReceiverDatabaseListTextBox.Clear();
            CCDatabaseListTextBox.Clear();
            BCCDatabaseListTextBox.Clear();
            foreach (DataGridViewRow row in DatabaseGridView.Rows)
            {
                if (dtIndex != 0)
                    MailTemp += ", " + row.Cells[2].Value;
                else if (dtIndex == 0)
                {
                    MailTemp += row.Cells[2].Value;
                    dtIndex = 1;
                    tao4 = 1;
                }
            }
            dtIndex = 0;
            MailTemp = MailTemp.Remove(MailTemp.Length - 2, 2);
            ReceiverDatabaseListTextBox.Text = MailTemp;
        }

        public void DongKetNoi()
        {
            con.Close();
        }

        public void PlayMusic(bool PlayBGM)
        {
            if (PlayBGM == true)
            {
                defaultPlaybackDevice.Volume = BGMSetting.SoundValue;
                sp.PlayLooping();
            }
            else
            {
                defaultPlaybackDevice.Volume = BGMSetting.SoundValue;
                sp.Stop();
            }
        }
    }
}
