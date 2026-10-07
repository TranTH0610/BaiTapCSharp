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

        private int tongSoLuotNguoi = 0;
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
            // Đặt con trỏ vào ô họ tên
            txtHoTen.Focus();

            // Trạng thái ban đầu
            btnThanhToan.Enabled = false;
            btnNhapMoi.Enabled = false;
            btnTongKet.Enabled = false;

            // Xóa kết quả cũ
            txtThanhTien.Clear();
            txtSoLuotNguoi.Clear();
            txtTongSoTien.Clear();

            // Tổng ban đầu
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

            bool ngayHopLe =
                int.TryParse(
                    txtSoNgayO.Text.Trim(),
                    out soNgay)
                && soNgay > 0;

            bool phongHopLe =
                rdoPhongDon.Checked
                || rdoPhongDoi.Checked
                || rdoPhongBa.Checked;

            // Đủ thông tin thì cho phép thanh toán
            btnThanhToan.Enabled =
                hoTen != ""
                && diaChi != ""
                && ngayHopLe
                && phongHopLe;
        }

        // ============================================
        // THANH TOÁN
        // ============================================

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Kiểm tra họ tên
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

            // Kiểm tra địa chỉ
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

            // Kiểm tra số ngày
            if (!int.TryParse(
                txtSoNgayO.Text.Trim(),
                out int soNgay)
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
                giaPhong = 300000;
            }
            else if (rdoPhongDoi.Checked)
            {
                giaPhong = 350000;
            }
            else if (rdoPhongBa.Checked)
            {
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

            decimal tienPhong =
                giaPhong * soNgay;

            // ========================================
            // TÍNH TIỀN TIỆN NGHI
            // ========================================

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

            // Karaoke: tính 1 lần
            if (chkKaraoke.Checked)
            {
                tienDichVu += 50000;
            }

            // Ăn sáng: tính theo số ngày
            if (chkAnSang.Checked)
            {
                tienDichVu += 15000 * soNgay;
            }

            // ========================================
            // TỔNG TIỀN
            // ========================================

            decimal thanhTien =
                tienPhong
                + tienTienNghi
                + tienDichVu;

            // Hiển thị thành tiền
            txtThanhTien.Text =
                thanhTien.ToString("N0") + " VNĐ";

            // ========================================
            // LƯU TỔNG KẾT
            // ========================================

            tongSoLuotNguoi++;
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
            tongSoTien += thanhTien;

            // ========================================
            // CẬP NHẬT BUTTON
            // ========================================

            // Đã thanh toán nên không thanh toán lại
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
            // Xóa thông tin khách cũ
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoNgayO.Clear();

            // Xóa thành tiền
            txtThanhTien.Clear();

            // Trạng thái phòng mặc định
            rdoPhongDon.Checked = true;

            // Xóa tiện nghi
            chkTivi.Checked = false;
            chkInternet.Checked = false;
            chkMayNuocNong.Checked = false;

            // Xóa dịch vụ
            chkKaraoke.Checked = false;
            chkAnSang.Checked = false;

            // Trạng thái button
            btnThanhToan.Enabled = false;
            btnNhapMoi.Enabled = false;

            // Tổng kết vẫn có thể thực hiện
            btnTongKet.Enabled = tongSoLuotNguoi > 0;

            // Đưa con trỏ về tên khách
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

            // Sau khi tổng kết thì đưa biến về 0
            tongSoLuotNguoi = 0;
            tongSoTien = 0;

            // Không cho tổng kết tiếp khi chưa có khách mới
            btnTongKet.Enabled = false;
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
