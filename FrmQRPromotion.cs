using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoV1.UI
{
    public partial class FrmQRPromotion : Form
    {
        public FrmQRPromotion()
        {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnGenerateCodeBar_Click(object sender, EventArgs e)
        {
            try
            {
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox1.Image = barcode.Draw(txtEnterCode.Text, 150);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveQR_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "JPEG|*.jpeg";

            try
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    string varimg = saveFileDialog1.FileName;
                    Bitmap varbmp = new Bitmap(pictureBox1.Image);
                    varbmp.Save(varimg, ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveCodeBar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "JPEG|*.jpeg";

            try
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    string varimg = saveFileDialog1.FileName;
                    Bitmap varbmp = new Bitmap(pictureBox1.Image);
                    varbmp.Save(varimg, ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
;        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            try
            {
                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                pictureBox1.Image = qrcode.Draw(txtEnterCode.Text, 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmQR_Load(object sender, EventArgs e)
        {
            this.txtEnterCode.Focus();
        }
    }
}
