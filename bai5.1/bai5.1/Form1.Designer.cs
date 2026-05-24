namespace bai5._1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbankinh = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnchuvi = new System.Windows.Forms.Button();
            this.btndientich = new System.Windows.Forms.Button();
            this.lblketqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập bán kính hình tròn:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbankinh
            // 
            this.txtbankinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbankinh.Location = new System.Drawing.Point(178, 6);
            this.txtbankinh.Name = "txtbankinh";
            this.txtbankinh.Size = new System.Drawing.Size(168, 22);
            this.txtbankinh.TabIndex = 1;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(263, 37);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(83, 23);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnchuvi
            // 
            this.btnchuvi.Location = new System.Drawing.Point(15, 37);
            this.btnchuvi.Name = "btnchuvi";
            this.btnchuvi.Size = new System.Drawing.Size(103, 23);
            this.btnchuvi.TabIndex = 3;
            this.btnchuvi.Text = "Chu vi";
            this.btnchuvi.UseVisualStyleBackColor = true;
            this.btnchuvi.Click += new System.EventHandler(this.btnchuvi_Click);
            // 
            // btndientich
            // 
            this.btndientich.Location = new System.Drawing.Point(135, 37);
            this.btndientich.Name = "btndientich";
            this.btndientich.Size = new System.Drawing.Size(107, 23);
            this.btndientich.TabIndex = 4;
            this.btndientich.Text = "Diện tích";
            this.btndientich.UseVisualStyleBackColor = true;
            this.btndientich.Click += new System.EventHandler(this.btndientich_Click);
            // 
            // lblketqua
            // 
            this.lblketqua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblketqua.Location = new System.Drawing.Point(12, 63);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(334, 110);
            this.lblketqua.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 182);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.btndientich);
            this.Controls.Add(this.btnchuvi);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtbankinh);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tính chu vi , diện tích hình tròn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbankinh;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnchuvi;
        private System.Windows.Forms.Button btndientich;
        private System.Windows.Forms.Label lblketqua;
    }
}

