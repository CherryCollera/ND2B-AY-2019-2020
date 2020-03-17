using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabActivity4_Festijo
{
    public partial class Form4 : Form
    {
        double num1, num2;
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (num1 * num2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (num1 - num2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (num1 / num2).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (num1 + num2).ToString();
        }
    }
}
