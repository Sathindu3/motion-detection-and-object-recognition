using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace motion_detection_and_object_recognition
{
    public partial class frm_motionDetect : Form
    {
        private readonly MotionDetector motionDetector;
        private readonly VideoCaptureDevice videoSource;
        public frm_motionDetect()
        {
            InitializeComponent();

            // Initialize the motion detector
            motionDetector = new MotionDetector(
                new TwoFramesDifferenceDetector(),
                new MotionAreaHighlighting());


            // Initialize the video capture device
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += Video_NewFrame;
            videoSource.Start(); // Start capturing immediately
        }
        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap videoFrame = (Bitmap)eventArgs.Frame.Clone();

            if (motionDetector.ProcessFrame(videoFrame) > 0.02) // Adjust the threshold as needed
            {
                UpdateMotionDetectedUI(true);
            }
            else
            {
                UpdateMotionDetectedUI(false);
            }

            videoFrame.Dispose();
        }
        private void UpdateMotionDetectedUI(bool isMotionDetected)
        {
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    // Update UI based on motion detection
                    pictureBox1.BackColor = isMotionDetected ? Color.Red : Color.Green;
                    // Add more UI updates or actions as needed
                });
            }
            else
            {
                pictureBox1.BackColor = isMotionDetected ? Color.Red : Color.Green;
            }
        }

        private void frm_motionDetect_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoSource.SignalToStop();
            videoSource.WaitForStop();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            videoSource.Start(); // Start capturing when the button is clicked
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void frm_motionDetect_Load(object sender, EventArgs e)
        {

        }
    }
}
