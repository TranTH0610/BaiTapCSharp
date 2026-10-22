
using System;
using System.Linq;
using System.Windows.Forms;

namespace BaiTap1
{
    public partial class Form1 : Form
    {
        // ContextMenuStrip dùng để xóa bằng chuột phải
        private ContextMenuStrip menuChuộtPhai;
        private ToolStripMenuItem menuXoaSinhVien;

        // Lưu mã sinh viên đang được chọn để sửa
        private string maSVDangChon = "";

        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện
            Load += Form1_Load;

            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;

            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            dgvSinhVien.CellMouseDown += dgvSinhVien_CellMouseDown;

            FormClosing += Form1_FormClosing;
        }

        // ==========================================
        // 1. KHI FORM LOAD
        // ==========================================
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm dữ liệu vào ComboBox dân tộc
            cboDanToc.Items.Clear();

            cboDanToc.Items.AddRange(new object[]
            {
                "Kinh",
                "Tày",
                "Thái",
                "Mường",
                "Khmer",
                "Hoa",
                "Nùng",
                "H'Mông",
                "Dao",
                "Gia Rai",
                "Ê Đê",
                "Ba Na",
                "Chăm",
                "Sán Dìu"
            });

            cboDanToc.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboDanToc.SelectedIndex = 0;

            // Cấu hình DataGridView
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AllowUserToDeleteRows = false;

            dgvSinhVien.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvSinhVien.MultiSelect = false;

            // Khởi tạo ContextMenuStrip
            TaoMenuChuộtPhai();

            // Đặt dữ liệu mặc định
            XoaDuLieuNhap();

