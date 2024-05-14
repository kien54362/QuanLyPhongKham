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
    public partial class FRM_Trangchu3 : Form
    {
        public FRM_Trangchu3()
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

        private void label2_Click(object sender, EventArgs e)
        {
            FRM_Doimk3 dn = new FRM_Doimk3();
            dn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_quanlythanhtoan dn = new FRM_quanlythanhtoan();
                dn.ShowDialog();
        }

        private void FRM_Trangchu3_Load(object sender, EventArgs e)
        {

        }
    }
}
