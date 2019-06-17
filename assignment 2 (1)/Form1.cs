using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2__1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // calculates the total resistance for 3 resistors in series
            try
            {
                double res1 = double.Parse(textBox1.Text);
                double res2 = double.Parse(textBox2.Text);
                double res3 = double.Parse(textBox3.Text);
                double ans = +res1 + res2 + res3;
                label1.Text = ans.ToString();
            }
            catch
            {
                MessageBox.Show("Wrong");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // calculates the resistence for 3 resistoes in parallel
            try
            {
                double n1 = double.Parse(textBox4.Text);
                double n2 = double.Parse(textBox5.Text);
                double n3 = double.Parse(textBox6.Text);
                double frac = 1.0 / (1.0 / n1 + 1.0 / n2 + 1.0 / n3);
                label2.Text = frac.ToString();
            }
            catch
            {
                MessageBox.Show("Wrong");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // calculates the resistence for 4 resistoes in parallel
            try
            {
                double n1 = double.Parse(textBox7.Text);
                double n2 = double.Parse(textBox8.Text);
                double n3 = double.Parse(textBox9.Text);
                double n4 = double.Parse(textBox10.Text);
                double frac = 1.0 / (1.0 / n1 + 1.0 / n2 + 1.0 / n3 + 1.0 / n4);
                label3.Text = frac.ToString();
            }
            catch
            {
                MessageBox.Show("Wrong");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // calculates the resistence for 2 resistoes in series
            try
            {
                double res1 = double.Parse(textBox11.Text);
                double res2 = double.Parse(textBox12.Text);
                double ans = +res1 + res2;
                label4.Text = ans.ToString();
            }
            catch
            {
                MessageBox.Show("Wrong");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // calculates the resistence for 4 resistoes in series
            try
            {
                double res1 = double.Parse(textBox13.Text);
                double res2 = double.Parse(textBox14.Text);
                double res3 = double.Parse(textBox15.Text);
                double res4 = double.Parse(textBox16.Text);
                double ans = +res1 + res2 + res3 + res4;
                label5.Text = ans.ToString();
            }
            catch
            {
                MessageBox.Show("Wrong");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // calculates the resistence for 2 resistoes in parallel
            try
            {
                double n1 = double.Parse(textBox18.Text);
                double n2 = double.Parse(textBox17.Text);
                double frac = 1.0 / (1.0 / n1 + 1.0 / n2);
                label6.Text = frac.ToString();
            }
            catch
            {
                MessageBox.Show("Wrong");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // calculates the resistence for 5 resistoes in parallel
            try
            {
                double n1 = double.Parse(textBox19.Text);
                double n2 = double.Parse(textBox20.Text);
                double n3 = double.Parse(textBox21.Text);
                double n4 = double.Parse(textBox22.Text);
                double n5 = double.Parse(textBox23.Text);
                double frac = 1.0 / (1.0 / n1 + 1.0 / n2 + 1.0 / n3 + 1.0 / n4 + 1.0 / n5);
                label7.Text = frac.ToString();
            }
            catch
            {
                MessageBox.Show("Wrong");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // calculates the resistence for 5 resistoes in series
            try
            {
                double res1 = double.Parse(textBox24.Text);
                double res2 = double.Parse(textBox25.Text);
                double res3 = double.Parse(textBox26.Text);
                double res4 = double.Parse(textBox27.Text);
                double res5 = double.Parse(textBox28.Text);
                double ans = +res1 + res2 + res3 + res4 + res5;
                label8.Text = ans.ToString();
            }
            catch
            {
                MessageBox.Show("Wrong");
            }
        }
    }
}