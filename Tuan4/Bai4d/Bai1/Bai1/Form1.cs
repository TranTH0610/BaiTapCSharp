using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
     public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện cho RadioButton
            rdoBacNhat.CheckedChanged += RadioButton_CheckedChanged;
            rdoBacHai.CheckedChanged += RadioButton_CheckedChanged;

            // Gắn sự kiện khi nhập dữ liệu
            txtA.TextChanged += TextBox_TextChanged;
            txtB.TextChanged += TextBox_TextChanged;
            txtC.TextChanged += TextBox_TextChanged;

            // Gắn sự kiện cho Button
            btnGiai.Click += btnGiai_Click;
            btnThoat.Click += btnThoat_Click;

            // Trạng thái ban đầu
            btnGiai.Enabled = false;

            txtC.Enabled = false;
            lblC.ForeColor = Color.Gray;
        }

        // Khi chọn RadioButton
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBacNhat.Checked)
            {
                // Bậc nhất không cần nhập c
                txtC.Enabled = false;
                txtC.Clear();

                lblC.ForeColor = Color.Gray;
            }
            else if (rdoBacHai.Checked)
            {
                // Bậc hai cần nhập c
                txtC.Enabled = true;

                lblC.ForeColor = Color.Black;
            }

            KiemTraDuLieu();
        }

        // Khi nhập dữ liệu vào TextBox
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        // Kiểm tra dữ liệu để bật/tắt nút Giải
        private void KiemTraDuLieu()
        {
            bool hopLeA = double.TryParse(txtA.Text.Trim(), out _);
            bool hopLeB = double.TryParse(txtB.Text.Trim(), out _);

            if (rdoBacNhat.Checked)
            {
                // Bậc nhất chỉ cần a và b
                btnGiai.Enabled = hopLeA && hopLeB;
            }
            else
            {
                // Bậc hai cần a, b và c
                bool hopLeC = double.TryParse(txtC.Text.Trim(), out _);

                btnGiai.Enabled = hopLeA && hopLeB && hopLeC;
            }
        }

        // Nút Giải
        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double c = 0;

            // Kiểm tra a
            if (!double.TryParse(txtA.Text.Trim(), out a))
            {
                MessageBox.Show(
                    "Vui lòng nhập số hợp lệ cho a!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtA.Focus();
                return;
            }

            // Kiểm tra b
            if (!double.TryParse(txtB.Text.Trim(), out b))
            {
                MessageBox.Show(
                    "Vui lòng nhập số hợp lệ cho b!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtB.Focus();
                return;
            }

            // Nếu chọn bậc hai thì kiểm tra c
            if (rdoBacHai.Checked)
            {
                if (!double.TryParse(txtC.Text.Trim(), out c))
                {
                    MessageBox.Show(
                        "Vui lòng nhập số hợp lệ cho c!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtC.Focus();
                    return;
                }
            }

            // Tạo đối tượng PhuongTrinhBacHai
            GiaiPhuongTrinhBac2 pt =
                new GiaiPhuongTrinhBac2(a, b, c);

            // Giải phương trình
            if (rdoBacNhat.Checked)
            {
                txtKetQua.Text = pt.GiaiBacNhat();
            }
            else
            {
                txtKetQua.Text = pt.GiaiBacHai();
            }
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Xác nhận khi đóng Form bằng nút X
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đóng chương trình không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

            base.OnFormClosing(e);
        }
    }
}
