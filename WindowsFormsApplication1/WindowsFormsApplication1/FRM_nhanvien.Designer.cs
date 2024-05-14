namespace WindowsFormsApplication1
{
    partial class FRM_nhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_nhanvien));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnamsinh = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.butsua = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butluu = new System.Windows.Forms.Button();
            this.cbochucvu = new System.Windows.Forms.ComboBox();
            this.cbogioitinh = new System.Windows.Forms.ComboBox();
            this.butthem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butxuatexcel = new System.Windows.Forms.Button();
            this.qLPKTDataSet = new WindowsFormsApplication1.QLPKTDataSet();
            this.qLPKTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txttim = new System.Windows.Forms.TextBox();
            this.buttimkiem = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPKTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPKTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(409, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 31);
            this.label3.TabIndex = 171;
            this.label3.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 172;
            this.label1.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 175;
            this.label2.Text = "Mã NV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 174;
            this.label4.Text = "Họ và tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 176;
            this.label5.Text = "Năm sinh:";
            // 
            // txtnamsinh
            // 
            this.txtnamsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamsinh.Location = new System.Drawing.Point(178, 218);
            this.txtnamsinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtnamsinh.Name = "txtnamsinh";
            this.txtnamsinh.Size = new System.Drawing.Size(202, 23);
            this.txtnamsinh.TabIndex = 177;
            // 
            // txthoten
            // 
            this.txthoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Location = new System.Drawing.Point(178, 105);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(202, 23);
            this.txthoten.TabIndex = 178;
            this.txthoten.TextChanged += new System.EventHandler(this.txthoten_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 181;
            this.label6.Text = "Chức vụ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(472, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 182;
            this.label7.Text = "Điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(472, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 183;
            this.label8.Text = "Địa chỉ:";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(600, 50);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(202, 23);
            this.txtdiachi.TabIndex = 185;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdienthoai.Location = new System.Drawing.Point(600, 106);
            this.txtdienthoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(202, 23);
            this.txtdienthoai.TabIndex = 186;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.butsua);
            this.groupBox1.Controls.Add(this.butxoa);
            this.groupBox1.Controls.Add(this.butluu);
            this.groupBox1.Controls.Add(this.cbochucvu);
            this.groupBox1.Controls.Add(this.cbogioitinh);
            this.groupBox1.Controls.Add(this.butthem);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtdienthoai);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtnamsinh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(34, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 268);
            this.groupBox1.TabIndex = 189;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(180, 53);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.ReadOnly = true;
            this.txtmanv.Size = new System.Drawing.Size(200, 24);
            this.txtmanv.TabIndex = 194;
            this.txtmanv.TextChanged += new System.EventHandler(this.txtmanv_TextChanged);
            // 
            // butsua
            // 
            this.butsua.BackColor = System.Drawing.Color.RoyalBlue;
            this.butsua.ForeColor = System.Drawing.Color.White;
            this.butsua.Location = new System.Drawing.Point(714, 205);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(132, 40);
            this.butsua.TabIndex = 192;
            this.butsua.Text = "CẬP NHẬT";
            this.butsua.UseVisualStyleBackColor = false;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butxoa
            // 
            this.butxoa.BackColor = System.Drawing.Color.RoyalBlue;
            this.butxoa.ForeColor = System.Drawing.Color.White;
            this.butxoa.Location = new System.Drawing.Point(566, 207);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(132, 40);
            this.butxoa.TabIndex = 193;
            this.butxoa.Text = "XÓA";
            this.butxoa.UseVisualStyleBackColor = false;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butluu
            // 
            this.butluu.BackColor = System.Drawing.Color.RoyalBlue;
            this.butluu.ForeColor = System.Drawing.Color.White;
            this.butluu.Location = new System.Drawing.Point(416, 208);
            this.butluu.Name = "butluu";
            this.butluu.Size = new System.Drawing.Size(121, 40);
            this.butluu.TabIndex = 194;
            this.butluu.Text = "LƯU";
            this.butluu.UseVisualStyleBackColor = false;
            this.butluu.Click += new System.EventHandler(this.butluu_Click);
            // 
            // cbochucvu
            // 
            this.cbochucvu.FormattingEnabled = true;
            this.cbochucvu.Location = new System.Drawing.Point(600, 162);
            this.cbochucvu.Name = "cbochucvu";
            this.cbochucvu.Size = new System.Drawing.Size(202, 25);
            this.cbochucvu.TabIndex = 193;
            // 
            // cbogioitinh
            // 
            this.cbogioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbogioitinh.FormattingEnabled = true;
            this.cbogioitinh.Location = new System.Drawing.Point(178, 159);
            this.cbogioitinh.Name = "cbogioitinh";
            this.cbogioitinh.Size = new System.Drawing.Size(202, 25);
            this.cbogioitinh.TabIndex = 192;
            // 
            // butthem
            // 
            this.butthem.BackColor = System.Drawing.Color.DodgerBlue;
            this.butthem.ForeColor = System.Drawing.Color.White;
            this.butthem.Location = new System.Drawing.Point(386, 48);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(34, 39);
            this.butthem.TabIndex = 191;
            this.butthem.Text = "+";
            this.butthem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butthem.UseVisualStyleBackColor = false;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(852, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 189;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(34, 455);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1096, 275);
            this.listView1.TabIndex = 190;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã NV";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.Width = 229;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Năm sinh";
            this.columnHeader3.Width = 112;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới tính";
            this.columnHeader4.Width = 111;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Điện thoại";
            this.columnHeader5.Width = 119;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Địa chỉ";
            this.columnHeader6.Width = 224;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Chức vụ";
            this.columnHeader7.Width = 201;
            // 
            // butxuatexcel
            // 
            this.butxuatexcel.BackColor = System.Drawing.Color.Green;
            this.butxuatexcel.ForeColor = System.Drawing.Color.White;
            this.butxuatexcel.Location = new System.Drawing.Point(959, 404);
            this.butxuatexcel.Name = "butxuatexcel";
            this.butxuatexcel.Size = new System.Drawing.Size(162, 40);
            this.butxuatexcel.TabIndex = 195;
            this.butxuatexcel.Text = "XUẤT EXCEL";
            this.butxuatexcel.UseVisualStyleBackColor = false;
            this.butxuatexcel.Click += new System.EventHandler(this.butxuatexcel_Click);
            // 
            // qLPKTDataSet
            // 
            this.qLPKTDataSet.DataSetName = "QLPKTDataSet";
            this.qLPKTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLPKTDataSetBindingSource
            // 
            this.qLPKTDataSetBindingSource.DataSource = this.qLPKTDataSet;
            this.qLPKTDataSetBindingSource.Position = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1156, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 196;
            this.pictureBox2.TabStop = false;
            // 
            // txttim
            // 
            this.txttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttim.Location = new System.Drawing.Point(34, 413);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(238, 21);
            this.txttim.TabIndex = 198;
            // 
            // buttimkiem
            // 
            this.buttimkiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttimkiem.BackgroundImage")));
            this.buttimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttimkiem.Location = new System.Drawing.Point(277, 412);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(31, 26);
            this.buttimkiem.TabIndex = 197;
            this.buttimkiem.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(1069, 736);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 37);
            this.button4.TabIndex = 199;
            this.button4.Text = "THOÁT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FRM_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1151, 778);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.buttimkiem);
            this.Controls.Add(this.butxuatexcel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_nhanvien";
            this.Load += new System.EventHandler(this.FRM_nhanvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPKTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPKTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnamsinh;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private QLPKTDataSet qLPKTDataSet;
        private System.Windows.Forms.BindingSource qLPKTDataSetBindingSource;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butluu;
        private System.Windows.Forms.ComboBox cbogioitinh;
        private System.Windows.Forms.ComboBox cbochucvu;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Button butxuatexcel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Button buttimkiem;
        private System.Windows.Forms.Button button4;
    }
}