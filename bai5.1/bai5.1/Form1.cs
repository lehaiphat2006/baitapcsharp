using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnchuvi_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào có phải là số thực không
            if (double.TryParse(txtbankinh.Text, out double r))
            {
                if (r >= 0)
                {
                    double chuVi = 2 * Math.PI * r;
                    // Lấy định dạng hiển thị ( tối đa 5 chữ số thập phân)
                    lblketqua.Text = $"Chu vi hình tròn = {chuVi.ToString("G5")}";
                }
                else
                {
                    MessageBox.Show("Bán kính không được âm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập bán kính là một số hợp lệ!", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndientich_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtbankinh.Text, out double r))
            {
                if (r >= 0)
                {
                    double dienTich = Math.PI * r * r;
                    
                    lblketqua.Text = $"Diện tích hình tròn = {Math.Round(dienTich, 5)}";
                }
                else
                {
                    MessageBox.Show("Bán kính không được âm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập bán kính là một số hợp lệ!", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
