using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BaiTapNangCao
{
    public partial class Form1 : Form
    {
        // Danh sách các ghế đang được chọn
        private List<Button> gheDangChon = new List<Button>();

        // Giá vé
        private const int GIA_LO_A = 1000;
        private const int GIA_LO_B = 1500;
        private const int GIA_LO_C = 2000;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đưa tất cả ghế về trạng thái chưa bán
            KhoiTaoGhe();

            // Thành tiền ban đầu
            txtThanhTien.Text = "0";

            // Gán sự kiện Click cho các ghế
            btn1.Click += Ghe_Click;
            btn2.Click += Ghe_Click;
            btn3.Click += Ghe_Click;
            btn4.Click += Ghe_Click;
            btn5.Click += Ghe_Click;

            btn6.Click += Ghe_Click;
            btn7.Click += Ghe_Click;
            btn8.Click += Ghe_Click;
            btn9.Click += Ghe_Click;
            btn10.Click += Ghe_Click;

            btn11.Click += Ghe_Click;
            btn12.Click += Ghe_Click;
            btn13.Click += Ghe_Click;
            btn14.Click += Ghe_Click;
            btn15.Click += Ghe_Click;
        }

        // Đưa tất cả ghế về màu trắng
        private void KhoiTaoGhe()
        {
            Button[] danhSachGhe =
            {
                btn1, btn2, btn3, btn4, btn5,
                btn6, btn7, btn8, btn9, btn10,
                btn11, btn12, btn13, btn14, btn15
            };

            foreach (Button ghe in danhSachGhe)
            {
                ghe.BackColor = Color.White;
                ghe.ForeColor = Color.Black;
            }
        }

        // Xử lý khi click vào ghế
        private void Ghe_Click(object sender, EventArgs e)
        {
            Button ghe = (Button)sender;

            // Ghế đã bán
            if (ghe.BackColor == Color.Yellow)
            {
                MessageBox.Show(
                    "Ghế " + ghe.Text + " đã được bán!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            // Ghế đang được chọn
            if (ghe.BackColor == Color.Blue)
            {
                ghe.BackColor = Color.White;
                ghe.ForeColor = Color.Black;

                gheDangChon.Remove(ghe);

                return;
            }

            // Ghế chưa bán
            if (ghe.BackColor == Color.White)
            {
                ghe.BackColor = Color.Blue;
                ghe.ForeColor = Color.White;

                gheDangChon.Add(ghe);
            }
        }

        // Nút CHỌN
        private void btnChon_Click(object sender, EventArgs e)
        {
            // Chưa chọn ghế nào
            if (gheDangChon.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn ít nhất một ghế!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int thanhTien = 0;

            // Tính tiền từng ghế
            foreach (Button ghe in gheDangChon)
            {
                int soGhe = int.Parse(ghe.Text);

                // Lô A: ghế 1 -> 5
                if (soGhe >= 1 && soGhe <= 5)
                {
                    thanhTien += GIA_LO_A;
                }
                // Lô B: ghế 6 -> 10
                else if (soGhe >= 6 && soGhe <= 10)
                {
                    thanhTien += GIA_LO_B;
                }
                // Lô C: ghế 11 -> 15
                else if (soGhe >= 11 && soGhe <= 15)
                {
                    thanhTien += GIA_LO_C;
                }

                // Chuyển sang trạng thái đã bán
                ghe.BackColor = Color.Yellow;
                ghe.ForeColor = Color.Black;
            }

            // Hiển thị thành tiền
            txtThanhTien.Text = thanhTien.ToString();

            // Không còn ghế đang chọn
            gheDangChon.Clear();
        }

        // Nút HỦY BỎ
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Đưa các ghế đang chọn về màu trắng
            foreach (Button ghe in gheDangChon)
            {
                ghe.BackColor = Color.White;
                ghe.ForeColor = Color.Black;
            }

            // Xóa danh sách ghế đang chọn
            gheDangChon.Clear();

            // Thành tiền = 0
            txtThanhTien.Text = "0";
        }

        // Nút KẾT THÚC
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn kết thúc chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}