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
    public partial class FRM_trangchu : Form
    {
        public FRM_trangchu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_nhanvien dn = new FRM_nhanvien();
            dn.ShowDialog();
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
            dn.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_quanlythanhtoan dn = new FRM_quanlythanhtoan();
            dn.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_quanlythietbi dn = new FRM_quanlythietbi();
            dn.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FRM_Xetnghiem dn = new FRM_Xetnghiem();
            dn.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FRM_Doimk dn = new FRM_Doimk();
            dn.ShowDialog();
        }

        private void FRM_trangchu_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            dangnhap db = new dangnhap();
            db.ShowDialog();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
