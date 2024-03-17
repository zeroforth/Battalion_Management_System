using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMS
{
    public partial class new_dutylog : Form
    {
        public new_dutylog()
        {
            InitializeComponent();
            Succeslabel.Visible= false;
            button2.Visible=false;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            MySqlConnection connection = new MySqlConnection("server=localhost;database=unit_db;username=root;password=root");
            MySqlCommand command = new MySqlCommand("SELECT force_no FROM personnel_bms", connection);

            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("force_no");
                comboBox1.Items.Add(id);
            }
            connection.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)|| string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Fill all the fields","Submission Succesfull",MessageBoxButtons.OK) ;
            }
            else
            {
                string insertQuery = "insert into dutylog values( '" + int.Parse(this.comboBox1.Text) + "','" + (this.comboBox2.Text) + "','" + this.textBox3.Text + "','" + this.textBox2.Text + "','" + this.textBox1.Text + "' );";
                MySqlConnection insertConn = new MySqlConnection("server=localhost;database=unit_db;username=root;password=root");
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, insertConn);
                try
                {
                    insertConn.Open();
                    insertCommand.ExecuteNonQuery();
                    Succeslabel.Text = "Data Inserted !";
                    Succeslabel.ForeColor = Color.DarkGreen;
                    
                }
                catch (MySqlException ex)
                {
                    Succeslabel.Text = "An error occured";
                    Succeslabel.ForeColor = Color.Red;
                    button1.Visible= false;
                }
                finally
                {
                    insertConn.Close();
                }
                button2.Visible = true;
                Succeslabel.Visible = true;


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=unit_db;username=root;password=root");
            int selectedId = (int)comboBox1.SelectedItem;
            MySqlCommand command2 = new MySqlCommand("SELECT f_name,l_name,frank,trade FROM personnel_bms WHERE force_no = @id", connection);
            command2.Parameters.AddWithValue("@id", selectedId);
            connection.Open();
            MySqlDataReader reader = command2.ExecuteReader();
            if (reader.Read())
            {
                string lname = reader.GetString("l_name");
                string fname = reader.GetString("f_name");
                string frnk = reader.GetString("frank");
                string trd = reader.GetString("trade");
                label8.Text = $"{fname} {lname}";
                label7.Text = $"{frnk} / {trd}";
            } else {
                
            }
        connection.Close();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            Succeslabel.Visible = false;
            foreach (Control control in Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)control).Text = string.Empty;
                }
               
                // add other input fields as needed
            }
            button2.Visible = false;
        }
       
    }
 }



