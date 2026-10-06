using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapVeNha
{
    public partial class Form1 : Form
    {
        // Lưu số thứ nhất
        private double so1;

        // Lưu phép toán
        private string phepToan = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            // Các nút số dùng chung một sự kiện
            btn0.Click += So_Click;
            btn1.Click += So_Click;
            btn2.Click += So_Click;
            btn3.Click += So_Click;
            btn4.Click += So_Click;
            btn5.Click += So_Click;
            btn6.Click += So_Click;
            btn7.Click += So_Click;
            btn8.Click += So_Click;
            btn9.Click += So_Click;

            // Các nút phép toán dùng chung một sự kiện
            btnPlus.Click += PhepToan_Click;
            btnMinus.Click += PhepToan_Click;
            btnMultiply.Click += PhepToan_Click;
            btnDivide.Click += PhepToan_Click;

            // Nút bằng và xóa
            btnEqual.Click += btnEqual_Click;
            btnClear.Click += btnClear_Click;
        }

        // =========================
        // KHI BẤM NÚT SỐ
        // =========================
        private void So_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
        }

        // =========================
        // KHI BẤM + - * /
        // =========================
        private void PhepToan_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Lấy số đang hiển thị
            so1 = double.Parse(txtDisplay.Text);

            // Lưu phép toán
            phepToan = btn.Text;

            // Xóa màn hình để nhập số thứ hai
            txtDisplay.Text = "0";
        }

        // =========================
        // KHI BẤM =
        // =========================
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double so2 = double.Parse(txtDisplay.Text);
            double ketQua = 0;

            switch (phepToan)
            {
                case "+":
                    ketQua = so1 + so2;
                    break;

                case "-":
                    ketQua = so1 - so2;
                    break;

                case "*":
                    ketQua = so1 * so2;
                    break;

                case "/":
                    if (so2 == 0)
                    {
                        MessageBox.Show(
                            "Không thể chia cho 0!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }

                    ketQua = so1 / so2;
                    break;
            }

            txtDisplay.Text = ketQua.ToString();
        }

        // =========================
        // NÚT C - XÓA
        // =========================
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            so1 = 0;
            phepToan = "";
        }
    }
}
