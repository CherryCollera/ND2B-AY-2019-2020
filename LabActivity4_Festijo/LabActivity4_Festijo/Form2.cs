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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            HappyBirthdayForm2 hbd = new HappyBirthdayForm2();
            MessageBox.Show(hbd.GetMessage(txtBox1.Text, txtBox2.Text));
            this.Hide();

            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
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
    }
}
