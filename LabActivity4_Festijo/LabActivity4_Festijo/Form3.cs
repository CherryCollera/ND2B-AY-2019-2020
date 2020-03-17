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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MyProfile mp = new MyProfile();
            MessageBox.Show(mp.GetMessage(textBox1.Text, textBox2.Text));
            this.Hide();

            Form4 form4 = new Form4();
            form4.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
