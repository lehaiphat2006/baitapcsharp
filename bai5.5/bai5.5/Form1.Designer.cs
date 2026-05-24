namespace bai5._5
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
            this.gbshape = new System.Windows.Forms.GroupBox();
            this.rbrectangle = new System.Windows.Forms.RadioButton();
            this.rbelipse = new System.Windows.Forms.RadioButton();
            this.gbshape.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbshape
            // 
            this.gbshape.Controls.Add(this.rbrectangle);
            this.gbshape.Controls.Add(this.rbelipse);
            this.gbshape.Location = new System.Drawing.Point(615, 12);
            this.gbshape.Name = "gbshape";
            this.gbshape.Size = new System.Drawing.Size(173, 85);
            this.gbshape.TabIndex = 0;
            this.gbshape.TabStop = false;
            this.gbshape.Text = "Shape";
            // 
            // rbrectangle
            // 
            this.rbrectangle.AutoSize = true;
            this.rbrectangle.Location = new System.Drawing.Point(17, 47);
            this.rbrectangle.Name = "rbrectangle";
            this.rbrectangle.Size = new System.Drawing.Size(90, 20);
            this.rbrectangle.TabIndex = 1;
            this.rbrectangle.TabStop = true;
            this.rbrectangle.Text = "Rectangle";
            this.rbrectangle.UseVisualStyleBackColor = true;
            // 
            // rbelipse
            // 
            this.rbelipse.AutoSize = true;
            this.rbelipse.Location = new System.Drawing.Point(17, 21);
            this.rbelipse.Name = "rbelipse";
            this.rbelipse.Size = new System.Drawing.Size(66, 20);
            this.rbelipse.TabIndex = 0;
            this.rbelipse.TabStop = true;
            this.rbelipse.Text = "Elipse";
            this.rbelipse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbshape);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Draw Shape";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.gbshape.ResumeLayout(false);
            this.gbshape.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbshape;
        private System.Windows.Forms.RadioButton rbrectangle;
        private System.Windows.Forms.RadioButton rbelipse;
    }
}

