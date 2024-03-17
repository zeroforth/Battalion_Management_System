using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BMS
{
    public partial class update_armoury : Form
    {
        public update_armoury()
        {
            InitializeComponent();
            button1.Visible= false;
            
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(wid.Text) == false && string.IsNullOrEmpty(series.Text) == false && string.IsNullOrEmpty(manufac.Text) == false && string.IsNullOrEmpty(capacity.Text) == false && string.IsNullOrEmpty(wname.Text) == false )
            {
                
                
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

                        string MyConnection2 = "datasource=localhost;database=unit_db;username=root;password=root";
                        string selectQuery = "select count(*) from clone_armoury where wid = " + int.Parse(this.wid.Text) + ";";
                        MySqlConnection selectConn = new MySqlConnection(MyConnection2);
                        MySqlCommand selectCommand = new MySqlCommand(selectQuery, selectConn);
                        selectConn.Open();
                        int gdExists = Convert.ToInt32(selectCommand.ExecuteScalar());
                        selectConn.Close();

                        if (gdExists == 0)
                        {
                            String ammotype ="";
                            if (radioButton1.Checked)
                            {
                                ammotype= radioButton1.Text;
                            }

                            else if (radioButton2.Checked)
                            {
                                ammotype= radioButton2.Text;
                            }

                            // gd_num does not exist, proceed with insert
                            string insertQuery = "insert into clone_armoury values( '" + int.Parse(this.wid.Text) + "','" + this.wname.Text + "','" + this.series.Text + "','" + this.category.Text + "','" + this.capacity.Text + "','" + this.calibre.Text + "','" + this.purdate.Text + "','" + this.manufac.Text + "','" + ammotype + "','" + this.armoury.Text + "','" + this.KIT.Text + "','" + this.damage.Text + "');";
                            MySqlConnection insertConn = new MySqlConnection(MyConnection2);
                            MySqlCommand insertCommand = new MySqlCommand(insertQuery, insertConn);
                            MySqlDataReader insertReader;
                            insertConn.Open();
                            insertReader = insertCommand.ExecuteReader();
                            while (insertReader.Read())
                            {
                            }
                            insertConn.Close();
                            MessageBox.Show("Item added sucessfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            button1.Visible = true;

                        }
                        else
                        {
                            // gd_num already exists, show message box
                            MessageBox.Show("This weapon id No. already exists ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                        
                    }
                }

            }
            else
            {
                MessageBox.Show("Please fill all the mandatory details", "Warning", MessageBoxButtons.OK);
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_qm.ResetAllControls(this);
            button1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ammo_type_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
