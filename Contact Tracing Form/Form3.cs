using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using System.IO;

namespace Contact_Tracing_Form
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            StreamReader text = new StreamReader(@"C:\Users\barbacena\Desktop\ContactTracingResponses\generatedqr.txt");
            string response = text.ReadToEnd();
            txtboxresponses.Text = response.ToString();
        }

        private void bttnGenerate_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator generateqr = new QRCoder.QRCodeGenerator();
            var Datas = generateqr.CreateQrCode(txtboxresponses.Text, QRCodeGenerator.ECCLevel.H);
            var qrcode = new QRCoder.QRCode(Datas);
            pbqrcode.Image = qrcode.GetGraphic(5);
        }

        private void bttnsave_Click(object sender, EventArgs e)
        {
            string dir = @"C:\Users\barbacena\Desktop\ContactTracingResponses";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = dir;
            dialog.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*gif";
            if (dialog.ShowDialog() == DialogResult.OK)

            {
                pbqrcode.Image.Save(dialog.FileName);
            }
            MessageBox.Show("Image Saved");
        }
    }
}
