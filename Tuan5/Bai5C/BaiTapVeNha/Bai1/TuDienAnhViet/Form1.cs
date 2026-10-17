
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TuDienAnhViet
{
    public partial class Form1 : Form
    {
        // Danh sách từ điển Anh - Việt
        private List<KeyValuePair<string, string>> tuDienAnhViet =
            new List<KeyValuePair<string, string>>();

        // Danh sách từ điển Việt - Anh
        private List<KeyValuePair<string, string>> tuDienVietAnh =
            new List<KeyValuePair<string, string>>();

        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện đúng một lần
            txtTiengAnh.TextChanged += txtTiengAnh_TextChanged;
            txtTuTiengViet.TextChanged += txtTuTiengViet_TextChanged;

            txtTiengAnh.KeyDown += txtTiengAnh_KeyDown;
            txtTuTiengViet.KeyDown += txtTuTiengViet_KeyDown;

            lstTiengAnh.DoubleClick += lstTiengAnh_DoubleClick;
            lstTuTiengViet.DoubleClick += lstTuTiengViet_DoubleClick;

            lstTiengAnh.KeyDown += lstTiengAnh_KeyDown;
            lstTuTiengViet.KeyDown += lstTuTiengViet_KeyDown;

            btnThoat.Click += btnThoat_Click;

            // Khởi tạo danh sách từ
            KhoiTaoTuDien();
            HienThiDanhSach();

            txtNghiaTiengViet.ReadOnly = true;
            txtNghiaTiengAnh.ReadOnly = true;
        }

        // ==========================================
        // 1. KHỞI TẠO DANH SÁCH TỪ ĐIỂN
        // ==========================================
        private void KhoiTaoTuDien()
        {
            ThemTu("student", "học sinh");
            ThemTu("teacher", "giáo viên");
            ThemTu("worker", "công nhân");
            ThemTu("hat", "mũ");
            ThemTu("head", "đầu");
            ThemTu("mouse", "chuột");
            ThemTu("cat", "mèo");
            ThemTu("dog", "chó");
            ThemTu("snake", "rắn");
            ThemTu("lamb", "cừu non");

            // Có thể bổ sung từ mới tại đây
            ThemTu("apple", "quả táo");
            ThemTu("book", "quyển sách");
            ThemTu("computer", "máy tính");
            ThemTu("school", "trường học");
            ThemTu("house", "ngôi nhà");
            ThemTu("water", "nước");
            ThemTu("flower", "hoa");
            ThemTu("friend", "bạn bè");
            ThemTu("family", "gia đình");
            ThemTu("table", "cái bàn");
        }

        // Thêm một cặp từ vào cả hai danh sách
        private void ThemTu(string tiengAnh, string tiengViet)
        {
            tuDienAnhViet.Add(
                new KeyValuePair<string, string>(
                    tiengAnh, tiengViet));

            tuDienVietAnh.Add(
                new KeyValuePair<string, string>(
                    tiengViet, tiengAnh));
        }

        // ==========================================
        // 2. HIỂN THỊ DANH SÁCH TỪ
        // ==========================================
        private void HienThiDanhSach()
        {
            lstTiengAnh.Items.Clear();
            lstTuTiengViet.Items.Clear();

            foreach (var tu in tuDienAnhViet
                .OrderBy(x => x.Key))
            {
                lstTiengAnh.Items.Add(tu.Key);
            }

            foreach (var tu in tuDienVietAnh
                .OrderBy(x => x.Key))
            {
                lstTuTiengViet.Items.Add(tu.Key);
            }
        }

        // ==========================================
        // 3. TÌM TỪ GẦN KHỚP KHI ĐANG NHẬP
        // ==========================================
        private void txtTiengAnh_TextChanged(
            object sender, EventArgs e)
        {
            TimTuGanDung(txtTiengAnh, lstTiengAnh);
            txtNghiaTiengViet.Clear();
        }

        private void txtTuTiengViet_TextChanged(
            object sender, EventArgs e)
        {
            TimTuGanDung(txtTuTiengViet, lstTuTiengViet);
            txtNghiaTiengAnh.Clear();
        }

        private void TimTuGanDung(TextBox txt, ListBox lst)
        {
            string tuCanTim = txt.Text.Trim();

            if (tuCanTim == "")
            {
                lst.ClearSelected();
                return;
            }

            // Tìm từ đầu tiên bắt đầu bằng ký tự đã nhập
            int viTri = lst.FindString(tuCanTim);

            if (viTri >= 0)
            {
                lst.SelectedIndex = viTri;
                lst.TopIndex = viTri;
            }
            else
            {
                // Không tìm thấy từ bắt đầu bằng chuỗi nhập
                lst.ClearSelected();
            }
        }

        // ==========================================
        // 4. TRA TỪ ANH - VIỆT
        // ==========================================
        private void TraTuAnhViet()
        {
            if (lstTiengAnh.SelectedItem == null)
            {
                MessageBox.Show(
                    "Không tìm thấy từ tiếng Anh phù hợp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string tu = lstTiengAnh.SelectedItem.ToString();

            var ketQua = tuDienAnhViet.FirstOrDefault(
                x => string.Equals(
                    x.Key, tu,
                    StringComparison.OrdinalIgnoreCase));

            txtTiengAnh.Text = tu;
            txtNghiaTiengViet.Text = ketQua.Value;
        }

        // ==========================================
        // 5. TRA TỪ VIỆT - ANH
        // ==========================================
        private void TraTuVietAnh()
        {
            if (lstTuTiengViet.SelectedItem == null)
            {
                MessageBox.Show(
                    "Không tìm thấy từ tiếng Việt phù hợp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string tu = lstTuTiengViet.SelectedItem.ToString();

            var ketQua = tuDienVietAnh.FirstOrDefault(
                x => string.Equals(
                    x.Key, tu,
                    StringComparison.OrdinalIgnoreCase));

            txtTuTiengViet.Text = tu;
            txtNghiaTiengAnh.Text = ketQua.Value;
        }

        // ==========================================
        // 6. NHẤN ENTER ĐỂ TRA TỪ
        // ==========================================
        private void txtTiengAnh_KeyDown(
            object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TraTuAnhViet();
            }
        }

        private void txtTuTiengViet_KeyDown(
            object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TraTuVietAnh();
            }
        }

        private void lstTiengAnh_KeyDown(
            object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TraTuAnhViet();
            }
        }

        private void lstTuTiengViet_KeyDown(
            object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TraTuVietAnh();
            }
        }

        // ==========================================
        // 7. DOUBLE CLICK VÀO TỪ ĐỂ TRA
        // ==========================================
        private void lstTiengAnh_DoubleClick(
            object sender, EventArgs e)
        {
            TraTuAnhViet();
        }

        private void lstTuTiengViet_DoubleClick(
            object sender, EventArgs e)
        {
            TraTuVietAnh();
        }

        // ==========================================
        // 8. THOÁT CHƯƠNG TRÌNH
        // ==========================================
        private void btnThoat_Click(
            object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
