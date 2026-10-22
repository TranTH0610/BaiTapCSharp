
using System;
using System.Windows.Forms;

namespace DongHoDemNguoc
{
    public partial class Form1 : Form
    {
        // Thời gian ban đầu: 30 phút = 1800 giây
        private int thoiGianConLai = 30 * 60;

        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện cho Button và Timer
            btnBatDau.Click += btnBatDau_Click;
            timer1.Tick += timer1_Tick;

            // Timer chạy mỗi 1 giây
            timer1.Interval = 1000;

            // Hiển thị thời gian ban đầu
            HienThiThoiGian();
        }

        // ========================================
        // 1. HIỂN THỊ THỜI GIAN
        // ========================================
        private void HienThiThoiGian()
        {
            int phut = thoiGianConLai / 60;
            int giay = thoiGianConLai % 60;

            lblThoiGian.Text =
                phut.ToString("00") + ":" +
                giay.ToString("00");
        }

        // ========================================
        // 2. NHẤN NÚT BẮT ĐẦU
        // ========================================
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            // Đặt lại thời gian về 30 phút
            thoiGianConLai = 30 * 60;

            // Hiển thị 30:00
            HienThiThoiGian();

            // Bắt đầu đếm ngược
            timer1.Start();

            // Không cho nhấn Bắt đầu nhiều lần
            btnBatDau.Enabled = false;
        }

        // ========================================
        // 3. SỰ KIỆN TIMER MỖI GIÂY
        // ========================================
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Nếu thời gian vẫn còn
            if (thoiGianConLai > 0)
            {
                // Giảm 1 giây
                thoiGianConLai--;

                // Cập nhật thời gian trên Label
                HienThiThoiGian();
            }

            // Khi đếm ngược về 00:00
            if (thoiGianConLai == 0)
            {
                // Dừng Timer
                timer1.Stop();

                // Cho phép bắt đầu lại
                btnBatDau.Enabled = true;

                MessageBox.Show(
                    "Đã hết thời gian!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
