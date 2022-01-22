namespace ImageResize
{
    partial class ImageResize
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageResize));
            this.CamImageBox = new Emgu.CV.UI.ImageBox();
            this.btnStartLiveVideo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CamImageBox
            // 
            this.CamImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CamImageBox.Location = new System.Drawing.Point(14, 3);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(608, 433);
            this.CamImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            // 
            // btnStartLiveVideo
            // 
            this.btnStartLiveVideo.Location = new System.Drawing.Point(14, 444);
            this.btnStartLiveVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartLiveVideo.Name = "BrowseOutputBtn";
            this.btnStartLiveVideo.Size = new System.Drawing.Size(150, 35);
            this.btnStartLiveVideo.TabIndex = 6;
            this.btnStartLiveVideo.Text = "Browse Output";
            this.btnStartLiveVideo.UseVisualStyleBackColor = true;
            this.btnStartLiveVideo.Click += new System.EventHandler(this.BrowseOutputBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 444);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "BrowseInputBtn";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Browse Input";
            this.button1.UseVisualStyleBackColor = true;
            this.btnStartLiveVideo.Click += new System.EventHandler(this.BrowseInputBtn_Click);

            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 444);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "Start";
            this.button2.Size = new System.Drawing.Size(150, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.btnStartLiveVideo.Click += new System.EventHandler(this.StartBtn_Click);

            // 
            // ImageResize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStartLiveVideo);
            this.Controls.Add(this.CamImageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageResize";
            this.Text = "Camera Output";
            this.Load += new System.EventHandler(this.ImageResize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox CamImageBox;
        private System.Windows.Forms.Button btnStartLiveVideo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

