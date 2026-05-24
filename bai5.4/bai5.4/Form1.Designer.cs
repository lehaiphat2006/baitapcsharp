namespace bai5._4
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
            this.lbquangdg = new System.Windows.Forms.Label();
            this.lbthanhtoan = new System.Windows.Forms.Label();
            this.lbtongtien = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.cbgiamgia = new System.Windows.Forms.CheckBox();
            this.rd7c = new System.Windows.Forms.RadioButton();
            this.rd4c = new System.Windows.Forms.RadioButton();
            this.lbbanggia = new System.Windows.Forms.Label();
            this.txtquangduong = new System.Windows.Forms.TextBox();
            this.gbloaixe = new System.Windows.Forms.GroupBox();
            this.gbloaixe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbquangdg
            // 
            this.lbquangdg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbquangdg.Location = new System.Drawing.Point(34, 40);
            this.lbquangdg.Name = "lbquangdg";
            this.lbquangdg.Size = new System.Drawing.Size(178, 37);
            this.lbquangdg.TabIndex = 0;
            this.lbquangdg.Text = "Quảng đường đi (km):";
            // 
            // lbthanhtoan
            // 
            this.lbthanhtoan.AutoSize = true;
            this.lbthanhtoan.Location = new System.Drawing.Point(35, 165);
            this.lbthanhtoan.Name = "lbthanhtoan";
            this.lbthanhtoan.Size = new System.Drawing.Size(115, 16);
            this.lbthanhtoan.TabIndex = 2;
            this.lbthanhtoan.Text = "Số tiền thanh toán:";
            // 
            // lbtongtien
            // 
            this.lbtongtien.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbtongtien.Location = new System.Drawing.Point(35, 199);
            this.lbtongtien.Name = "lbtongtien";
            this.lbtongtien.Size = new System.Drawing.Size(176, 40);
            this.lbtongtien.TabIndex = 3;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(241, 199);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(109, 40);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // cbgiamgia
            // 
            this.cbgiamgia.AutoSize = true;
            this.cbgiamgia.Location = new System.Drawing.Point(241, 108);
            this.cbgiamgia.Name = "cbgiamgia";
            this.cbgiamgia.Size = new System.Drawing.Size(83, 20);
            this.cbgiamgia.TabIndex = 5;
            this.cbgiamgia.Text = "Giảm giá";
            this.cbgiamgia.UseVisualStyleBackColor = true;
            this.cbgiamgia.CheckedChanged += new System.EventHandler(this.cbgiamgia_CheckedChanged);
            // 
            // rd7c
            // 
            this.rd7c.AutoSize = true;
            this.rd7c.Location = new System.Drawing.Point(6, 26);
            this.rd7c.Name = "rd7c";
            this.rd7c.Size = new System.Drawing.Size(60, 20);
            this.rd7c.TabIndex = 6;
            this.rd7c.TabStop = true;
            this.rd7c.Text = "7 chổ";
            this.rd7c.UseVisualStyleBackColor = true;
            this.rd7c.CheckedChanged += new System.EventHandler(this.rd7c_CheckedChanged);
            // 
            // rd4c
            // 
            this.rd4c.AutoSize = true;
            this.rd4c.Location = new System.Drawing.Point(81, 26);
            this.rd4c.Name = "rd4c";
            this.rd4c.Size = new System.Drawing.Size(60, 20);
            this.rd4c.TabIndex = 7;
            this.rd4c.TabStop = true;
            this.rd4c.Text = "4 chổ";
            this.rd4c.UseVisualStyleBackColor = true;
            this.rd4c.CheckedChanged += new System.EventHandler(this.rd4c_CheckedChanged);
            // 
            // lbbanggia
            // 
            this.lbbanggia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbbanggia.Location = new System.Drawing.Point(1, 8);
            this.lbbanggia.Name = "lbbanggia";
            this.lbbanggia.Size = new System.Drawing.Size(427, 32);
            this.lbbanggia.TabIndex = 8;
            this.lbbanggia.Text = "Bảng giá";
            // 
            // txtquangduong
            // 
            this.txtquangduong.Location = new System.Drawing.Point(218, 43);
            this.txtquangduong.Name = "txtquangduong";
            this.txtquangduong.Size = new System.Drawing.Size(161, 22);
            this.txtquangduong.TabIndex = 9;
            this.txtquangduong.TextChanged += new System.EventHandler(this.txtquangduong_TextChanged);
            // 
            // gbloaixe
            // 
            this.gbloaixe.Controls.Add(this.rd7c);
            this.gbloaixe.Controls.Add(this.rd4c);
            this.gbloaixe.Location = new System.Drawing.Point(38, 81);
            this.gbloaixe.Name = "gbloaixe";
            this.gbloaixe.Size = new System.Drawing.Size(151, 61);
            this.gbloaixe.TabIndex = 10;
            this.gbloaixe.TabStop = false;
            this.gbloaixe.Text = "Loại xe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 261);
            this.Controls.Add(this.gbloaixe);
            this.Controls.Add(this.txtquangduong);
            this.Controls.Add(this.lbbanggia);
            this.Controls.Add(this.cbgiamgia);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.lbtongtien);
            this.Controls.Add(this.lbthanhtoan);
            this.Controls.Add(this.lbquangdg);
            this.Name = "Form1";
            this.Text = "Tính tiền taxi";
            this.gbloaixe.ResumeLayout(false);
            this.gbloaixe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbquangdg;
        private System.Windows.Forms.Label lbthanhtoan;
        private System.Windows.Forms.Label lbtongtien;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.CheckBox cbgiamgia;
        private System.Windows.Forms.RadioButton rd7c;
        private System.Windows.Forms.RadioButton rd4c;
        private System.Windows.Forms.Label lbbanggia;
        private System.Windows.Forms.TextBox txtquangduong;
        private System.Windows.Forms.GroupBox gbloaixe;
    }
}

