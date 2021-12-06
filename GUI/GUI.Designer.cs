namespace ImageManipulator
{
    partial class GUI
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
            this.AddImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Rotate = new System.Windows.Forms.Button();
            this.FlipVertical = new System.Windows.Forms.Button();
            this.FlipHorizontal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // AddImage
            // 
            this.AddImage.Location = new System.Drawing.Point(32, 157);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(108, 23);
            this.AddImage.TabIndex = 0;
            this.AddImage.Text = "Change the Image";
            this.AddImage.UseVisualStyleBackColor = true;
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(146, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(280, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 128);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(414, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 128);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(550, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(128, 128);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Rotate
            // 
            this.Rotate.BackgroundImage = global::GUI.Properties.Resources.rotate;
            this.Rotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rotate.Location = new System.Drawing.Point(224, 143);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(50, 50);
            this.Rotate.TabIndex = 7;
            this.Rotate.UseVisualStyleBackColor = true;
            this.Rotate.Click += new System.EventHandler(this.RotateImage_Click);
            // 
            // FlipVertical
            // 
            this.FlipVertical.BackgroundImage = global::GUI.Properties.Resources.flipHorizontal;
            this.FlipVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlipVertical.Location = new System.Drawing.Point(320, 143);
            this.FlipVertical.Name = "FlipVertical";
            this.FlipVertical.Size = new System.Drawing.Size(50, 50);
            this.FlipVertical.TabIndex = 8;
            this.FlipVertical.UseVisualStyleBackColor = true;
            this.FlipVertical.Click += new System.EventHandler(this.FlipVertical_Click);
            // 
            // FlipHorizontal
            // 
            this.FlipHorizontal.BackgroundImage = global::GUI.Properties.Resources.flipVertical;
            this.FlipHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlipHorizontal.Location = new System.Drawing.Point(414, 143);
            this.FlipHorizontal.Name = "FlipHorizontal";
            this.FlipHorizontal.Size = new System.Drawing.Size(50, 50);
            this.FlipHorizontal.TabIndex = 9;
            this.FlipHorizontal.UseVisualStyleBackColor = true;
            this.FlipHorizontal.Click += new System.EventHandler(this.FlipHorizontal_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 198);
            this.Controls.Add(this.FlipHorizontal);
            this.Controls.Add(this.FlipVertical);
            this.Controls.Add(this.Rotate);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddImage);
            this.Name = "GUI";
            this.Text = "GUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button Rotate;
        private System.Windows.Forms.Button FlipVertical;
        private System.Windows.Forms.Button FlipHorizontal;
    }
}

