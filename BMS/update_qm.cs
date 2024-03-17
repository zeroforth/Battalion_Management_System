using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BMS
{
    public partial class update_qm : Form
    {
        public update_qm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            label7.Visible=false;
            button1.Visible=false;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            {
                string selectedRadioButtonText = "";

                foreach (System.Windows.Forms.RadioButton radioButton in type.Controls)
                {
                    if (radioButton is System.Windows.Forms.RadioButton && radioButton.Checked)
                    {
                        selectedRadioButtonText = radioButton.Text;
                        break;
                    }
                }
                try
                {
                    string MyConnection2 = "datasource=localhost;database=unit_db;username=root;password=root";
                    string insertQuery = "insert into qmstore values( '" + int.Parse(this.id.Text) + "','" + (this.name.Text) + "','" + this.category.Text + "','" + this.manufac.Text + "','" + this.date.Text + "','" + selectedRadioButtonText+ "','" + int.Parse(this.quantity.Text) + "','" + this.unit.Text + "','" + (this.comboBox1.Text) + "','" + (this.summary.Text) + "');";
                    MySqlConnection insertConn = new MySqlConnection(MyConnection2);
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, insertConn);
                    MySqlDataReader insertReader;
                    insertConn.Open();
                    insertReader = insertCommand.ExecuteReader();
                    while (insertReader.Read())
                    {
                    }
                    insertConn.Close();
                    label7.Visible = true;
                    label7.ForeColor = Color.DarkGreen;
                    label7.Text = "Submission Sucessful!";
                    button1.Visible = true;
                }
                catch (Exception ex)
                {
                   
                    label7.Visible = true;
                    label7.ForeColor = Color.Red;
                    label7.Text = "Submission failed!";
                    button1.Visible = true;
                }


               

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is System.Windows.Forms.CheckBox)
                {
                    System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label7.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_qm.ResetAllControls(this);
            button1.Visible= false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date.MinDate = new DateTime(1999, 1, 11);
            date.MaxDate = DateTime.Today;

            // Set the CustomFormat string.
            date.CustomFormat = "MMMM dd, yyyy";
            date.Format = DateTimePickerFormat.Custom;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(quantity.Value < 0) {
                quantity.Value= 0;
            }
            else if(quantity.Value > 1000 ){
                quantity.Value= 1000;
            }
            quantity.Maximum = 100;
            quantity.Minimum = 0;
        }
    }

}
