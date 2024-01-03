using AForge.Video;
using AForge.Video.DirectShow;
using FaceRecognition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace motion_detection_and_object_recognition
{
    public partial class frm_captureImage : Form
    {
       
        public frm_captureImage()
        {
            InitializeComponent();
        }
        VideoCaptureDevice VideoCapture;
        FilterInfoCollection filterInfo;

        void startcamera()
        {
            try
            {
                filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                VideoCapture = new VideoCaptureDevice(filterInfo[0].MonikerString);
                VideoCapture.NewFrame += new NewFrameEventHandler(Camera_on);
                VideoCapture.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Camera_on(object sender, NewFrameEventArgs eventArgs)
        {
            pic1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txt_imgeName.Text =="")
            {
                MessageBox.Show("Please give a name to the picture!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }     
            else
            {
                pic2.Image = pic1.Image;
                string filename = @"D:\Images\Image" + txt_imgeName.Text + ".jpg";
                var bitmap = new Bitmap(pic1.Width, pic1.Height);
                pic2.DrawToBitmap(bitmap, pic2.ClientRectangle);
                System.Drawing.Imaging.ImageFormat imageFormat = null;
                imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                bitmap.Save(filename, imageFormat);
            }
           
        }

        private void frm_captureImage_Load(object sender, EventArgs e)
        {

        }

        private void frm_captureImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                VideoCapture.Stop();
            }
            catch
            {
                return;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            startcamera();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
    }
}
