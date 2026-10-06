using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
   public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSo.Focus();
        }

        // Button Thực hiện
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            // Kiểm tra có nhập hay chưa
            if (string.IsNullOrWhiteSpace(txtSo.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập một số!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSo.Focus();
                return;
            }

            // Chuyển dữ liệu sang số nguyên
            if (!int.TryParse(txtSo.Text, out int so))
            {
                MessageBox.Show(
                    "Vui lòng nhập số nguyên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSo.Focus();
                return;
            }

            // Kiểm tra khoảng từ 1 đến 999
            if (so < 1 || so > 999)
            {
                MessageBox.Show(
                    "Vui lòng nhập số từ 1 đến 999!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSo.Focus();
                return;
            }

            // Đọc số thành chữ
            txtKetQua.Text = DocSo(so);
        }

        // Hàm đọc số
        private string DocSo(int so)
        {
            string[] donVi =
            {
                "Không",
                "Một",
                "Hai",
                "Ba",
                "Bốn",
                "Năm",
                "Sáu",
                "Bảy",
                "Tám",
                "Chín"
            };

            int tram = so / 100;
            int chuc = (so % 100) / 10;
            int donViSo = so % 10;

            string ketQua = "";

            // Số có hàng trăm
            if (tram > 0)
            {
                ketQua += donVi[tram] + " trăm";

                if (chuc == 0 && donViSo > 0)
                {
                    ketQua += " lẻ";
                }
            }

            // Hàng chục
            if (chuc > 0)
            {
                if (ketQua != "")
                {
                    ketQua += " ";
                }

                if (chuc == 1)
                {
                    ketQua += "mười";
                }
                else
                {
                    ketQua += donVi[chuc] + " mươi";
                }
            }

            // Hàng đơn vị
            if (donViSo > 0)
            {
                if (ketQua != "")
                {
                    ketQua += " ";
                }

                if (chuc >= 2 && donViSo == 1)
                {
                    ketQua += "mốt";
                }
                else if (chuc >= 1 && donViSo == 5)
                {
                    ketQua += "lăm";
                }
                else
                {
                    ketQua += donVi[donViSo];
                }
            }

            return ketQua;
        }

        // Button Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSo.Clear();
            txtKetQua.Clear();

            txtSo.Focus();
        }

        // Button Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
