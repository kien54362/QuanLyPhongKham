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
    public partial class FRM_Doimk : Form
    {
        public FRM_Doimk()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtmk1.Text==txtmk2.Text)
            {
                string sql1 = "update DN set MK='"+txtmk1.Text+"' where TENDN='"+txttk.Text+"'";
                Database.ThucThiTuyVan(sql1);
                MessageBox.Show("Đổi thành công");              
                Close();

            }
            else
            {
                MessageBox.Show("Nhập lại đi má");
            }
            
        }

        private void FRM_Doimk_Load(object sender, EventArgs e)
        {
            
        }
    }
}
