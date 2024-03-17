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
using MySql.Data.MySqlClient;


namespace BMS
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            

            // Set column headers font and background color
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;

            // Set row headers font and background color
            dataGridView1.RowHeadersDefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Italic);
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Yellow;

            // Set cell font and background color
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 8);
            dataGridView1.DefaultCellStyle.BackColor = Color.White;

            // Set alternating row background color
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            

       

           
            try
            {
                string MyConnection2 = "datasource=localhost;database=unit_db;username=root;password=root";
                //Display query
                string Query = "select * from dutylog;";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                // Set column headers text
              


                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                                                   // MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.duty_chart' table. You can move, or remove it, as needed.
           

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick_4(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
