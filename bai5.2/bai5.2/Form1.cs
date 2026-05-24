using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btngiai_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra và lấy dữ liệu từ các TextBox
            if (double.TryParse(txta.Text, out double a) &&
                double.TryParse(txtb.Text, out double b) &&
                double.TryParse(txtc.Text, out double c))
            {
                // 2. Tiến hành giải phương trình
                if (a == 0)
                {
                    // Nếu a = 0, phương trình trở thành bậc 1: bx + c = 0
                    if (b == 0)
                    {
                        if (c == 0)
                            lblketqua.Text = "Phương trình có vô số nghiệm";
                        else
                            lblketqua.Text = "Phương trình vô nghiệm";
                    }
                    else
                    {
                        double x = -c / b;
                        lblketqua.Text = $"Phương trình bậc 1 có nghiệm x = {Math.Round(x, 4)}";
                    }
                }
                else
                {
                    // Nếu a != 0, tính Delta
                    double delta = b * b - 4 * a * c;

                    if (delta < 0)
                    {
                        lblketqua.Text = "Phương trình vô nghiệm";
                    }
                    else if (delta == 0)
                    {
                        double x = -b / (2 * a);
                        lblketqua.Text = $"Phương trình có nghiệm kép x1 = x2 = {Math.Round(x, 4)}";
                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                        // Hiển thị kết quả 
                        lblketqua.Text = $"Phương trình có 2 nghiệm x1 = {Math.Round(x1, 4)}/ x2 = {Math.Round(x2, 4)}";
                    }
                }
            }
            else
            {
                // Thông báo nếu người dùng nhập chữ hoặc để trống
                MessageBox.Show("Vui lòng nhập đầy đủ các hệ số a, b, c dưới dạng số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
