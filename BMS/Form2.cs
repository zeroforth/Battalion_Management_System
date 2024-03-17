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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMS
{
    public partial class Form2 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=root;database=unit_db;");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        string sql;

        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void LoadCombo(string sql, string DisplayMember, string ValueMember)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {           sql = "SELECT * FROM `personnel_bms`";
            LoadCombo(sql, "force_no", "force_no");
        }
    }
}
