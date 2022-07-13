namespace Contact_Tracing_Form
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.lblCamera = new System.Windows.Forms.Label();
            this.cbcamera = new System.Windows.Forms.ComboBox();
            this.pbImageScan = new System.Windows.Forms.PictureBox();
            this.txtboxScanQr = new System.Windows.Forms.TextBox();
            this.bttnstart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageScan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamera.Location = new System.Drawing.Point(59, 40);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(58, 16);
            this.lblCamera.TabIndex = 5;
            this.lblCamera.Text = "Camera:";
            // 
            // cbcamera
            // 
            this.cbcamera.FormattingEnabled = true;
            this.cbcamera.Location = new System.Drawing.Point(148, 40);
            this.cbcamera.Name = "cbcamera";
            this.cbcamera.Size = new System.Drawing.Size(207, 21);
            this.cbcamera.TabIndex = 6;
            // 
            // pbImageScan
            // 
            this.pbImageScan.Location = new System.Drawing.Point(21, 88);
            this.pbImageScan.Name = "pbImageScan";
            this.pbImageScan.Size = new System.Drawing.Size(226, 209);
            this.pbImageScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImageScan.TabIndex = 7;
            this.pbImageScan.TabStop = false;
            // 
            // txtboxScanQr
            // 
            this.txtboxScanQr.BackColor = System.Drawing.SystemColors.Info;
            this.txtboxScanQr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxScanQr.ForeColor = System.Drawing.SystemColors.Info;
            this.txtboxScanQr.Location = new System.Drawing.Point(290, 88);
            this.txtboxScanQr.Multiline = true;
            this.txtboxScanQr.Name = "txtboxScanQr";
            this.txtboxScanQr.Size = new System.Drawing.Size(161, 158);
            this.txtboxScanQr.TabIndex = 8;
            // 
            // bttnstart
            // 
            this.bttnstart.BackColor = System.Drawing.Color.Turquoise;
            this.bttnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnstart.ForeColor = System.Drawing.Color.Black;
            this.bttnstart.Location = new System.Drawing.Point(290, 273);
            this.bttnstart.Name = "bttnstart";
            this.bttnstart.Size = new System.Drawing.Size(161, 24);
            this.bttnstart.TabIndex = 9;
            this.bttnstart.Text = "Scan";
            this.bttnstart.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(493, 339);
            this.Controls.Add(this.bttnstart);
            this.Controls.Add(this.txtboxScanQr);
            this.Controls.Add(this.pbImageScan);
            this.Controls.Add(this.cbcamera);
            this.Controls.Add(this.lblCamera);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "QR Code Scan";
            ((System.ComponentModel.ISupportInitialize)(this.pbImageScan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.ComboBox cbcamera;
        private System.Windows.Forms.PictureBox pbImageScan;
        private System.Windows.Forms.TextBox txtboxScanQr;
        private System.Windows.Forms.Button bttnstart;
    }
}