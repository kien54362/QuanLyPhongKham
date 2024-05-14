using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace WindowsFormsApplication1
{
    public partial class FRM_thanhtoanmomo : Form
    {
        public FRM_thanhtoanmomo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var qrcode_text = $"2|99|{txt_phone.Text.Trim()}|{txt_name.Text.Trim()}|{txt_email.Text.Trim()}|0|0|{txt_sotien.Text.Trim()}";
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(qrcode_text);
            Bitmap logo = resizeImage(Properties.Resources.logo_momo, 64, 64) as Bitmap;
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            pic_qrcode.Image = bitmap;
        }
        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }
        void load()
        {
            txt_phone.Text = "0587189838";
            txt_name.Text = "THAI THANH TRUNG";
            txt_email.Text = "trungthaimtp001@gmail.com";
            txt_sotien.Text = "";
        }

        private void FRM_thanhtoanmomo_Load(object sender, EventArgs e)
        {
            load();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
