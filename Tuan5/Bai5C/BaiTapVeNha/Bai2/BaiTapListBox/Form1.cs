using System;
using System.Linq;
using System.Windows.Forms;

namespace BaiTapListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Cho phép chọn nhiều phần tử trong ListBox
            lstDanhSach.SelectionMode = SelectionMode.MultiExtended;

            // Gắn sự kiện cho các Button
            btnNhap.Click += btnNhap_Click;
            btnTinhTong.Click += btnTinhTong_Click;
            btnXoaDauCuoi.Click += btnXoaDauCuoi_Click;
            btnXoaDangChon.Click += btnXoaDangChon_Click;
            btnTangLen2.Click += btnTangLen2_Click;
            btnBinhPhuong.Click += btnBinhPhuong_Click;
            btnChonSoChan.Click += btnChonSoChan_Click;
            btnChonSoLe.Click += btnChonSoLe_Click;
            btnKetThuc.Click += btnKetThuc_Click;

            // Chỉ cho nhập chữ số trong TextBox
            txtNhap.KeyPress += txtNhap_KeyPress;
        }

        // ==========================================
        // 1. CHỈ CHO NHẬP SỐ TỰ NHIÊN
        // ==========================================
        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // ==========================================
        // 2. NHẬP SỐ VÀO LISTBOX
        // ==========================================
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNhap.Text.Trim(), out int n) || n < 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập số tự nhiên hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNhap.Focus();
                txtNhap.SelectAll();
                return;
            }

            // Thêm số vừa nhập vào ListBox
            lstDanhSach.Items.Add(n);

            // Xóa TextBox để nhập số tiếp theo
            txtNhap.Clear();
            txtNhap.Focus();
        }

        // ==========================================
        // 3. TÍNH TỔNG CÁC PHẦN TỬ
        // ==========================================
        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống!");
                return;
            }

            long tong = 0;

            foreach (object item in lstDanhSach.Items)
            {
                tong += Convert.ToInt64(item);
            }

            MessageBox.Show(
                "Tổng các phần tử là: " + tong,
                "Kết quả",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ==========================================
        // 4. XÓA PHẦN TỬ ĐẦU VÀ CUỐI
        // ==========================================
        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            int soLuong = lstDanhSach.Items.Count;

            if (soLuong == 0)
            {
                MessageBox.Show("Danh sách đang trống!");
                return;
            }

            // Nếu chỉ có 1 phần tử thì xóa phần tử đó
            if (soLuong == 1)
            {
                lstDanhSach.Items.RemoveAt(0);
                return;
            }

            // Xóa phần tử cuối trước
            lstDanhSach.Items.RemoveAt(soLuong - 1);

            // Xóa phần tử đầu
            lstDanhSach.Items.RemoveAt(0);
        }

        // ==========================================
        // 5. XÓA CÁC PHẦN TỬ ĐANG CHỌN
        // ==========================================
        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndices.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn phần tử cần xóa!");
                return;
            }

            // Lưu vị trí được chọn, sắp xếp giảm dần
            int[] viTriChon = lstDanhSach.SelectedIndices
                .Cast<int>()
                .OrderByDescending(i => i)
                .ToArray();

            // Xóa từ cuối lên đầu tránh lệch vị trí
            foreach (int i in viTriChon)
            {
                lstDanhSach.Items.RemoveAt(i);
            }
        }

        // ==========================================
        // 6. TĂNG GIÁ TRỊ MỖI PHẦN TỬ LÊN 2
        // ==========================================
        private void btnTangLen2_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống!");
                return;
            }

            // Tính trước để tránh thay đổi một phần
            // nếu có giá trị vượt phạm vi long
            long[] ketQua = new long[lstDanhSach.Items.Count];

            try
            {
                for (int i = 0; i < ketQua.Length; i++)
                {
                    long so = Convert.ToInt64(lstDanhSach.Items[i]);
                    ketQua[i] = checked(so + 2);
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Giá trị quá lớn, không thể tăng thêm 2!");
                return;
            }

            for (int i = 0; i < ketQua.Length; i++)
            {
                lstDanhSach.Items[i] = ketQua[i];
            }
        }

        // ==========================================
        // 7. BÌNH PHƯƠNG MỖI PHẦN TỬ
        // ==========================================
        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống!");
                return;
            }

            long[] ketQua = new long[lstDanhSach.Items.Count];

            try
            {
                for (int i = 0; i < ketQua.Length; i++)
                {
                    long so = Convert.ToInt64(lstDanhSach.Items[i]);
                    ketQua[i] = checked(so * so);
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Giá trị quá lớn, không thể bình phương!");
                return;
            }

            for (int i = 0; i < ketQua.Length; i++)
            {
                lstDanhSach.Items[i] = ketQua[i];
            }
        }

        // ==========================================
        // 8. CHỌN CÁC PHẦN TỬ LÀ SỐ CHẴN
        // ==========================================
        private void btnChonSoChan_Click(object sender, EventArgs e)
        {
            // Bỏ chọn tất cả phần tử trước đó
            lstDanhSach.ClearSelected();

            for (int i = 0; i < lstDanhSach.Items.Count; i++)
            {
                long so = Convert.ToInt64(lstDanhSach.Items[i]);

                if (so % 2 == 0)
                {
                    lstDanhSach.SetSelected(i, true);
                }
            }
        }

        // ==========================================
        // 9. CHỌN CÁC PHẦN TỬ LÀ SỐ LẺ
        // ==========================================
        private void btnChonSoLe_Click(object sender, EventArgs e)
        {
            // Bỏ chọn tất cả phần tử trước đó
            lstDanhSach.ClearSelected();

            for (int i = 0; i < lstDanhSach.Items.Count; i++)
            {
                long so = Convert.ToInt64(lstDanhSach.Items[i]);

                if (so % 2 != 0)
                {
                    lstDanhSach.SetSelected(i, true);
                }
            }
        }

        // ==========================================
        // 10. KẾT THÚC CHƯƠNG TRÌNH
        // ==========================================
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn kết thúc chương trình?",
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
