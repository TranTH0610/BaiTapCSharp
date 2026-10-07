using System;
using System.Windows.Forms;

namespace BaiTapNangCao
{
    public partial class Form1 : Form
    {
        // Tổng số khách đã thanh toán
        private int tongSoKhach = 0;

        // Tổng tiền đã thanh toán
        private decimal tongTien = 0;

        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện
            this.Load += Form1_Load;

            btnTinhTien.Click += btnTinhTien_Click;
            btnNhapLai.Click += btnNhapLai_Click;
            btnThanhToan.Click += btnThanhToan_Click;
            btnThoat.Click += btnThoat_Click;

            // Kiểm tra dữ liệu mỗi khi người dùng thay đổi
            txtTenKhachHang.TextChanged += KiemTraDuLieu;
            txtSoKhachHang.TextChanged += KiemTraDuLieu;

            rdoCafeDen.CheckedChanged += KiemTraDuLieu;
            rdoCafeDa.CheckedChanged += KiemTraDuLieu;
            rdoCafeSua.CheckedChanged += KiemTraDuLieu;
            rdoCafeSuaDa.CheckedChanged += KiemTraDuLieu;
            rdoCafeKem.CheckedChanged += KiemTraDuLieu;

            chkBanMyTrung.CheckedChanged += KiemTraDuLieu;
            chkBanMyCa.CheckedChanged += KiemTraDuLieu;
            chkMyTomTrung.CheckedChanged += KiemTraDuLieu;
            chkMyXaoBo.CheckedChanged += KiemTraDuLieu;
            chkMyCay.CheckedChanged += KiemTraDuLieu;
        }

        // =========================
        // FORM LOAD
        // =========================
        private void Form1_Load(object sender, EventArgs e)
        {
            // Đặt con trỏ vào ô tên
            txtTenKhachHang.Focus();

            // Ban đầu các nút này bị mờ
            btnTinhTien.Enabled = false;
            btnNhapLai.Enabled = false;
            btnThanhToan.Enabled = false;

            // Xóa kết quả cũ
            txtTongKhachHang.Clear();
            txtTongKhachHangExtra.Clear();
            txtTongTienThanhToan.Clear();

            // Số khách chỉ được nhập số
            txtSoKhachHang.KeyPress += txtSoKhachHang_KeyPress;
        }

        // =========================
        // CHỈ CHO NHẬP SỐ
        // =========================
        private void txtSoKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép phím Backspace
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            // Nếu không phải số thì không cho nhập
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // =========================
        // KIỂM TRA DỮ LIỆU
        // =========================
        private void KiemTraDuLieu(object sender, EventArgs e)
        {
            string ten = txtTenKhachHang.Text.Trim();

            int soKhach;

            bool soKhachHopLe =
                int.TryParse(txtSoKhachHang.Text, out soKhach)
                && soKhach > 0;

            // Phải nhập tên
            bool tenHopLe = ten != "";

            // Phải chọn cafe
            bool daChonCafe =
                rdoCafeDen.Checked ||
                rdoCafeDa.Checked ||
                rdoCafeSua.Checked ||
                rdoCafeSuaDa.Checked ||
                rdoCafeKem.Checked;

            // Phải chọn ít nhất một thức ăn
            bool daChonThucAn =
                chkBanMyTrung.Checked ||
                chkBanMyCa.Checked ||
                chkMyTomTrung.Checked ||
                chkMyXaoBo.Checked ||
                chkMyCay.Checked;

            // Đủ thông tin thì nút Tính tiền sáng
            btnTinhTien.Enabled =
                tenHopLe &&
                soKhachHopLe &&
                daChonCafe &&
                daChonThucAn;
        }

        // =========================
        // TÍNH TIỀN
        // =========================
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            string ten = txtTenKhachHang.Text.Trim();

