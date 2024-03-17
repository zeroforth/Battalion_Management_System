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

namespace BMS
{
    public partial class new_gdlog : Form
    {
        public new_gdlog()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(checkBox3.Checked == true && checkBox2.Checked == true )
            {
                if ((new Regex(@"^(0|[1-9][0-9]*)$")).IsMatch(rep_forceno.Text) == false || (new Regex(@"^(0|[1-9][0-9]*)$")).IsMatch(sicfno.Text) == false || (new Regex(@"^(0|[1-9][0-9]*)$")).IsMatch(cicfno.Text) == false )
                {
                    MessageBox.Show("Please enter valid data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    string message = "Do you wish to submit the report ? ";
                    string title = "Confirm submission";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {

                    }
                    else if (result == DialogResult.Yes)
                    {
                        string MyConnection2 = "datasource=localhost;database=unit_db;username=root;password=root";
                        string selectQuery = "select count(*) from gdlog where gdnum = " + int.Parse(this.gdnum.Text) + ";";
                        MySqlConnection selectConn = new MySqlConnection(MyConnection2);
                        MySqlCommand selectCommand = new MySqlCommand(selectQuery, selectConn);
                        selectConn.Open();
                        int gdExists = Convert.ToInt32(selectCommand.ExecuteScalar());
                        selectConn.Close();

                        if (gdExists == 0)
                        {
                            // gd_num does not exist, proceed with insert
                            string insertQuery = "insert into gdlog values( '" + int.Parse(this.gdnum.Text) + "','" + int.Parse(this.rep_forceno.Text) + "','" + this.rep_name.Text + "','" + this.dateTimePicker2.Text + "','" + this.time.Text + "','" + this.category.Text + "','" + this.location.Text + "','" + this.particulars.Text + "','" + int.Parse(this.casuality.Text) + "','" + int.Parse(this.sicfno.Text) + "','" + this.sic_name.Text + "','" + int.Parse(this.cicfno.Text) + "','" + this.cicname.Text + "');";
                            MySqlConnection insertConn = new MySqlConnection(MyConnection2);
                            MySqlCommand insertCommand = new MySqlCommand(insertQuery, insertConn);
                            MySqlDataReader insertReader;
                            insertConn.Open();
                            insertReader = insertCommand.ExecuteReader();
                            while (insertReader.Read())
                            {
                            }
                            insertConn.Close();
                            MessageBox.Show("Your GD has been succesfully submitted ", "Submission succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            // gd_num already exists, show message box
                            MessageBox.Show("This GD No. already exists ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Please provide agreement to the given clauses","Warning",MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                 button3.Text= opnfd.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Text Files (*.doc;*docx;.*.pdf;)|*.doc;*docx;.*.pdf;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                button1.Text = opnfd.FileName;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
