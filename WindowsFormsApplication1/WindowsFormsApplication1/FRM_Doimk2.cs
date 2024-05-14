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
    public partial class FRM_Doimk2 : Form
    {
        public FRM_Doimk2()
        {
            InitializeComponent();
        }

        private void FRM_Doimk2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtmk1.Text == txtmk2.Text)
            {
                string sql1 = "update DN2 set MK2='" + txtmk1.Text + "' where TENDN2='" + txttk.Text + "'";
                Database.ThucThiTuyVan(sql1);
                MessageBox.Show("Đổi thành công");
                Close();

            }
            else
            {
                MessageBox.Show("Nhập lại đi má");
            }
        }
    }
}
