using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            // Thiết lập bộ lọc chỉ hiển thị các định dạng file ảnh
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            // Thiết lập tiêu đề cho hộp thoại
            openFileDialog1.Title = "Chọn hình ảnh để hiển thị";

            // Hiển thị hộp thoại chọn file, nếu người dùng chọn file và bấm OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file vừa chọn và nạp vào PictureBox
                pichinhanh.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
