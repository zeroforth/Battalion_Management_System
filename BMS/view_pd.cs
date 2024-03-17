using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BMS
{
    public partial class view_pd : Form
    {
        
        public view_pd()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            groupBox1.Visible = false;
            dataGridView1.Visible = false;
            label5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            dataGridView1.Visible=true;
            string connStr = "Data Source=localhost;port=3306;Initial Catalog=unit_db;User Id=root;Password=root;";
            string query = "SELECT force_no,concat_ws('/' , frank , trade) as force_rank ,concat_ws(' ',f_name,l_name) AS name,gender,dob FROM personnel_bms;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            dataGridView1.Visible = false;
            
            {
                string userInputValue = textBox1.Text; // replace with actual user input value
                string connectionString = "server=localhost;user id=root;password=root;database=unit_db;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM personnel_bms WHERE force_no = '" + userInputValue + "'";
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    // set up array
                    int numRows = dataReader.FieldCount;
                    String[] userdata = new String[numRows];

                    while (dataReader.Read())
                    {
                        for (int i = 0; i < numRows; i++)
                        {
                            userdata[i] = dataReader[i].ToString();
                        }
                    }
                    string forcenum = dataReader[0].ToString();
                    string fname = dataReader[1].ToString();
                    string lname = dataReader[2].ToString();
                    string dob = dataReader[3].ToString();
                    string adr = dataReader[4].ToString();
                    string doj = dataReader[5].ToString();
                    string sector = dataReader[6].ToString();
                    string frank = dataReader[7].ToString();
                    string trade = dataReader[8].ToString();
                    string pgrade = dataReader[9].ToString();
                    string gender = dataReader[10].ToString();
                    // Close data reader and connection
                    dataReader.Close();
                    connection.Close();
                    // set UI fields
                    forcenum_l.Text = forcenum;
                    name_l.Text = fname + " " + lname;
                    rank_l.Text = frank + "/" + trade;
                    sector_l.Text = sector;
                    paygrade_l.Text = pgrade;
                    doj_l.Text = doj;
                    gender_l.Text = gender;
                    dob_l.Text = dob;
                    adr_l.Text = adr;
                }
                else
                {
                    groupBox1.Visible= false;
                    // Close data reader and connection
                    dataReader.Close();
                    connection.Close();
                    // handle the case when the given user input value is not found in the database
                    label5.Visible = true;

                    // or display a message to the user and clear UI fields
                    forcenum_l.Text = "";
                    name_l.Text = "";
                    rank_l.Text = "";
                    sector_l.Text = "";
                    paygrade_l.Text = "";
                    doj_l.Text = "";
                    gender_l.Text = "";
                    dob_l.Text = "";
                    adr_l.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            label5.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void view_pd_Load(object sender, EventArgs e)
        {

        }
    }
}
