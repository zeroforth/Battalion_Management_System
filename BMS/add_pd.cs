using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BMS
{
    public partial class add_pd : Form
    {
        public add_pd()
        {
            InitializeComponent();
            this.MaximizeBox = false;

        }
        int flg = 1;
        private void add_pd_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https:/www.google.com");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstname.Text) == false && string.IsNullOrEmpty(lastname.Text) == false  && string.IsNullOrEmpty(dob.Text) == false && string.IsNullOrEmpty(forceno.Text) == false && string.IsNullOrEmpty(doj.Text) == false)
            {
                if(firstname.Text =="Rick" && lastname.Text =="Astley")
                {
                    this.Close();
                    string url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
                    Process.Start("firefox.exe", url);
                    
                }
                
                {
                    string message = "Do you wish to submit the data ? ";
                    string title = "Confirm submission";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {

                    }
                    else if (result == DialogResult.Yes)
                    {
                        try
                        {
                            //This is my connection string i have assigned the database file address path
                            string MyConnection2 = "datasource=localhost;database=unit_db;username=root;password=root";
                            //This is my insert query in which i am taking input from the user through windows forms
                            string Query = "insert into personnel_bms values( '" + int.Parse(this.forceno.Text) + "','" + this.firstname.Text + "','" + this.lastname.Text + "','" + this.dob.Text + "','" + this.address_rtb.Text + "','" + this.doj.Text + "','" + this.sector.Text + "','" + this.rank.Text + "','" + this.trade.Text + "','" + this.paygrade.Text + "','" + this.gender_cb.Text + "');";
                            //This is  MySqlConnection here i have created the object and pass my connection string.
                            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                            //This is command class which will handle the query and connection object.
                            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                            MySqlDataReader MyReader2;
                            MyConn2.Open();
                            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                            MessageBox.Show("Save Data");
                            while (MyReader2.Read())
                            {
                            }
                            MyConn2.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }

            }
            else
            {
                flg = 1;
                MessageBox.Show("Please fill all the mandatory details", "Warning", MessageBoxButtons.OK);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 12;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void rank_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void trade_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void paygrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flg==0)
            {
                TextWriter txt = new StreamWriter("D:\\dotnet files\\demo.txt");
                txt.Write("<Personal Details>\n\n");
                txt.Write("\n First Name: ");
                txt.Write(firstname.Text);
                txt.Write("\n Last Name: ");
                txt.Write(lastname.Text);
                txt.Write("\n Date of Birth:  ");
                txt.Write(dob.Text);
                txt.Write("\n Gender:  ");
                txt.Write(gender_cb.Text);
                txt.Write("\n Current Adress:  ");
                txt.Write(address_rtb.Text);
                txt.Write("\n\n <Job Details> \n\n");
                txt.Write("\n Force Number: ");
                txt.Write(forceno.Text);
                txt.Write("\n Date of joining :");
                txt.Write(doj.Text);
                txt.Write("\n Sector :");
                txt.Write(sector.Text);
                txt.Write("\n Rank :");
                txt.Write(rank.Text);
                txt.Write(" \\ ");
                txt.Write(trade.Text);
                MessageBox.Show("File saved as demo.txt ", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt.Close();
            }
            else if(flg==1)
            {
                MessageBox.Show("Please fill all the mandatory details", "Warning", MessageBoxButtons.OK);
            }
        }
    }
}