            if (ten == "")
            {
                MessageBox.Show(
                    "Tên khách hàng không được để trống!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenKhachHang.Focus();
                return;
            }

            int soKhach;

            if (!int.TryParse(txtSoKhachHang.Text, out soKhach)
                || soKhach <= 0)
            {
                MessageBox.Show(
                    "Số khách hàng phải là số nguyên lớn hơn 0!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSoKhachHang.Focus();
                return;
            }

            // =========================
            // GIÁ CAFE
            // =========================
            decimal giaCafe = 0;

            if (rdoCafeDen.Checked)
            {
                giaCafe = 20000;
            }
            else if (rdoCafeDa.Checked)
            {
                giaCafe = 25000;
            }
            else if (rdoCafeSua.Checked)
            {
                giaCafe = 25000;
            }
            else if (rdoCafeSuaDa.Checked)
            {
                giaCafe = 30000;
            }
            else if (rdoCafeKem.Checked)
            {
                giaCafe = 35000;
            }

            // =========================
            // GIÁ THỨC ĂN
            // =========================
            decimal giaThucAn = 0;

            if (chkBanMyTrung.Checked)
            {
                giaThucAn += 15000;
            }

            if (chkBanMyCa.Checked)
            {
                giaThucAn += 15000;
            }

            if (chkMyTomTrung.Checked)
            {
                giaThucAn += 20000;
            }

            if (chkMyXaoBo.Checked)
            {
                giaThucAn += 30000;
            }

            if (chkMyCay.Checked)
            {
                giaThucAn += 50000;
            }

            // =========================
            // TÍNH TIỀN
            // =========================

            // Giá của 1 khách
            decimal tienMotKhach = giaCafe + giaThucAn;

            // Tổng tiền của nhóm khách
            decimal thanhTien = tienMotKhach * soKhach;

            // Nếu là sinh viên giảm 20%
            if (chkSinhVien.Checked)
            {
                thanhTien = thanhTien * 0.8m;
            }

            // Hiển thị tiền bằng MessageBox
            MessageBox.Show(
                "Tên khách hàng: " + ten +
                "\nSố khách: " + soKhach +
                "\nThành tiền: " + thanhTien.ToString("N0") + " VNĐ",
                "Kết quả tính tiền",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Sau khi tính tiền
            btnNhapLai.Enabled = true;
            btnThanhToan.Enabled = true;

            // Không cho tính lại lần nữa cho cùng nhóm
            btnTinhTien.Enabled = false;
        }

        // =========================
        // NHẬP LẠI
        // =========================
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            // Xóa tên
            txtTenKhachHang.Clear();

            // Xóa số khách
            txtSoKhachHang.Clear();

            // Bỏ chọn sinh viên
            chkSinhVien.Checked = false;

            // Bỏ chọn cafe
            rdoCafeDen.Checked = false;
            rdoCafeDa.Checked = false;
            rdoCafeSua.Checked = false;
            rdoCafeSuaDa.Checked = false;
            rdoCafeKem.Checked = false;

            // Bỏ chọn thức ăn
            chkBanMyTrung.Checked = false;
            chkBanMyCa.Checked = false;
            chkMyTomTrung.Checked = false;
            chkMyXaoBo.Checked = false;
            chkMyCay.Checked = false;

            // Xóa kết quả tổng
            txtTongKhachHangExtra.Clear();

            // Trạng thái ban đầu
            btnTinhTien.Enabled = false;
            btnNhapLai.Enabled = false;
            btnThanhToan.Enabled = false;

            // Đưa con trỏ về tên khách hàng
            txtTenKhachHang.Focus();
        }

        // =========================
        // THANH TOÁN
        // =========================
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int soKhach = int.Parse(txtSoKhachHang.Text);

            decimal giaCafe = 0;

            if (rdoCafeDen.Checked)
                giaCafe = 20000;
            else if (rdoCafeDa.Checked)
                giaCafe = 25000;
            else if (rdoCafeSua.Checked)
                giaCafe = 25000;
            else if (rdoCafeSuaDa.Checked)
                giaCafe = 30000;
            else if (rdoCafeKem.Checked)
                giaCafe = 35000;

            decimal giaThucAn = 0;

            if (chkBanMyTrung.Checked)
                giaThucAn += 15000;

            if (chkBanMyCa.Checked)
                giaThucAn += 15000;

            if (chkMyTomTrung.Checked)
                giaThucAn += 20000;

            if (chkMyXaoBo.Checked)
                giaThucAn += 30000;

            if (chkMyCay.Checked)
                giaThucAn += 50000;

            decimal thanhTien =
                (giaCafe + giaThucAn) * soKhach;

            // Giảm 20% nếu là sinh viên
            if (chkSinhVien.Checked)
            {
                thanhTien *= 0.8m;
            }

            // Cộng vào tổng
            tongSoKhach += soKhach;
            tongTien += thanhTien;

            // Hiển thị tổng
            txtTongKhachHang.Text = tongSoKhach.ToString();
            txtTongTienThanhToan.Text =
                tongTien.ToString("N0") + " VNĐ";

            // Sẵn sàng nhập nhóm mới
            btnThanhToan.Enabled = false;
            btnNhapLai.Enabled = true;

            MessageBox.Show(
                "Thanh toán thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================
        // THOÁT
        // =========================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}