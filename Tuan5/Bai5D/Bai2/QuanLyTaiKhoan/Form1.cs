
using System;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyTaiKhoan
{
    public partial class Form1 : Form
    {
        // Kiểm tra chương trình có đang ở chế độ thêm không
        private bool dangThem = false;

        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện cho Form
            Load += Form1_Load;

            // Gắn sự kiện cho các nút
            btnThem.Click += btnThem_Click;
            btnLuu.Click += btnLuu_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;

            // Sự kiện chọn một tài khoản trong bảng
            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;

            // Khi bỏ chọn dòng thì cập nhật trạng thái nút Xóa
            dgvTaiKhoan.SelectionChanged +=
                dgvTaiKhoan_SelectionChanged;
        }

        // ==========================================
        // 1. FORM LOAD
        // ==========================================
        private void Form1_Load(object sender, EventArgs e)
        {
            // Chế độ ban đầu
            dangThem = false;

            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;

            // Không cho chỉnh sửa trực tiếp trên bảng
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;

            dgvTaiKhoan.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvTaiKhoan.MultiSelect = false;

            // Chỉ hiển thị tổng tiền
            txtTongTien.ReadOnly = true;

            XoaTrangTextBox();
            KhoaTextBox(true);

            dgvTaiKhoan.ClearSelection();

            TinhTongTien();
        }

        // ==========================================
        // 2. XÓA TRẮNG CÁC TEXTBOX
        // ==========================================
        private void XoaTrangTextBox()
        {
            txtSoTaiKhoan.Clear();
            txtTenKhachHang.Clear();
            txtDiaChiKhachHang.Clear();
            txtSoTien.Clear();
        }

        // ==========================================
        // 3. BẬT / TẮT NHẬP DỮ LIỆU
        // ==========================================
        private void KhoaTextBox(bool khoa)
        {
            txtSoTaiKhoan.ReadOnly = khoa;
            txtTenKhachHang.ReadOnly = khoa;
            txtDiaChiKhachHang.ReadOnly = khoa;
            txtSoTien.ReadOnly = khoa;
        }

        // ==========================================
        // 4. NÚT THÊM / HỦY
        // ==========================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Nếu chưa ở chế độ thêm
            if (!dangThem)
            {
                dangThem = true;

                // Nút Thêm chuyển thành Hủy
                btnThem.Text = "Hủy";

                // Cho phép lưu
                btnLuu.Enabled = true;

                // Không cho xóa khi đang thêm
                btnXoa.Enabled = false;

                // Xóa trắng dữ liệu nhập
                XoaTrangTextBox();

                // Cho phép nhập dữ liệu
                KhoaTextBox(false);

                // Bỏ chọn dòng trong bảng
                dgvTaiKhoan.ClearSelection();

                // Đặt con trỏ vào số tài khoản
                txtSoTaiKhoan.Focus();
            }
            else
            {
                // Nếu đang thêm thì nút Hủy
                // dùng để hủy quá trình thêm
                HuyThem();
            }
        }

        // ==========================================
        // 5. HỦY THÊM TÀI KHOẢN
        // ==========================================
        private void HuyThem()
        {
            dangThem = false;

            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;

            XoaTrangTextBox();
            KhoaTextBox(true);

            dgvTaiKhoan.ClearSelection();
        }

        // ==========================================
        // 6. KIỂM TRA DỮ LIỆU TRƯỚC KHI LƯU
        // ==========================================
        private bool KiemTraDuLieu(out decimal soTien)
        {
            soTien = 0;

            // Kiểm tra số tài khoản
            if (string.IsNullOrWhiteSpace(txtSoTaiKhoan.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập số tài khoản!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSoTaiKhoan.Focus();
                return false;
            }

            // Kiểm tra tên khách hàng
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên khách hàng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenKhachHang.Focus();
                return false;
            }

            // Kiểm tra địa chỉ
            if (string.IsNullOrWhiteSpace(txtDiaChiKhachHang.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập địa chỉ khách hàng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDiaChiKhachHang.Focus();
                return false;
            }

            // Kiểm tra số tiền
            if (string.IsNullOrWhiteSpace(txtSoTien.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập số tiền trong tài khoản!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSoTien.Focus();
                return false;
            }

            // Chấp nhận số thập phân dùng dấu phẩy hoặc dấu chấm
            string giaTri =
                txtSoTien.Text.Trim().Replace(',', '.');

            if (!decimal.TryParse(
                giaTri,
                NumberStyles.AllowLeadingSign |
                NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture,
                out soTien))
            {
                MessageBox.Show(
                    "Số tiền phải là số hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSoTien.Focus();
                txtSoTien.SelectAll();
                return false;
            }

            // Số tiền không được âm
            if (soTien < 0)
            {
                MessageBox.Show(
                    "Số tiền không được nhỏ hơn 0!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSoTien.Focus();
                txtSoTien.SelectAll();
                return false;
            }

            return true;
        }

        // ==========================================
        // 7. KIỂM TRA TRÙNG SỐ TÀI KHOẢN
        // ==========================================
        private bool KiemTraTrungSoTaiKhoan(string soTK)
        {
            foreach (DataGridViewRow row in dgvTaiKhoan.Rows)
            {
                string soTaiKhoanTrongBang =
                    Convert.ToString(
                        row.Cells["colSoTaiKhoan"].Value);

                if (string.Equals(
                    soTaiKhoanTrongBang,
                    soTK,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        // ==========================================
        // 8. NÚT LƯU
        // ==========================================
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Chỉ được lưu khi đang ở chế độ thêm
            if (!dangThem)
            {
                return;
            }

            // Kiểm tra dữ liệu
            if (!KiemTraDuLieu(out decimal soTien))
            {
                return;
            }

            string soTK = txtSoTaiKhoan.Text.Trim();
            string tenKH = txtTenKhachHang.Text.Trim();
            string diaChi = txtDiaChiKhachHang.Text.Trim();

            // Kiểm tra số tài khoản trùng
            if (KiemTraTrungSoTaiKhoan(soTK))
            {
                MessageBox.Show(
                    "Số tài khoản " + soTK +
                    " đã tồn tại!\nVui lòng nhập số khác.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSoTaiKhoan.Focus();
                txtSoTaiKhoan.SelectAll();
                return;
            }

            // Thêm một dòng mới vào DataGridView
            dgvTaiKhoan.Rows.Add(
                dgvTaiKhoan.Rows.Count + 1,
                soTK,
                tenKH,
                diaChi,
                soTien
            );

            // Đánh lại STT
            CapNhatSTT();

            // Tính lại tổng tiền
            TinhTongTien();

            MessageBox.Show(
                "Lưu tài khoản thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Trở về trạng thái ban đầu
            HuyThem();
        }

        // ==========================================
        // 9. CHỌN MỘT KHÁCH HÀNG TRONG BẢNG
        // ==========================================
        private void dgvTaiKhoan_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (dangThem || e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvTaiKhoan.Rows[e.RowIndex];

            // Hiển thị thông tin lên các TextBox
            txtSoTaiKhoan.Text =
                Convert.ToString(
                    row.Cells["colSoTaiKhoan"].Value);

            txtTenKhachHang.Text =
                Convert.ToString(
                    row.Cells["colTenKhachHang"].Value);

            txtDiaChiKhachHang.Text =
                Convert.ToString(
                    row.Cells["colDiaChi"].Value);

            decimal soTien =
                Convert.ToDecimal(
                    row.Cells["colSoTien"].Value);

            txtSoTien.Text =
                soTien.ToString(
                    "0.##",
                    CultureInfo.GetCultureInfo("vi-VN"));

            btnXoa.Enabled = true;
        }

        // ==========================================
        // 10. CẬP NHẬT TRẠNG THÁI NÚT XÓA
        // ==========================================
        private void dgvTaiKhoan_SelectionChanged(
            object sender, EventArgs e)
        {
            if (dangThem)
            {
                btnXoa.Enabled = false;
                return;
            }

            btnXoa.Enabled =
                dgvTaiKhoan.SelectedRows.Count > 0;
        }

        // ==========================================
        // 11. NÚT XÓA
        // ==========================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dangThem)
            {
                return;
            }

            if (dgvTaiKhoan.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn tài khoản cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow row =
                dgvTaiKhoan.SelectedRows[0];

            string soTK =
                Convert.ToString(
                    row.Cells["colSoTaiKhoan"].Value);

            // Hỏi xác nhận xóa
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa tài khoản " +
                soTK + " không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            // Xóa dòng hiện hành
            dgvTaiKhoan.Rows.Remove(row);

            // Đánh lại STT
            CapNhatSTT();

            // Cập nhật tổng tiền
            TinhTongTien();

            // Xóa thông tin trên TextBox
            XoaTrangTextBox();

            // Bỏ chọn dòng
            dgvTaiKhoan.ClearSelection();

            btnXoa.Enabled = false;

            MessageBox.Show(
                "Xóa tài khoản thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ==========================================
        // 12. TỰ ĐỘNG ĐÁNH SỐ THỨ TỰ
        // ==========================================
        private void CapNhatSTT()
        {
            for (int i = 0; i < dgvTaiKhoan.Rows.Count; i++)
            {
                dgvTaiKhoan.Rows[i]
                    .Cells["colSTT"].Value = i + 1;
            }
        }

        // ==========================================
        // 13. TÍNH TỔNG TIỀN
        // ==========================================
        private void TinhTongTien()
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dgvTaiKhoan.Rows)
            {
                object giaTri =
                    row.Cells["colSoTien"].Value;

                if (giaTri != null &&
                    giaTri != DBNull.Value)
                {
                    tongTien += Convert.ToDecimal(giaTri);
                }
            }

            txtTongTien.Text =
                tongTien.ToString(
                    "0.##",
                    CultureInfo.GetCultureInfo("vi-VN"));
        }

        // ==========================================
        // 14. NÚT THOÁT
        // ==========================================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
