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
    public partial class view_gd : Form
    {
        public view_gd()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            groupBox1.Visible = false;
            dataGridView1.Visible = false;
            label5.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
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
                cmd.CommandText = "SELECT * FROM gdlog WHERE gdnum = '" + userInputValue + "'";
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
                    string gdnum1 = dataReader[0].ToString();
                    string rfno1 = dataReader[1].ToString();
                    string rlname1 = dataReader[2].ToString();
                    string gddate1 = dataReader[3].ToString();
                    string gdtime1 = dataReader[4].ToString();
                    string category1 = dataReader[5].ToString();
                    string location1 = dataReader[6].ToString();
                    string parti1 = dataReader[7].ToString();
                    string cas1 = dataReader[8].ToString();
                    string shiftno1 = dataReader[9].ToString();
                    string shiftnam1e = dataReader[10].ToString();
                    string caseno1 = dataReader[11].ToString();
                    string casename1 = dataReader[12].ToString();
                    // Close data reader and connection
                    dataReader.Close();
                    connection.Close();
                    // set UI fields

                    gdnum.Text= gdnum1;
                    reported_by.Text = rfno1 + " " + rlname1;
                    
                    dateinc.Text = gddate1;
                    timeinc.Text = gdtime1;
                    category.Text = category1;
                    location.Text = location1;
                    particulars.Text = parti1;
                    shiftic.Text = shiftno1 + " " + shiftnam1e;
                    caseic.Text = caseno1 + " " + casename1;

                    
                }
                else
                {
                    groupBox1.Visible = false;
                    // Close data reader and connection
                    dataReader.Close();
                    connection.Close();
                    // handle the case when the given user input value is not found in the database
                    label5.Visible = true;

                    
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            dataGridView1.Visible = true;
            string connStr = "Data Source=localhost;port=3306;Initial Catalog=unit_db;User Id=root;Password=root;";
            string query = "SELECT gdnum,category,gd_date,location,casuality FROM gdlog;";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
