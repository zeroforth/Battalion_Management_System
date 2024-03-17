using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BMS
{

    public partial class login : Form
    {
        int count = 0;
        MySqlDataReader dr;
        


        public login()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            label6.Visible = false;
            label5.Visible = false;
            HelpButton = true;
            toolStripProgressBar1.Maximum = 2;
            statusStrip1.Visible = false;

            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=dummy2;uid=root;pwd='root';";
            cnn = new MySqlConnection(connetionString);

            string Sqlcmd = "Select * FROM login;";

            MySqlCommand cmd = new MySqlCommand(Sqlcmd, cnn);
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=unit_db;uid=root;pwd='root';";
            cnn = new MySqlConnection(connetionString);

            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error");
            }

            

            string user = textBox1.Text;
            string pass = textBox2.Text;
            MySqlCommand  cmd = new MySqlCommand();
            
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT * FROM login where uname='" + textBox1.Text + "' AND pwd='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.BackColor = Color.White;
                label5.Visible = false;

                textBox2.BackColor = Color.White;
                label6.Visible = false;

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.activation);//Use your own filename in place of _15035
                player.Play();
                this.Hide();
                var newform = new home();
                newform.Closed += (s, args) => this.Close();
                newform.Show();
            }
            else
            {
                textBox2.BackColor = Color.Salmon;
                label6.Visible = true;
                textBox1.BackColor = Color.Salmon;
                label6.Text = "UserName or Password does not match";
                

            }
            cnn.Close();

            /*if (textBox1.Text != "admin" || textBox2.Text!="root")
            {

               if(textBox1.Text != "admin")
                {
                    textBox1.BackColor = Color.Salmon;
                    label5.Text = "UserName does not match";
                    label5.Visible = true;
                }
                else
                {
                    textBox1.BackColor = Color.White;
                    label5.Visible = false;
                   
                }
                if (textBox2.Text != "root")
                {
                    textBox2.BackColor = Color.Salmon;
                    label6.Text = "Password does not match";
                    label6.Visible = true;
                
                }
                else
                {
                    textBox2.BackColor = Color.White;
                    label6.Visible = false;
                    
                }
                //DialogResult res = MessageBox.Show("Invalid credentials", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/
             if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
               
                DialogResult res = MessageBox.Show("The username or password cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripProgressBar1.Value = 0;
            }
           /* else{
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.activation);//Use your own filename in place of _15035
                player.Play();
                this.Hide();
                var newform = new home();
                newform.Closed += (s, args) => this.Close();
                newform.Show();
            }*/
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Firefox", "https://crpf.gov.in/about-us.htm");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.BackColor = Color.White;
                label5.Text = "UserName Cannot be empty";
                label5.Visible = true;
                count--;
                toolStripProgressBar1.Increment(-1);

            }
            else
            {
                label5.Visible = false;
                count++;
                toolStripProgressBar1.Increment(1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.BackColor = Color.White;
                label6.Text = "Password Cannot be empty";
                label6.Visible = true;
                count--;
                toolStripProgressBar1.Increment(-1);
            }
            else
            {
                label6.Visible = false;
                count++;
                toolStripProgressBar1.Increment(1);
            }

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.github.com/zerofourth/BMS22");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file:///D:/dotnet_files/BMS/help_page.html");
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file:///D:/dotnet_files/BMS/help_page.html");
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowDialog();
            label3.Font = fontDlg.Font;
            label4.Font = fontDlg.Font;
            label5.Font = fontDlg.Font;
            label6.Font = fontDlg.Font;
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var newform = new Form2();

            newform.Show();
        }
    }
}
