using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Toan frm = new Form_Toan();
            frm.Show();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            Form_Dong frm = new Form_Dong();
            frm.Show();
        }

        private void btn_Dat_Click(object sender, EventArgs e)
        {
            Form_Dat frm = new Form_Dat();
            frm.Show();
        }
    }
}