            dgvSinhVien.ClearSelection();
        }

        // ==========================================
        // 2. TẠO CONTEXTMENUSTRIP
        // ==========================================
        private void TaoMenuChuộtPhai()
        {
            menuChuộtPhai = new ContextMenuStrip();

            menuXoaSinhVien = new ToolStripMenuItem();

            menuXoaSinhVien.Text = "Xóa sinh viên";

            // Gắn sự kiện cho mục Xóa
            menuXoaSinhVien.Click += menuXoaSinhVien_Click;

            // Thêm mục Xóa vào ContextMenuStrip
            menuChuộtPhai.Items.Add(menuXoaSinhVien);

            // Gắn menu vào DataGridView
            dgvSinhVien.ContextMenuStrip = menuChuộtPhai;

            // Chỉ cho mở menu khi có sinh viên được chọn
            menuChuộtPhai.Opening += (s, e) =>
            {
                if (dgvSinhVien.SelectedRows.Count == 0)
                {
                    e.Cancel = true;
                }
            };
        }

        // ==========================================
        // 3. KIỂM TRA DỮ LIỆU NHẬP
        // ==========================================
        private bool KiemTraDuLieu()
        {
            // Kiểm tra họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ tên sinh viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtHoTen.Focus();
                return false;
            }

            // Kiểm tra mã sinh viên
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã sinh viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaSV.Focus();
                return false;
            }

            // Kiểm tra giới tính
            if (!radNam.Checked && !radNu.Checked)
            {
                MessageBox.Show(
                    "Vui lòng chọn giới tính!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            // Kiểm tra ngoại ngữ
            if (!chkAnh.Checked &&
                !chkPhap.Checked &&
                !chkHoa.Checked)
            {
                MessageBox.Show(
                    "Vui lòng chọn ít nhất một ngoại ngữ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            // Kiểm tra dân tộc
            if (cboDanToc.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn dân tộc!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboDanToc.Focus();
                return false;
            }

            return true;
        }

        // ==========================================
        // 4. LẤY NGOẠI NGỮ ĐƯỢC CHỌN
        // ==========================================
        private string LayNgoaiNgu()
        {
            string ngoaiNgu = "";

            if (chkAnh.Checked)
            {
                ngoaiNgu += "Anh, ";
            }

            if (chkPhap.Checked)
            {
                ngoaiNgu += "Pháp, ";
            }

            if (chkHoa.Checked)
            {
                ngoaiNgu += "Hoa, ";
            }

            // Xóa dấu phẩy và khoảng trắng ở cuối
            return ngoaiNgu.TrimEnd(',', ' ');
        }

        // ==========================================
        // 5. KIỂM TRA TRÙNG MÃ SINH VIÊN
        // ==========================================
        private bool KiemTraTrungMa(string maSV)
        {
            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                string maTrongBang =
                    Convert.ToString(
                        row.Cells["colMaSV"].Value);

                if (string.Equals(
                    maTrongBang,
                    maSV,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        // ==========================================
        // 6. CHỨC NĂNG THÊM SINH VIÊN
        // ==========================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
            {
                return;
            }

            string hoTen = txtHoTen.Text.Trim();
            string maSV = txtMaSV.Text.Trim();

            string gioiTinh =
                radNam.Checked ? "Nam" : "Nữ";

            string ngoaiNgu = LayNgoaiNgu();

            string danToc = cboDanToc.Text;

            // Kiểm tra trùng mã sinh viên
            if (KiemTraTrungMa(maSV))
            {
                MessageBox.Show(
                    "Mã sinh viên " + maSV +
                    " đã tồn tại!\n" +
                    "Vui lòng nhập mã sinh viên khác.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaSV.Focus();
                txtMaSV.SelectAll();
                return;
            }

            // Thêm sinh viên vào DataGridView
            dgvSinhVien.Rows.Add(
                hoTen,
                maSV,
                gioiTinh,
                ngoaiNgu,
                danToc
            );

            MessageBox.Show(
                "Thêm sinh viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Xóa dữ liệu nhập để thêm sinh viên tiếp theo
            XoaDuLieuNhap();

            dgvSinhVien.ClearSelection();
        }

        // ==========================================
        // 7. CHỌN SINH VIÊN TRONG DATAGRIDVIEW
        // ==========================================
        private void dgvSinhVien_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            HienThiSinhVienLenForm(e.RowIndex);
        }

        // ==========================================
        // 8. HIỂN THỊ SINH VIÊN ĐANG CHỌN
        // ==========================================
        private void HienThiSinhVienLenForm(int rowIndex)
        {
            if (rowIndex < 0 ||
                rowIndex >= dgvSinhVien.Rows.Count)
            {
                return;
            }

            DataGridViewRow row =
                dgvSinhVien.Rows[rowIndex];

            // Họ tên
            txtHoTen.Text =
                Convert.ToString(
                    row.Cells["colHoTen"].Value);

            // Mã sinh viên
            txtMaSV.Text =
                Convert.ToString(
                    row.Cells["colMaSV"].Value);

            // Không cho sửa mã sinh viên
            txtMaSV.ReadOnly = true;

            // Lưu mã sinh viên đang chọn
            maSVDangChon = txtMaSV.Text.Trim();

            // Giới tính
            string gioiTinh =
                Convert.ToString(
                    row.Cells["colGioiTinh"].Value);

            radNam.Checked = gioiTinh == "Nam";
            radNu.Checked = gioiTinh == "Nữ";

            // Ngoại ngữ
            string ngoaiNgu =
                Convert.ToString(
                    row.Cells["colNgoaiNgu"].Value);

            string[] danhSachNgoaiNgu =
                ngoaiNgu.Split(
                    new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();

            chkAnh.Checked =
                danhSachNgoaiNgu.Contains("Anh");

            chkPhap.Checked =
                danhSachNgoaiNgu.Contains("Pháp");

            chkHoa.Checked =
                danhSachNgoaiNgu.Contains("Hoa");

            // Dân tộc
            string danToc =
                Convert.ToString(
                    row.Cells["colDanToc"].Value);

            cboDanToc.SelectedItem = danToc;
        }

        // ==========================================
        // 9. CHỨC NĂNG XÓA SINH VIÊN
        // ==========================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaSinhVien();
        }

        // ==========================================
        // 10. HÀM XÓA SINH VIÊN DÙNG CHUNG
        // ==========================================
        private void XoaSinhVien()
        {
            if (dgvSinhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn sinh viên cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow row =
                dgvSinhVien.SelectedRows[0];

            string hoTen =
                Convert.ToString(
                    row.Cells["colHoTen"].Value);

            string maSV =
                Convert.ToString(
                    row.Cells["colMaSV"].Value);

            // Hỏi xác nhận xóa
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sinh viên:\n" +
                "Mã SV: " + maSV + "\n" +
                "Họ tên: " + hoTen + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            // Xóa dòng được chọn
            dgvSinhVien.Rows.Remove(row);

            MessageBox.Show(
                "Xóa sinh viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            XoaDuLieuNhap();

            dgvSinhVien.ClearSelection();
        }

        // ==========================================
        // 11. CHỨC NĂNG SỬA SINH VIÊN
        // ==========================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count == 0 ||
                string.IsNullOrWhiteSpace(maSVDangChon))
            {
                MessageBox.Show(
                    "Vui lòng chọn sinh viên cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!KiemTraDuLieu())
            {
                return;
            }

            DataGridViewRow row =
                dgvSinhVien.SelectedRows[0];

            string maTrongBang =
                Convert.ToString(
                    row.Cells["colMaSV"].Value);

            // Bảo đảm đúng sinh viên đang sửa
            if (!string.Equals(
                maTrongBang,
                maSVDangChon,
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "Sinh viên đang chọn không hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Chỉ sửa các thông tin khác mã sinh viên
            row.Cells["colHoTen"].Value =
                txtHoTen.Text.Trim();

            row.Cells["colGioiTinh"].Value =
                radNam.Checked ? "Nam" : "Nữ";

            row.Cells["colNgoaiNgu"].Value =
                LayNgoaiNgu();

            row.Cells["colDanToc"].Value =
                cboDanToc.Text;

            // KHÔNG thay đổi colMaSV
            MessageBox.Show(
                "Sửa thông tin sinh viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Giữ nguyên sinh viên đang chọn để có thể sửa tiếp
        }

        // ==========================================
        // 12. CHỌN DÒNG BẰNG CHUỘT PHẢI
        // ==========================================
        private void dgvSinhVien_CellMouseDown(
            object sender,
            DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right &&
                e.RowIndex >= 0)
            {
                // Bỏ lựa chọn trước
                dgvSinhVien.ClearSelection();

                // Chọn dòng vừa nhấn chuột phải
                dgvSinhVien.Rows[e.RowIndex].Selected = true;

                dgvSinhVien.CurrentCell =
                    dgvSinhVien.Rows[e.RowIndex].Cells[0];

                // Hiển thị dữ liệu của dòng lên Form
                HienThiSinhVienLenForm(e.RowIndex);
            }
            else if (e.Button == MouseButtons.Right)
            {
                // Không cho xóa nếu nhấn vào vùng trống
                dgvSinhVien.ClearSelection();
            }
        }

        // ==========================================
        // 13. XÓA TỪ CONTEXTMENUSTRIP
        // ==========================================
        private void menuXoaSinhVien_Click(
            object sender, EventArgs e)
        {
            XoaSinhVien();
        }

        // ==========================================
        // 14. XÓA DỮ LIỆU NHẬP
        // ==========================================
        private void XoaDuLieuNhap()
        {
            txtHoTen.Clear();
            txtMaSV.Clear();

            // Cho phép nhập mã mới sau khi thêm/xóa
            txtMaSV.ReadOnly = false;

            maSVDangChon = "";

            // Trở về giới tính mặc định
            radNam.Checked = true;
            radNu.Checked = false;

            // Ngoại ngữ mặc định
            chkAnh.Checked = true;
            chkPhap.Checked = false;
            chkHoa.Checked = false;

            // Dân tộc mặc định
            if (cboDanToc.Items.Count > 0)
            {
                cboDanToc.SelectedIndex = 0;
            }

            txtHoTen.Focus();
        }

        // ==========================================
        // 15. HỎI XÁC NHẬN KHI ĐÓNG FORM
        // ==========================================
        private void Form1_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đóng Form không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
