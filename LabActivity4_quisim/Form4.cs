using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabActivity4_quisim
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
            num1 = Convert.ToDouble(txtbox_fnum.Text);
            num2 = Convert.ToDouble(txtbox_snum.Text);
            tb_amount.Text = (num1 - num2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtbox_fnum.Text);
            num2 = Convert.ToDouble(txtbox_snum.Text);
            tb_amount.Text = (num1 * num2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtbox_fnum.Text);
            num2 = Convert.ToDouble(txtbox_snum.Text);
            tb_amount.Text = (num1 / num2).ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtbox_fnum.Text);
            num2 = Convert.ToDouble(txtbox_snum.Text);
            tb_amount.Text =(num1+num2).ToString();
        }
    }
}
