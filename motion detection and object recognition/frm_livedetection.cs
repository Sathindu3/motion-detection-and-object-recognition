using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace motion_detection_and_object_recognition
{
    public partial class frm_livedetection : Form
    {
        public frm_livedetection()
        {
            InitializeComponent();
        }
        FilterInfoCollection filter;
        VideoCaptureDevice device;

        private void frm_livedetection_Load(object sender, EventArgs e)
        {
            filter =new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo device in filter)
                cboDevice.Items.Add(device.Name);
            cboDevice.SelectedIndex = 0;
            device = new VideoCaptureDevice();
        }

        private void btn_detect_Click(object sender, EventArgs e)
        {
            device= new VideoCaptureDevice(filter[cboDevice.SelectedIndex].MonikerString);
            device.NewFrame += Device_NewFrame;
            device.Start();
        }

        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
            foreach (Rectangle rectangle in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Red, 1))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
            }
            pic.Image = bitmap;
        }

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");

        private void frm_livedetection_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(device.IsRunning)
            {
                device.Stop();
            }
        }
    }
}
