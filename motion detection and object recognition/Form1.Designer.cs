namespace motion_detection_and_object_recognition
{
    partial class Form1
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
            this.btn_captureImage = new System.Windows.Forms.Button();
            this.btn_motionDetect = new System.Windows.Forms.Button();
            this.btn_faceDetect = new System.Windows.Forms.Button();
            this.btn_livedetection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_captureImage
            // 
            this.btn_captureImage.Location = new System.Drawing.Point(313, 63);
            this.btn_captureImage.Name = "btn_captureImage";
            this.btn_captureImage.Size = new System.Drawing.Size(159, 47);
            this.btn_captureImage.TabIndex = 0;
            this.btn_captureImage.Text = "Capture image";
            this.btn_captureImage.UseVisualStyleBackColor = true;
            this.btn_captureImage.Click += new System.EventHandler(this.btn_captureImage_Click);
            // 
            // btn_motionDetect
            // 
            this.btn_motionDetect.Location = new System.Drawing.Point(313, 116);
            this.btn_motionDetect.Name = "btn_motionDetect";
            this.btn_motionDetect.Size = new System.Drawing.Size(159, 47);
            this.btn_motionDetect.TabIndex = 0;
            this.btn_motionDetect.Text = "Motion detection";
            this.btn_motionDetect.UseVisualStyleBackColor = true;
            this.btn_motionDetect.Click += new System.EventHandler(this.btn_motionDetect_Click);
            // 
            // btn_faceDetect
            // 
            this.btn_faceDetect.Location = new System.Drawing.Point(313, 169);
            this.btn_faceDetect.Name = "btn_faceDetect";
            this.btn_faceDetect.Size = new System.Drawing.Size(159, 47);
            this.btn_faceDetect.TabIndex = 0;
            this.btn_faceDetect.Text = "Face detection";
            this.btn_faceDetect.UseVisualStyleBackColor = true;
            this.btn_faceDetect.Click += new System.EventHandler(this.btn_faceDetect_Click);
            // 
            // btn_livedetection
            // 
            this.btn_livedetection.Location = new System.Drawing.Point(313, 222);
            this.btn_livedetection.Name = "btn_livedetection";
            this.btn_livedetection.Size = new System.Drawing.Size(159, 49);
            this.btn_livedetection.TabIndex = 1;
            this.btn_livedetection.Text = "Live face detection";
            this.btn_livedetection.UseVisualStyleBackColor = true;
            this.btn_livedetection.Click += new System.EventHandler(this.btn_livedetection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Face detection system";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::motion_detection_and_object_recognition.Properties.Resources.istockphoto_1347646440_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(33, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_livedetection);
            this.Controls.Add(this.btn_faceDetect);
            this.Controls.Add(this.btn_motionDetect);
            this.Controls.Add(this.btn_captureImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_captureImage;
        private System.Windows.Forms.Button btn_motionDetect;
        private System.Windows.Forms.Button btn_faceDetect;
        private System.Windows.Forms.Button btn_livedetection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

