using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing.Aztec;
using ZXing;
using AForge;



namespace Contact_Tracing_Form
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterinfocollection;
        VideoCaptureDevice vcdevice;

        private void Form4_Load(object sender, EventArgs e)
        {
            filterinfocollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo device in filterinfocollection)
                cbcamera.Items.Add(device.Name);
            cbcamera.SelectedIndex = 0;

            vcdevice = new VideoCaptureDevice();
        }

        private void bttnstart_Click(object sender, EventArgs e)
        {
            vcdevice = new VideoCaptureDevice(filterinfocollection[cbcamera.SelectedIndex].MonikerString);
            vcdevice.NewFrame += new NewFrameEventHandler(Vcdevice_NewFrame);

            vcdevice.Start();
            timer.Start();

        }

        private void Vcdevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbImageScan.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pbImageScan.Image != null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)pbImageScan.Image);

                if (result != null)
                {
                    txtboxScanQr.Text = result.ToString();
                    timer.Stop();
                    if (vcdevice.IsRunning)
                        vcdevice.Stop();
                }
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (vcdevice.IsRunning)
                vcdevice.Stop();
        }

        private void bttnSaveInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information Saved!");
            StreamWriter write = new StreamWriter(@"C:\Users\barbacena\Desktop\ContactTracingResponses\infofromqr.txt", true);
            write.WriteLine(txtboxScanQr.Text);
            write.Close();
        }
    }
}
