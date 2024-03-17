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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void home_Load(object sender, EventArgs e)
        {
            home f = new home();
            f.BackColor= Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new update_qm();
            myForm.Show();
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            var myForm = new add_pd();
            myForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void personnelDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void enterNewPersonnelDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new add_pd();
            myForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var myForm = new new_dutylog();
            myForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            var myForm = new new_gdlog();
            myForm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string message = "Do you want to logout? ";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {

            }
            else if (result == DialogResult.Yes)
            {
                MessageBox.Show("You have been logged out ", "Logout succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myForm = new calculators();
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new update_armoury();
            myForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var myForm = new view_pd();
            myForm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var myForm = new view_armoury();
            myForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var myForm = new view_gd();
            myForm.Show();
        }
    }
}
