namespace motion_detection_and_object_recognition
{
    partial class frm_facerec
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic.Location = new System.Drawing.Point(31, 46);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(896, 597);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // btn_detect
            // 
            this.btn_detect.Location = new System.Drawing.Point(990, 129);
            this.btn_detect.Name = "btn_detect";
            this.btn_detect.Size = new System.Drawing.Size(109, 44);
            this.btn_detect.TabIndex = 3;
            this.btn_detect.Text = "button1";
            this.btn_detect.UseVisualStyleBackColor = true;
            this.btn_detect.Click += new System.EventHandler(this.btn_detect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1107, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_facerec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_detect);
            this.Controls.Add(this.pic);
            this.Name = "frm_facerec";
            this.Text = "frm_facerec";
            this.Load += new System.EventHandler(this.frm_facerec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_detect;
        private System.Windows.Forms.Button button1;
    }
}