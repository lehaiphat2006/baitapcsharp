using bai5._5 ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5._5
{
    
        public partial class Form1 : Form
        {
        private List<HinhHoc> dsHinh = new List<HinhHoc>();

        private HinhHoc hinhHienTai = null; // Hình đang vẽ dở khi rê chuột
        private bool dangVe = false;
        public Form1()
            {
                InitializeComponent();
            }

        // 1. Khi nhấn chuột xuống: Bắt đầu tạo đối tượng hình
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dangVe = true;

            // Đa hình: Khởi tạo lớp con dựa trên nút Radio được chọn
            if (rbrectangle.Checked)
                hinhHienTai = new HinhChuNhat();
            else
                hinhHienTai = new HinhElip();

            hinhHienTai.DiemDau = e.Location;
            hinhHienTai.DiemCuoi = e.Location;
        }
        // 2. Khi rê chuột: Cập nhật liên tục điểm kết thúc để tạo hiệu ứng kéo giãn hình
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dangVe && hinhHienTai != null)
            {
                hinhHienTai.DiemCuoi = e.Location;
                this.Invalidate(); // Ép Form gọi lại sự kiện Paint để vẽ lại liên tục
            }
        }
        // 3. Khi thả chuột ra: Hoàn thành hình và đưa vào danh sách quản lý
        private void Form1_MouseUp(object sender, MouseEventArgs e)
            {
            if (dangVe && hinhHienTai != null)
            {
                hinhHienTai.DiemCuoi = e.Location;
                dsHinh.Add(hinhHienTai);

                dangVe = false;
                hinhHienTai = null;

                this.Invalidate(); // Vẽ lại để cập nhật hình mới và tìm hình lớn nhất để tô màu
            }
        }

        // 4. Sự kiện Paint của Form: Nơi trực tiếp hiển thị nét vẽ lên màn hình
        private void Form1_Paint(object sender, PaintEventArgs e)
            {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Giúp nét vẽ mịn hơn

            // Bút vẽ viền chung
            Pen penXanh = new Pen(Color.Blue, 2);
            Pen penDo = new Pen(Color.Red, 2);
            // Cọ tô màu vàng nhạt cho hình có diện tích lớn nhất
            Brush brushToMau = new SolidBrush(Color.FromArgb(100, Color.Yellow));

            
            // Tìm hình có diện tích lớn nhất trong danh sách
            HinhHoc hinhMax = null;
            double maxS = -1;
            foreach (var h in dsHinh)
            {
                if (h.TinhDienTich() > maxS)
                {
                    maxS = h.TinhDienTich();
                    hinhMax = h;
                }
            }

            // Vẽ lại toàn bộ các hình đã lưu trong danh sách
            foreach (var h in dsHinh)
            {
                // Nếu là HinhChuNhat thì dùng bút đỏ, HinhElip dùng bút xanh 
                Pen penChon = (h is HinhChuNhat) ? penDo : penXanh;

                // Kiểm tra xem hình này có phải là hình có diện tích lớn nhất không
                bool laMax = (h == hinhMax);

                // Gọi hàm vẽ đa hình (tự động nhận biết vẽ chữ nhật hay elip)
                h.Ve(g, penChon, brushToMau, laMax);
            }

            // Vẽ cái hình đang trong quá trình rê chuột (nếu có)
            if (hinhHienTai != null)
            {
                Pen penPreview = (hinhHienTai is HinhChuNhat) ? penDo : penXanh;
                hinhHienTai.Ve(g, penPreview, brushToMau, false);
            }
        }
    

 }


    public abstract class HinhHoc
    {
        public Point DiemDau { get; set; }
        public Point DiemCuoi { get; set; }


        protected Rectangle LayKhungVe()
        {
            int x = Math.Min(DiemDau.X, DiemCuoi.X);
            int y = Math.Min(DiemDau.Y, DiemCuoi.Y);
            int w = Math.Abs(DiemDau.X - DiemCuoi.X);
            int h = Math.Abs(DiemDau.Y - DiemCuoi.Y);
            return new Rectangle(x, y, w, h);
        }

        // Định nghĩa 2 hàm trừu tượng để lớp con bắt buộc phải tự xử lý độc lập
        public abstract double TinhDienTich();
        public abstract void Ve(Graphics g, Pen p, Brush b, bool laHinhLonNhat);
    }

    // Lớp con: Hình Chữ Nhật
    public class HinhChuNhat : HinhHoc
    {
        public override double TinhDienTich()
        {
            Rectangle r = LayKhungVe();
            return r.Width * r.Height;
        }

        public override void Ve(Graphics g, Pen p, Brush b, bool laHinhLonNhat)
        {
            Rectangle r = LayKhungVe();
            if (laHinhLonNhat)
                g.FillRectangle(b, r); // Tô màu nền nếu diện tích lớn nhất
            g.DrawRectangle(p, r);     // Vẽ viền nét ngoài
        }
    }

    // Lớp con: Hình Elip
    public class HinhElip : HinhHoc
    {
        public override double TinhDienTich()
        {
            Rectangle r = LayKhungVe();
            // Công thức diện tích Elip: 
            return Math.PI * (r.Width / 2.0) * (r.Height / 2.0);
        }

        public override void Ve(Graphics g, Pen p, Brush b, bool laHinhLonNhat)
        {
            Rectangle r = LayKhungVe();
            if (laHinhLonNhat)
                g.FillEllipse(b, r); // Tô màu nền nếu diện tích lớn nhất
            g.DrawEllipse(p, r);     // Vẽ viền nét ngoài
        }
    }

}

