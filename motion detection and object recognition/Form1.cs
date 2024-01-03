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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_captureImage_Click(object sender, EventArgs e)
        {
            frm_captureImage captureImage = new frm_captureImage();
            this.Hide();
            captureImage.Show();
        }

        private void btn_motionDetect_Click(object sender, EventArgs e)
        {
            frm_motionDetect frmMotionDetect = new frm_motionDetect();
            this.Hide();
            frmMotionDetect.Show();
        }

        private void btn_faceDetect_Click(object sender, EventArgs e)
        {
            frm_facerec frmfaceDetect = new frm_facerec();
            this.Hide();
            frmfaceDetect.Show();

        }

        private void btn_livedetection_Click(object sender, EventArgs e)
        {
            frm_livedetection live = new frm_livedetection();
            this.Hide();
            live.Show();
        }
    }
}
