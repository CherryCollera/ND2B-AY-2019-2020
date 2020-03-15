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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_getmessage_Click(object sender, EventArgs e)
        {
            HappyBirthday hb = new HappyBirthday();
            MessageBox.Show(hb.GetMessage(" Maria"));
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            
        }

        private void btn_hide_Click(object sender, EventArgs e)
        { 
            this.Hide();
        }
    }
}
