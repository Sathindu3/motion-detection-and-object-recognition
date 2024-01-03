namespace motion_detection_and_object_recognition
{
    partial class frm_livedetection
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
            this.pic = new System.Windows.Forms.PictureBox();
            this.btn_detect = new System.Windows.Forms.Button();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(68, 120);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(718, 403);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // btn_detect
            // 
            this.btn_detect.Location = new System.Drawing.Point(828, 124);
            this.btn_detect.Name = "btn_detect";
            this.btn_detect.Size = new System.Drawing.Size(88, 27);
            this.btn_detect.TabIndex = 1;
            this.btn_detect.Text = "Detect";
            this.btn_detect.UseVisualStyleBackColor = true;
            this.btn_detect.Click += new System.EventHandler(this.btn_detect_Click);
            // 
            // cboDevice
            // 
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(137, 46);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(121, 21);
            this.cboDevice.TabIndex = 2;
            // 
            // frm_livedetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 582);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.btn_detect);
            this.Controls.Add(this.pic);
            this.Name = "frm_livedetection";
            this.Text = "frm_livedetection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_livedetection_FormClosing);
            this.Load += new System.EventHandler(this.frm_livedetection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_detect;
        private System.Windows.Forms.ComboBox cboDevice;
    }
}