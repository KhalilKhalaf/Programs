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
            this.NewImageBox = new Emgu.CV.UI.ImageBox();
            this.BrowseInputBtn = new System.Windows.Forms.Button();
            this.BrowseOutputBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.OldImageBox = new Emgu.CV.UI.ImageBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.IgnoreBtn = new System.Windows.Forms.Button();
            this.OldDataGridView = new System.Windows.Forms.DataGridView();
            this.AutoModeCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NewImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NewImageBox
            // 
            this.NewImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewImageBox.Location = new System.Drawing.Point(766, 3);
            this.NewImageBox.Name = "NewImageBox";
            this.NewImageBox.Size = new System.Drawing.Size(680, 403);
            this.NewImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NewImageBox.TabIndex = 2;
            this.NewImageBox.TabStop = false;
            // 
            // BrowseInputBtn
            // 
            this.BrowseInputBtn.Location = new System.Drawing.Point(3, 612);
            this.BrowseInputBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BrowseInputBtn.Name = "BrowseInputBtn";
            this.BrowseInputBtn.Size = new System.Drawing.Size(150, 42);
            this.BrowseInputBtn.TabIndex = 6;
            this.BrowseInputBtn.Text = "Browse Input";
            this.BrowseInputBtn.UseVisualStyleBackColor = true;
            this.BrowseInputBtn.Click += new System.EventHandler(this.BrowseInputBtn_Click);
            // 
            // BrowseOutputBtn
            // 
            this.BrowseOutputBtn.Location = new System.Drawing.Point(161, 612);
            this.BrowseOutputBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BrowseOutputBtn.Name = "BrowseOutputBtn";
            this.BrowseOutputBtn.Size = new System.Drawing.Size(150, 42);
            this.BrowseOutputBtn.TabIndex = 7;
            this.BrowseOutputBtn.Text = "Browse Output";
            this.BrowseOutputBtn.UseVisualStyleBackColor = true;
            this.BrowseOutputBtn.Click += new System.EventHandler(this.BrowseOutputBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(319, 612);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(150, 42);
            this.StartBtn.TabIndex = 8;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // OldImageBox
            // 
            this.OldImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OldImageBox.Location = new System.Drawing.Point(12, 3);
            this.OldImageBox.Name = "OldImageBox";
            this.OldImageBox.Size = new System.Drawing.Size(680, 403);
            this.OldImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OldImageBox.TabIndex = 9;
            this.OldImageBox.TabStop = false;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(1295, 615);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(150, 42);
            this.SubmitBtn.TabIndex = 10;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // IgnoreBtn
            // 
            this.IgnoreBtn.Location = new System.Drawing.Point(1137, 615);
            this.IgnoreBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IgnoreBtn.Name = "IgnoreBtn";
            this.IgnoreBtn.Size = new System.Drawing.Size(150, 42);
            this.IgnoreBtn.TabIndex = 11;
            this.IgnoreBtn.Text = "Ignore";
            this.IgnoreBtn.UseVisualStyleBackColor = true;
            this.IgnoreBtn.Click += new System.EventHandler(this.IgnoreBtn_Click);
            // 
            // OldDataGridView
            // 
            this.OldDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OldDataGridView.Location = new System.Drawing.Point(12, 412);
            this.OldDataGridView.Name = "OldDataGridView";
            this.OldDataGridView.RowHeadersWidth = 62;
            this.OldDataGridView.RowTemplate.Height = 28;
            this.OldDataGridView.Size = new System.Drawing.Size(1434, 195);
            this.OldDataGridView.TabIndex = 12;
            // 
            // AutoModeCheckbox
            // 
            this.AutoModeCheckbox.AutoSize = true;
            this.AutoModeCheckbox.Location = new System.Drawing.Point(477, 615);
            this.AutoModeCheckbox.Name = "AutoModeCheckbox";
            this.AutoModeCheckbox.Size = new System.Drawing.Size(113, 24);
            this.AutoModeCheckbox.TabIndex = 13;
            this.AutoModeCheckbox.Text = "Auto Mode";
            this.AutoModeCheckbox.UseVisualStyleBackColor = true;
            this.AutoModeCheckbox.CheckedChanged += new System.EventHandler(this.AutoModeCheckbox_CheckedChanged);
            // 
            // ImageResize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 668);
            this.Controls.Add(this.AutoModeCheckbox);
            this.Controls.Add(this.OldDataGridView);
            this.Controls.Add(this.IgnoreBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.OldImageBox);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.BrowseOutputBtn);
            this.Controls.Add(this.BrowseInputBtn);
            this.Controls.Add(this.NewImageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageResize";
            this.Text = "Camera Output";
            this.Load += new System.EventHandler(this.ImageResize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NewImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox OldImageBox;
        private Emgu.CV.UI.ImageBox NewImageBox;
        private System.Windows.Forms.Button BrowseInputBtn;
        private System.Windows.Forms.Button BrowseOutputBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button IgnoreBtn;
        private System.Windows.Forms.DataGridView OldDataGridView;
        private System.Windows.Forms.CheckBox AutoModeCheckbox;
    }
}

