using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DangKiTaiKhoan
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
               " Bạn có chắc chắn muốn đóng Form không?", "Xác nhận",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemtraDuLieu())
            {
                return;
            }
            string thongTin =
        "TÊN ĐĂNG NHẬP: " + TenDangNhap.Text + "\n" +
        "EMAIL: " + email.Text + "\n" +
        "MẬT KHẨU: " + MatKhau.Text + "\n" +
        "XÁC NHẬN MẬT KHẨU: " + XacNhanMatKhau.Text + "\n";

            MessageBox.Show(thongTin,
                "Thông tin đăng ký",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        private bool KiemtraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(TenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập!");
                TenDangNhap.Focus();
                return false;
            }
            string mail = email.Text.Trim();
            if (!mail.Contains("@") || !mail.Contains("."))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ! Email phải chứa ký tự '@' và dấu '.'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                email.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(MatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MatKhau.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(XacNhanMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập xác nhận mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                XacNhanMatKhau.Focus();
                return false;
            }
            if (MatKhau.Text != XacNhanMatKhau.Text)
            {
                MessageBox.Show(
                    "Mật khẩu và xác nhận mật khẩu không khớp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                XacNhanMatKhau.Focus();
                return false;
            }

            return true;

        }

        private void XacNhanMatKhau_Click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnDangKy.PerformClick();
            }
        }

        private void TenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_Leave(object sender, EventArgs e)
        {
            string mail = email.Text.Trim();
            if (mail == "")
            {
                return; // Nếu để trống thì bỏ qua lúc rời ô, để hàm KiemtraDuLieu() lo khi bấm nút
            }

            if (!mail.Contains("@") || !mail.Contains("."))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ! Email phải chứa ký tự '@' và dấu '.'",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                email.Focus();
            }
        }
        private void XacNhanMatKhau_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnDangKy.PerformClick();
            }
        }
        private void MatKhau_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
