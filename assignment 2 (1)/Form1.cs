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
    }
}
