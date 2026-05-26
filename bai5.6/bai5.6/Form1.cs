using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5._6
{
    public partial class Form1 : Form
    {
        // Khởi tạo các biến quản lý trạng thái game
        int pipeSpeed = 8;      // Tốc độ di chuyển của ống cống
        int gravity = 5;        // Lực hút kéo chim rơi xuống
        int score = 0;          // Điểm số ban đầu
        bool gameOver = false;  // Trạng thái kết thúc game
        public Form1()
        {
            InitializeComponent();
            // Bật thuộc tính KeyPreview để Form nhận được sự kiện phím trước các control khác
            this.KeyPreview = true;

            // Bắt đầu chạy Timer khi mở game
            gametime.Start();
        }
        // Hàm xử lý khi thua
        private void EndGame()
        {
            gametime.Stop(); // Dừng bộ đếm thời gian (game đóng băng)
            gameOver = true;
            lbscore.Text += " Game over! Press R to restart.";
        }
        // Hàm reset game để chơi lại
        private void RestartGame()
        {
            gameOver = false;
            picBird.Top = 150;        // Đưa chim về vị trí ban đầu
            picPipedown.Left = 500; // Đưa ống về vị trí ban đầu
            score = 0;
            gravity = 5;
            lbscore.Text = "Score: 0";
            gametime.Start();        // Chạy lại timer
        }
        // Sự kiện xảy ra sau mỗi vòng lặp của Timer (mỗi 20ms)
        private void gametime_Tick(object sender, EventArgs e)
        {
            // 1. Cho chim rơi xuống liên tục theo trọng lực
            picBird.Top += gravity;

            // 2. Di chuyển ống cống sang bên trái
            picPipedown.Left -= pipeSpeed;
            picPipe.Left -= pipeSpeed;

            // 3. Hiển thị điểm số hiện tại
            lbscore.Text = "Score: " + score;

            // 4. Nếu ống cống chạy khuất màn hình bên trái, reset nó về bên phải để tạo vòng lặp
            if (picPipedown.Left < -50)
            {
                picPipedown.Left = 500; // Đẩy ống về lại bên phải ngoài màn hình
                score++;                  // Người chơi vượt qua và cộng 1 điểm
            }
            if (picPipe.Left < -50)
            {
                picPipe.Left = 500; // Đẩy ống về lại bên phải ngoài màn hình
                score++;                  // Người chơi vượt qua và cộng 1 điểm
            }

            // 5. Kiểm tra va chạm (Thua cuộc)
            // Chim chạm vào ống cống HOẶC chạm mặt đất HOẶC bay quá biên trên
            if (picBird.Bounds.IntersectsWith(picPipedown.Bounds) ||
                picBird.Bounds.IntersectsWith(picGround.Bounds) ||
                picBird.Bounds.IntersectsWith(picPipe.Bounds)||
                picBird.Top < 0)
            {
                EndGame();
            }
        }
        // Sự kiện khi người chơi NHẤN phím (Spacebar để nhảy)
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Nếu bấm phím Space (Dấu cách) thì đổi hướng trọng lực để chim bay lên
            if (e.KeyCode == Keys.Space && !gameOver)
            {
                gravity = -10; // Lực nhảy lên
            }
        }
        // Sự kiện khi người chơi THẢ phím ra
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // Khi thả phím Space ra thì chim lại bị rơi xuống tiếp
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5; // Trả lại lực rơi xuống
            }

            // Nếu game đã over, bấm R để chơi lại từ đầu
            if (e.KeyCode == Keys.R && gameOver)
            {
                RestartGame();
            }
        }
    }
}
