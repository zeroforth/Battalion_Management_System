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

namespace BMS
{
    public partial class view_armoury : Form
    {
        public view_armoury()
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
            dataGridView1.Visible = true;
            string connStr = "Data Source=localhost;port=3306;Initial Catalog=unit_db;User Id=root;Password=root;";
            string query = "SELECT wid,wname,capacity,category,series FROM clone_armoury;";
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
                cmd.CommandText = "SELECT * FROM clone_armoury WHERE force_no = '" + userInputValue + "'";
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
                    string wid = dataReader[0].ToString();
                    string wname = dataReader[1].ToString();
                    string series = dataReader[2].ToString();
                    string category = dataReader[3].ToString();
                    string capacity = dataReader[4].ToString();
                    string calibre = dataReader[5].ToString();
                    string purdate = dataReader[6].ToString();
                    string mf = dataReader[7].ToString();
                    string ammo_type = dataReader[8].ToString();
                    string added_to = dataReader[9].ToString();
                    string kit = dataReader[10].ToString();
                    string damage = dataReader[11].ToString();
                    // Close data reader and connection
                    dataReader.Close();
                    connection.Close();
                    // set UI fields
                    forcenum_l.Text = wid;
                    name_l.Text = wname ;
                    rank_l.Text = mf;
                    sector_l.Text = calibre;
                    paygrade_l.Text = ammo_type;
                    doj_l.Text = capacity;
                    gender_l.Text = series;
                    added_to_l.Text = added_to;
                    damage_l.Text = damage;
                    adr_l.Text = kit;
                   
                }
                else
                {
                    groupBox1.Visible = false;
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

        private void view_armoury_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void lablett_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            dataGridView1.Visible = false;

            {
                string userInputValue = textBox1.Text; // replace with actual user input value
                string connectionString = "server=localhost;user id=root;password=root;database=unit_db;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM clone_armoury WHERE wid = '" + userInputValue + "'";
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
                    string wid = dataReader[0].ToString();
                    string wname = dataReader[1].ToString();
                    string series = dataReader[2].ToString();
                    string category = dataReader[3].ToString();
                    string capacity = dataReader[4].ToString();
                    string calibre = dataReader[5].ToString();
                    string purdate = dataReader[6].ToString();
                    string mf = dataReader[7].ToString();
                    string ammo_type = dataReader[8].ToString();
                    string added_to = dataReader[9].ToString();
                    string kit = dataReader[10].ToString();
                    string damage = dataReader[11].ToString();
                    // Close data reader and connection
                    dataReader.Close();
                    connection.Close();
                    // set UI fields
                    forcenum_l.Text = wid;
                    name_l.Text = wname;
                    rank_l.Text = mf;
                    sector_l.Text = calibre;
                    dob_l.Text = purdate;
                    paygrade_l.Text = ammo_type;
                    doj_l.Text = capacity;
                    gender_l.Text = series;
                    added_to_l.Text = added_to;
                    damage_l.Text = damage;
                    adr_l.Text = kit;

                }
                else
                {
                    groupBox1.Visible = false;
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
        
        private void button2_Click_2(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            dataGridView1.Visible = true;
            string connStr = "Data Source=localhost;port=3306;Initial Catalog=unit_db;User Id=root;Password=root;";
            string query = "SELECT wid,wname,capacity,category,series FROM clone_armoury;";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
