using System;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtA.KeyPress += TxtSo_KeyPress;
            txtB.KeyPress += TxtSo_KeyPress;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUSCLN.ReadOnly = true;
            txtBSCNN.ReadOnly = true;
        }
        private void TxtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Tìm UCLN
        private int TimUCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        // Kiểm tra dữ liệu nhập
        private bool KiemTraDuLieu(out int a, out int b)
        {
            a = 0;
            b = 0;

            // Kiểm tra A có rỗng không
            if (string.IsNullOrWhiteSpace(txtA.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập số a!",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtA.Focus();
                return false;
            }

            // Kiểm tra B có rỗng không
            if (string.IsNullOrWhiteSpace(txtB.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập số b!",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtB.Focus();
                return false;
            }

            // Chuyển A sang số nguyên
            if (!int.TryParse(txtA.Text, out a))
            {
                MessageBox.Show(
                    "Số a không hợp lệ!",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtA.Focus();
                return false;
            }

            // Chuyển B sang số nguyên
            if (!int.TryParse(txtB.Text, out b))
            {
                MessageBox.Show(
                    "Số b không hợp lệ!",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtB.Focus();
                return false;
            }

            // A và B phải lớn hơn 0
            if (a <= 0 || b <= 0)
            {
                MessageBox.Show(
                    "a và b phải là số nguyên dương!",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            return true;
        }

        // Nút Thực Hiện
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu(out int a, out int b))
            {
                return;
            }

            // Tính UCLN
            int ucln = TimUCLN(a, b);

            // Tính BCNN
            int bcnn = (a / ucln) * b;

            // Xuất kết quả
            txtUSCLN.Text = ucln.ToString();
            txtBSCNN.Text = bcnn.ToString();
        }

        // Nút Tiếp Tục
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtUSCLN.Clear();
            txtBSCNN.Clear();

            txtA.Focus();
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
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
