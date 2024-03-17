using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMS
{
    public partial class calculators : Form
    {
        public calculators()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            label5.Visible = false;
            label6.Visible = false;
            label10.Visible = false;
            label16.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void calculate()
        {
            int i;
            double interest;
            double salary = 0 , gpf =0;
            double gpfp = double.Parse(textBox3.Text); ;
            double basepay = double.Parse(textBox2.Text);
            int n = int.Parse(textBox1.Text);
            for (i = 1; i <= n; i++)
            {
                salary = salary + basepay;
                interest = salary * ((gpfp / salary) * 100);
                salary = salary - interest;
                gpf = gpfp + interest;

            }

            label6.Visible = true;
            label5.Visible = true;
            label5.Text = gpf.ToString();
        }
        public void retire()
        {
            int yob = int.Parse(textBox5.Text);
            int allowance = int.Parse(textBox4.Text);
            int yoj = int.Parse(textBox6.Text);
            int total_allowance = 0;
            int service , count=1;
            service = (yob + 60)-yoj;

            while (count <= service)
            {
                total_allowance =total_allowance + allowance;
            }
            label10.Visible = true;
            label10.Text = service.ToString();
            label16.Visible = true;
            label16.Text = total_allowance.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            retire();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
    


}
