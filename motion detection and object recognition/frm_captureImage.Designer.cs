namespace motion_detection_and_object_recognition
{
    partial class frm_captureImage
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_capture = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_imgeName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Start.Location = new System.Drawing.Point(42, 491);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(118, 42);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Open ";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_capture
            // 
            this.btn_capture.BackColor = System.Drawing.Color.Red;
            this.btn_capture.Location = new System.Drawing.Point(838, 557);
            this.btn_capture.Name = "btn_capture";
            this.btn_capture.Size = new System.Drawing.Size(118, 42);
            this.btn_capture.TabIndex = 0;
            this.btn_capture.Text = "Capture";
            this.btn_capture.UseVisualStyleBackColor = false;
            this.btn_capture.Click += new System.EventHandler(this.button2_Click);
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1.Location = new System.Drawing.Point(42, 61);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(462, 408);
            this.pic1.TabIndex = 1;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic2.Location = new System.Drawing.Point(675, 61);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(462, 408);
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Camera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(725, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Image name";
            // 
            // txt_imgeName
            // 
            this.txt_imgeName.Location = new System.Drawing.Point(838, 517);
            this.txt_imgeName.Name = "txt_imgeName";
            this.txt_imgeName.Size = new System.Drawing.Size(144, 20);
            this.txt_imgeName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1114, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_captureImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_imgeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btn_capture);
            this.Controls.Add(this.btn_Start);
            this.Name = "frm_captureImage";
            this.Text = "frm_captureImage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_captureImage_FormClosing);
            this.Load += new System.EventHandler(this.frm_captureImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_capture;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_imgeName;
        private System.Windows.Forms.Button button1;
    }
}