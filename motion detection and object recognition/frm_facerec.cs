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
using FaceRecognition;
using Emgu.CV;
using Emgu.CV.Structure;

namespace motion_detection_and_object_recognition
{
    public partial class frm_facerec : Form
    {
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");

        public frm_facerec()
        {
            InitializeComponent();

        }            

        private void frm_facerec_Load(object sender, EventArgs e)
        {

        }

        private void btn_detect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, Filter = "JPEG|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = Image.FromFile(ofd.FileName);
                    Bitmap bitmap = new Bitmap(pic.Image);
                    Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
                    Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.4, 0);
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
    }
}
