namespace bai5._3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pichinhanh = new System.Windows.Forms.PictureBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pichinhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // pichinhanh
            // 
            this.pichinhanh.Image = ((System.Drawing.Image)(resources.GetObject("pichinhanh.Image")));
            this.pichinhanh.Location = new System.Drawing.Point(28, 33);
            this.pichinhanh.Name = "pichinhanh";
            this.pichinhanh.Size = new System.Drawing.Size(292, 375);
            this.pichinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pichinhanh.TabIndex = 0;
            this.pichinhanh.TabStop = false;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(530, 45);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(151, 55);
            this.btnopen.TabIndex = 1;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(530, 143);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(151, 54);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.pichinhanh);
            this.Name = "Form1";
            this.Text = "Simple Phôt Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pichinhanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pichinhanh;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

