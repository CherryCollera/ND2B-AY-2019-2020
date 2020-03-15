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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button_hide_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();

        }

        private void btn_getmyprofile_Click(object sender, EventArgs e)
        {
            MyProfile mp = new MyProfile();
            MessageBox.Show(mp.GetMyProfile(txtbox_fname.Text, txtbox_lname.Text));
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
