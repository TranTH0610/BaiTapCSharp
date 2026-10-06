using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        // Danh sách lưu các số đã nhập
        private List<int> danhSach = new List<int>();

        public Form1()
        {
            InitializeComponent();

            txtSoNhap.KeyPress += TxtSoNhap_KeyPress;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Chỉ cho phép nhập số nguyên
        private void TxtSoNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép phím Backspace
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            // Cho phép dấu âm ở đầu
            if (e.KeyChar == '-' && txtSoNhap.SelectionStart == 0)
            {
                return;
            }

            // Không cho nhập ký tự khác
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Nút Nhập
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoNhap.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập số nguyên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSoNhap.Focus();
                return;
            }

            if (!int.TryParse(txtSoNhap.Text, out int so))
            {
                MessageBox.Show(
                    "Dữ liệu nhập không hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSoNhap.Focus();
                return;
            }

            // Thêm số vào danh sách
            danhSach.Add(so);

            // Xuất dãy vừa nhập
            txtDayVuaNhap.Text = string.Join(" ", danhSach);

            // Tính tổng
            TinhTong();

            // Xóa ô nhập để nhập số tiếp theo
            txtSoNhap.Clear();
            txtSoNhap.Focus();
        }

        // Tính tổng
        private void TinhTong()
        {
            int tong = 0;
            int tongChan = 0;
            int tongLe = 0;

            foreach (int so in danhSach)
            {
                tong += so;

                if (so % 2 == 0)
                {
                    tongChan += so;
                }
                else
                {
                    tongLe += so;
                }
            }

            txtTong.Text = tong.ToString();
            txtTongChan.Text = tongChan.ToString();
            txtTongLe.Text = tongLe.ToString();
        }

        // Nút Tiếp tục
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            danhSach.Clear();

            txtSoNhap.Clear();
            txtDayVuaNhap.Clear();
            txtTong.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();

            txtSoNhap.Focus();
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát không?",
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