using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapVeNha
{
  public partial class Form1 : Form
    {
        // ============================================
        // BIẾN LƯU TỔNG KẾT
        // ============================================

        // Tổng số lượt người đã trả phòng
        private int tongSoLuotNguoi = 0;

        // Tổng số tiền thu được
        private decimal tongSoTien = 0;

        // ============================================
        // CONSTRUCTOR
        // ============================================

        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện
            this.Load += frmDangkyKS_Load;

            btnThanhToan.Click += btnThanhToan_Click;
            btnNhapMoi.Click += btnNhapMoi_Click;
            btnTongKet.Click += btnTongKet_Click;
            btnThoat.Click += btnThoat_Click;

            // Khi dữ liệu thay đổi thì kiểm tra lại
            txtHoTen.TextChanged += KiemTraDuLieu;
            txtDiaChi.TextChanged += KiemTraDuLieu;
            txtSoNgayO.TextChanged += KiemTraDuLieu;

            rdoPhongDon.CheckedChanged += KiemTraDuLieu;
            rdoPhongDoi.CheckedChanged += KiemTraDuLieu;
            rdoPhongBa.CheckedChanged += KiemTraDuLieu;
        }

        // ============================================
        // FORM LOAD
        // ============================================

        private void frmDangkyKS_Load(object sender, EventArgs e)
        {
            // Đưa con trỏ vào ô họ tên
            txtHoTen.Focus();

            // Các button ban đầu bị mờ
            btnTongKet.Enabled = false;
            btnNhapMoi.Enabled = false;
            btnThanhToan.Enabled = false;

            // Xóa dữ liệu kết quả
            txtThanhTien.Clear();
            txtSoLuotNguoi.Clear();
            txtTongSoTien.Clear();

            // Khởi tạo tổng
            tongSoLuotNguoi = 0;
            tongSoTien = 0;
        }

        // ============================================
        // KIỂM TRA DỮ LIỆU
        // ============================================

        private void KiemTraDuLieu(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            int soNgay;

            // Kiểm tra số ngày ở
            bool ngayHopLe =
                int.TryParse(txtSoNgayO.Text.Trim(), out soNgay)
                && soNgay > 0;

            // Kiểm tra loại phòng
            bool phongHopLe =
                rdoPhongDon.Checked ||
                rdoPhongDoi.Checked ||
                rdoPhongBa.Checked;

            // Nếu nhập đầy đủ thì cho phép thanh toán
            btnThanhToan.Enabled =
                hoTen != "" &&
                diaChi != "" &&
                ngayHopLe &&
                phongHopLe;
        }

        // ============================================
        // THANH TOÁN
        // ============================================

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // ----------------------------------------
            // KIỂM TRA HỌ TÊN
            // ----------------------------------------

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên khách hàng.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtHoTen.Focus();
                return;
            }

            // ----------------------------------------
            // KIỂM TRA ĐỊA CHỈ
            // ----------------------------------------

            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập địa chỉ.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDiaChi.Focus();
                return;
            }

            // ----------------------------------------
            // KIỂM TRA SỐ NGÀY
            // ----------------------------------------

            int soNgay;

            if (!int.TryParse(
                    txtSoNgayO.Text.Trim(),
                    out soNgay)
                || soNgay <= 0)
            {
                MessageBox.Show(
                    "Số ngày ở phải là số nguyên lớn hơn 0.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSoNgayO.Focus();
                return;
            }

            // ========================================
            // TÍNH TIỀN PHÒNG
            // ========================================

            decimal giaPhong = 0;

            if (rdoPhongDon.Checked)
            {
                // Phòng đơn: 300.000đ/ngày
                giaPhong = 300000;
            }
            else if (rdoPhongDoi.Checked)
            {
                // Phòng đôi: 350.000đ/ngày
                giaPhong = 350000;
            }
            else if (rdoPhongBa.Checked)
            {
                // Phòng ba: 400.000đ/ngày
                giaPhong = 400000;
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn loại phòng.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            decimal tienPhong = giaPhong * soNgay;

            // ========================================
            // TÍNH TIỀN TIỆN NGHI
            // ========================================

            // Mỗi tiện nghi cộng 10.000đ
            decimal tienTienNghi = 0;

            if (chkTivi.Checked)
            {
                tienTienNghi += 10000;
            }

            if (chkInternet.Checked)
            {
                tienTienNghi += 10000;
            }

            if (chkMayNuocNong.Checked)
            {
                tienTienNghi += 10000;
            }

            // ========================================
            // TÍNH TIỀN DỊCH VỤ
            // ========================================

            decimal tienDichVu = 0;

            // Karaoke: 50.000đ
            if (chkKaraoke.Checked)
            {
                tienDichVu += 50000;
            }

            // Ăn sáng: 15.000đ/ngày
            if (chkAnSang.Checked)
            {
                tienDichVu += 15000 * soNgay;
            }

            // ========================================
            // TÍNH THÀNH TIỀN
            // ========================================

            decimal thanhTien =
                tienPhong +
                tienTienNghi +
                tienDichVu;

            // Hiển thị thành tiền
            txtThanhTien.Text =
                thanhTien.ToString("N0") + " VNĐ";

            // ========================================
            // LƯU TỔNG KẾT
            // ========================================


            // Cộng số người theo loại phòng
            if (rdoPhongDon.Checked)
            {
                tongSoLuotNguoi += 1;
            }
            else if (rdoPhongDoi.Checked)
            {
                tongSoLuotNguoi += 2;
            }
            else if (rdoPhongBa.Checked)
            {
                tongSoLuotNguoi += 3;
            }

            // Cộng tiền vào tổng
            tongSoTien += thanhTien;

            // ========================================
            // CẬP NHẬT BUTTON
            // ========================================

            // Đã thanh toán → không cho thanh toán lần nữa
            btnThanhToan.Enabled = false;

            // Cho phép nhập khách mới
            btnNhapMoi.Enabled = true;

            // Có dữ liệu để tổng kết
            btnTongKet.Enabled = true;
        }

        // ============================================
        // NHẬP MỚI
        // ============================================

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            // Xóa thông tin khách hàng
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoNgayO.Clear();

            // Bỏ chọn loại phòng
            rdoPhongDon.Checked = false;
            rdoPhongDoi.Checked = false;
            rdoPhongBa.Checked = false;

            // Bỏ chọn tiện nghi
            chkTivi.Checked = false;
            chkInternet.Checked = false;
            chkMayNuocNong.Checked = false;

            // Bỏ chọn dịch vụ
            chkKaraoke.Checked = false;
            chkAnSang.Checked = false;

            // Xóa thành tiền
            txtThanhTien.Clear();

            // Button ban đầu
            btnThanhToan.Enabled = false;
            btnNhapMoi.Enabled = false;

            // Tổng kết vẫn sáng nếu còn dữ liệu
            btnTongKet.Enabled = tongSoLuotNguoi > 0;

            // Đưa con trỏ về ô họ tên
            txtHoTen.Focus();
        }

        // ============================================
        // TỔNG KẾT
        // ============================================

        private void btnTongKet_Click(object sender, EventArgs e)
        {
            // Hiển thị tổng số lượt người
            txtSoLuotNguoi.Text =
                tongSoLuotNguoi.ToString();

            // Hiển thị tổng số tiền
            txtTongSoTien.Text =
                tongSoTien.ToString("N0") + " VNĐ";

            // Thông báo tổng kết
            MessageBox.Show(
                "Tổng số lượt người trả phòng: "
                + tongSoLuotNguoi
                + "\nTổng số tiền thu được: "
                + tongSoTien.ToString("N0")
                + " VNĐ",
                "Tổng kết",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Reset tổng sau khi tổng kết
            tongSoLuotNguoi = 0;
            tongSoTien = 0;

            // Nút Tổng kết bị mờ
            btnTongKet.Enabled = false;

            // Không bắt buộc phải sáng btnNhapMoi ở đây
            // nếu đề yêu cầu nhập lại thì có thể bật
            btnNhapMoi.Enabled = true;
        }

        // ============================================
        // THOÁT
        // ============================================

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc chắn muốn thoát khỏi chương trình không?",
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
