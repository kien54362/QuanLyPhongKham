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
    public partial class FRM_Doimk3 : Form
    {
        public FRM_Doimk3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtmk1.Text == txtmk2.Text)
            {
                string sql1 = "update DN3 set MK3='" + txtmk1.Text + "' where TENDN3='" + txttk.Text + "'";
                Database.ThucThiTuyVan(sql1);
                MessageBox.Show("Đổi thành công");
                Close();

            }
            else
            {
                MessageBox.Show("Nhập lại đi má");
            }
        }

        private void FRM_Doimk3_Load(object sender, EventArgs e)
        {

        }
    }
}
