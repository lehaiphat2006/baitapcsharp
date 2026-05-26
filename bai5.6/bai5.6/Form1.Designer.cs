namespace bai5._6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBird = new System.Windows.Forms.PictureBox();
            this.picGround = new System.Windows.Forms.PictureBox();
            this.picPipedown = new System.Windows.Forms.PictureBox();
            this.picPipe = new System.Windows.Forms.PictureBox();
            this.lbscore = new System.Windows.Forms.Label();
            this.gametime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipe)).BeginInit();
            this.SuspendLayout();
            // 
            // picBird
            // 
            this.picBird.Image = ((System.Drawing.Image)(resources.GetObject("picBird.Image")));
            this.picBird.Location = new System.Drawing.Point(28, 235);
            this.picBird.Name = "picBird";
            this.picBird.Size = new System.Drawing.Size(73, 64);
            this.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBird.TabIndex = 0;
            this.picBird.TabStop = false;
            // 
            // picGround
            // 
            this.picGround.Image = ((System.Drawing.Image)(resources.GetObject("picGround.Image")));
            this.picGround.Location = new System.Drawing.Point(-1, 473);
            this.picGround.Name = "picGround";
            this.picGround.Size = new System.Drawing.Size(806, 77);
            this.picGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGround.TabIndex = 1;
            this.picGround.TabStop = false;
            // 
            // picPipedown
            // 
            this.picPipedown.Image = ((System.Drawing.Image)(resources.GetObject("picPipedown.Image")));
            this.picPipedown.Location = new System.Drawing.Point(266, -127);
            this.picPipedown.Name = "picPipedown";
            this.picPipedown.Size = new System.Drawing.Size(100, 307);
            this.picPipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPipedown.TabIndex = 2;
            this.picPipedown.TabStop = false;
            // 
            // picPipe
            // 
            this.picPipe.Image = ((System.Drawing.Image)(resources.GetObject("picPipe.Image")));
            this.picPipe.Location = new System.Drawing.Point(511, 334);
            this.picPipe.Name = "picPipe";
            this.picPipe.Size = new System.Drawing.Size(100, 144);
            this.picPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPipe.TabIndex = 3;
            this.picPipe.TabStop = false;
            // 
            // lbscore
            // 
            this.lbscore.BackColor = System.Drawing.SystemColors.Info;
            this.lbscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbscore.Location = new System.Drawing.Point(3, 499);
            this.lbscore.Name = "lbscore";
            this.lbscore.Size = new System.Drawing.Size(635, 34);
            this.lbscore.TabIndex = 4;
            this.lbscore.Text = "Score:";
            // 
            // gametime
            // 
            this.gametime.Interval = 20;
            this.gametime.Tick += new System.EventHandler(this.gametime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(626, 553);
            this.Controls.Add(this.lbscore);
            this.Controls.Add(this.picPipe);
            this.Controls.Add(this.picPipedown);
            this.Controls.Add(this.picGround);
            this.Controls.Add(this.picBird);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBird;
        private System.Windows.Forms.PictureBox picGround;
        private System.Windows.Forms.PictureBox picPipedown;
        private System.Windows.Forms.PictureBox picPipe;
        private System.Windows.Forms.Label lbscore;
        private System.Windows.Forms.Timer gametime;
    }
}

