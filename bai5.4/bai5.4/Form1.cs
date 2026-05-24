using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Hàm phụ trách tính toán logic chính
        private void TinhTienTaxi()
        {
            // Nếu TextBox trống hoặc không nhập đúng số thì xóa trắng ô kết quả và dừng lại
            if (!double.TryParse(txtquangduong.Text, out double km) || km <= 0)
            {
                lbtongtien.Text = "";
                return;
            }

            double tongTien = 0;

            // Xử lý tính toán lũy tiến cho XE 7 CHỖ
            if (rd7c.Checked)
            {
                if (km <= 1)
                {
                    tongTien = km * 17000;
                }
                else if (km <= 5)
                {
                    tongTien = (1 * 17000) + ((km - 1) * 15000);
                }
                else if (km <= 100)
                {
                    tongTien = (1 * 17000) + (4 * 15000) + ((km - 5) * 12000);
                }
                else // Trên 101 km
                {
                    tongTien = (1 * 17000) + (4 * 15000) + (95 * 12000) + ((km - 100) * 11000);
                }
            }
            // Xử lý tính toán lũy tiến cho XE 4 CHỖ
            else if (rd4c.Checked)
            {
                if (km <= 1)
                {
                    tongTien = km * 15000;
                }
                else if (km <= 5)
                {
                    tongTien = (1 * 15000) + ((km - 1) * 13500);
                }
                else if (km <= 100)
                {
                    tongTien = (1 * 15000) + (4 * 13500) + ((km - 5) * 11000);
                }
                else // Trên 101 km
                {
                    tongTien = (1 * 15000) + (4 * 13500) + (95 * 11000) + ((km - 100) * 10000);
                }
            }

            // Kiểm tra xem có áp dụng giảm giá 5% không
            if (cbgiamgia.Checked)
            {
                tongTien = tongTien * 0.95; // Giảm 5% tức là còn lại 95% số tiền
            }

            // Hiển thị kết quả lên màn hình
            lbtongtien.Text = tongTien.ToString();
        }

        private void txtquangduong_TextChanged(object sender, EventArgs e)
        {
            TinhTienTaxi();
        }

        private void rd7c_CheckedChanged(object sender, EventArgs e)
        {
            TinhTienTaxi();
        }

        private void rd4c_CheckedChanged(object sender, EventArgs e)
        {
            TinhTienTaxi();
        }

        private void cbgiamgia_CheckedChanged(object sender, EventArgs e)
        {
            TinhTienTaxi();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
