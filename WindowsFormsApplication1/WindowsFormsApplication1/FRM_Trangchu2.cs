using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FRM_Trangchu2 : Form
    {
        public FRM_Trangchu2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            dangnhap db = new dangnhap();
            db.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xetnghiem dn = new xetnghiem();
            dn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_Xetnghiem DN = new FRM_Xetnghiem();
            DN.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FRM_Doimk dn = new FRM_Doimk();
            dn.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_Trangchu2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            dangnhap db = new dangnhap();
            db.ShowDialog();
            Close();
        }
    }
}
