using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        private MangSoNguyen mangSoNguyen;

        // Ghi nhớ nội dung mảng đã được đưa vào đối tượng
        private string mangDaXuLy = "";

        // Chức năng hiện tại
        private ChucNang chucNangHienTai = ChucNang.SapXep;

        public Form1()
        {
            InitializeComponent();

            // ==============================
            // GẮN SỰ KIỆN
            // ==============================

            btnThucHien.Click += btnThucHien_Click;
            btnReset.Click += btnReset_Click;
            btnThoat.Click += btnThoat_Click;
            btnTinhTong.Click += btnTinhTong_Click;
            btnTimMaxMin.Click += btnTimMaxMin_Click;

            // ==============================
            // MẶC ĐỊNH RADIO BUTTON
            // ==============================

            rdoSapXepTang.Checked = true;
            rdoTimViTri.Checked = true;
            rdoXoaViTri.Checked = true;
            rdoThemGiaTri.Checked = true;
            rdoThayTheViTri.Checked = true;

            // ==============================
            // XÁC ĐỊNH CHỨC NĂNG KHI CLICK
            // ==============================

            GanChucNang(rdoSapXepTang, ChucNang.SapXep);
            GanChucNang(rdoSapXepGiam, ChucNang.SapXep);

            GanChucNang(rdoTimGiaTri, ChucNang.TimKiem);
            GanChucNang(txtTimGiaTri, ChucNang.TimKiem);
            GanChucNang(rdoTimViTri, ChucNang.TimKiem);
            GanChucNang(txtTimViTri, ChucNang.TimKiem);

            GanChucNang(rdoXoaGiaTri, ChucNang.Xoa);
            GanChucNang(txtXoaGiaTri, ChucNang.Xoa);
            GanChucNang(rdoXoaViTri, ChucNang.Xoa);
            GanChucNang(txtXoaViTri, ChucNang.Xoa);

            GanChucNang(rdoThemGiaTri, ChucNang.Them);
            GanChucNang(txtThemGiaTri, ChucNang.Them);
            GanChucNang(txtTaiViTriThem, ChucNang.Them);

            GanChucNang(rdoThayTheGiaTri, ChucNang.ThayThe);
            GanChucNang(txtThayTheGiaTri, ChucNang.ThayThe);
            GanChucNang(rdoThayTheViTri, ChucNang.ThayThe);
            GanChucNang(txtThayTheViTri, ChucNang.ThayThe);
            GanChucNang(txtSoThayThe, ChucNang.ThayThe);

            // Không gọi KhoiTaoMang() ở đây
            // Vì không muốn kiểm tra dữ liệu ngay khi mở Form.
        }

        // =========================================================
        // XÁC ĐỊNH CHỨC NĂNG KHI NGƯỜI DÙNG CLICK VÀO KHU VỰC
        // =========================================================

        private void GanChucNang(Control control, ChucNang chucNang)
        {
            control.Enter += (sender, e) =>
            {
                chucNangHienTai = chucNang;
            };

            control.Click += (sender, e) =>
            {
                chucNangHienTai = chucNang;
            };
        }

        // =========================================================
        // KHỞI TẠO MẢNG
        // =========================================================

        private bool KhoiTaoMang()
        {
            try
            {
                int[] arr = DocMangTuTextBox();

                mangSoNguyen = new MangSoNguyen(arr);

                mangDaXuLy = txtNhapMang.Text.Trim();

                HienThiMang();

                XoaKetQua();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }
        }

        // =========================================================
        // KIỂM TRA XEM NGƯỜI DÙNG CÓ NHẬP MẢNG MỚI KHÔNG
        // =========================================================

        private bool KiemTraMangHienTai()
        {
            string input = txtNhapMang.Text.Trim();

            // Chưa có mảng
            if (mangSoNguyen == null)
            {
                return KhoiTaoMang();
            }

            // Người dùng đã sửa txtNhapMang
            if (input != mangDaXuLy)
            {
                return KhoiTaoMang();
            }

            return true;
        }

        // =========================================================
        // ĐỌC MẢNG TỪ TEXTBOX
        // =========================================================

        private int[] DocMangTuTextBox()
        {
            string input = txtNhapMang.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception(
                    "Vui lòng nhập mảng số nguyên.");
            }

            string[] parts = input.Split(
                new char[] { ' ', ',', ';' },
                StringSplitOptions.RemoveEmptyEntries);

            int[] arr = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out arr[i]))
                {
                    throw new Exception(
                        "Mảng chỉ được chứa số nguyên.\n" +
                        "Giá trị không hợp lệ: " +
                        parts[i]);
                }
            }

            return arr;
        }

        // =========================================================
        // HIỂN THỊ MẢNG
        // =========================================================

        private void HienThiMang()
        {
            if (mangSoNguyen == null)
            {
                return;
            }

            string mang =
                string.Join(
                    " ",
                    mangSoNguyen.LayMang());

            txtKetQuaMang.Text = mang;

            // Đồng bộ mảng hiện tại với ô nhập
            txtNhapMang.Text = mang;

            mangDaXuLy = mang;
        }

        // =========================================================
        // XÓA KẾT QUẢ CŨ
        // =========================================================

        private void XoaKetQua()
        {
            txtSoTimDuoc.Clear();

            txtTongMang.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();

            txtMax.Clear();
            txtMin.Clear();
        }

        // =========================================================
        // NÚT THỰC HIỆN
        // =========================================================

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            try
            {
                // Nếu người dùng nhập mảng mới
                // thì tạo lại đối tượng từ mảng mới
                if (!KiemTraMangHienTai())
                {
                    return;
                }

                switch (chucNangHienTai)
                {
                    case ChucNang.SapXep:
                        XuLySapXep();
                        break;

                    case ChucNang.TimKiem:
                        XuLyTimKiem();
                        break;

                    case ChucNang.Xoa:
                        XuLyXoa();
                        break;

                    case ChucNang.Them:
                        XuLyThem();
                        break;

                    case ChucNang.ThayThe:
                        XuLyThayThe();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // =========================================================
        // SẮP XẾP
        // =========================================================

        private void XuLySapXep()
        {
            if (rdoSapXepTang.Checked)
            {
                mangSoNguyen.SapXepTang();

                HienThiMang();

                MessageBox.Show(
                    "Đã sắp xếp mảng tăng dần.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (rdoSapXepGiam.Checked)
            {
                mangSoNguyen.SapXepGiam();

                HienThiMang();

                MessageBox.Show(
                    "Đã sắp xếp mảng giảm dần.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // =========================================================
        // TÌM KIẾM
        // =========================================================

        private void XuLyTimKiem()
        {
            if (rdoTimGiaTri.Checked)
            {
                if (!int.TryParse(
                    txtTimGiaTri.Text.Trim(),
                    out int giaTri))
                {
                    MessageBox.Show(
                        "Vui lòng nhập giá trị cần tìm là số nguyên.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtTimGiaTri.Focus();
                    return;
                }

                var viTri =
                    mangSoNguyen.TimViTri(giaTri);

                if (!viTri.Any())
                {
                    txtSoTimDuoc.Text =
                        "Không tìm thấy";
                }
                else
                {
                    txtSoTimDuoc.Text =
                        "" +
                        string.Join(", ", viTri);
                }
            }
            else if (rdoTimViTri.Checked)
            {
                if (!int.TryParse(
                    txtTimViTri.Text.Trim(),
                    out int viTri))
                {
                    MessageBox.Show(
                        "Vui lòng nhập vị trí là số nguyên.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtTimViTri.Focus();
                    return;
                }

                int giaTri =
                    mangSoNguyen.TimGiaTri(viTri);

                txtSoTimDuoc.Text =
                    giaTri.ToString();
            }
        }

        // =========================================================
        // XÓA
        // =========================================================

        private void XuLyXoa()
        {
            if (rdoXoaGiaTri.Checked)
            {
                if (!int.TryParse(
                    txtXoaGiaTri.Text.Trim(),
                    out int giaTri))
                {
                    MessageBox.Show(
                        "Vui lòng nhập giá trị cần xóa là số nguyên.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtXoaGiaTri.Focus();
                    return;
                }

                bool ketQua =
                    mangSoNguyen.XoaGiaTri(giaTri);

                if (!ketQua)
                {
                    MessageBox.Show(
                        "Không tìm thấy giá trị " + giaTri,
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                HienThiMang();
            }
            else if (rdoXoaViTri.Checked)
            {
                if (!int.TryParse(
                    txtXoaViTri.Text.Trim(),
                    out int viTri))
                {
                    MessageBox.Show(
                        "Vui lòng nhập vị trí là số nguyên.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtXoaViTri.Focus();
                    return;
                }

                mangSoNguyen.XoaViTri(viTri);

                HienThiMang();
            }
        }

        // =========================================================
        // THÊM
        // =========================================================

        private void XuLyThem()
        {
            if (!int.TryParse(
                txtThemGiaTri.Text.Trim(),
                out int giaTri))
            {
                MessageBox.Show(
                    "Vui lòng nhập giá trị cần thêm là số nguyên.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtThemGiaTri.Focus();
                return;
            }

            if (!int.TryParse(
                txtTaiViTriThem.Text.Trim(),
                out int viTri))
            {
                MessageBox.Show(
                    "Vui lòng nhập vị trí cần thêm là số nguyên.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTaiViTriThem.Focus();
                return;
            }

            mangSoNguyen.Them(
                giaTri,
                viTri);

            HienThiMang();
        }

        // =========================================================
        // TÍNH TỔNG
        // =========================================================

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KiemTraMangHienTai())
                {
                    return;
                }

                txtTongMang.Text =
                    mangSoNguyen.TinhTong().ToString();

                txtTongChan.Text =
                    mangSoNguyen.TinhTongChan().ToString();

                txtTongLe.Text =
                    mangSoNguyen.TinhTongLe().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // =========================================================
        // MAX - MIN
        // =========================================================

        private void btnTimMaxMin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KiemTraMangHienTai())
                {
                    return;
                }

                txtMax.Text =
                    mangSoNguyen.TimMax().ToString();

                txtMin.Text =
                    mangSoNguyen.TimMin().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // =========================================================
        // THAY THẾ
        // =========================================================

        private void XuLyThayThe()
        {
            if (!int.TryParse(
                txtSoThayThe.Text.Trim(),
                out int giaTriMoi))
            {
                MessageBox.Show(
                    "Vui lòng nhập số thay thế là số nguyên.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSoThayThe.Focus();
                return;
            }

            if (rdoThayTheGiaTri.Checked)
            {
                if (!int.TryParse(
                    txtThayTheGiaTri.Text.Trim(),
                    out int giaTriCu))
                {
                    MessageBox.Show(
                        "Vui lòng nhập giá trị cần thay thế là số nguyên.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtThayTheGiaTri.Focus();
                    return;
                }

                int soLuong =
                    mangSoNguyen.ThayTheGiaTri(
                        giaTriCu,
                        giaTriMoi);

                if (soLuong == 0)
                {
                    MessageBox.Show(
                        "Không tìm thấy giá trị " + giaTriCu,
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }
            }
            else if (rdoThayTheViTri.Checked)
            {
                if (!int.TryParse(
                    txtThayTheViTri.Text.Trim(),
                    out int viTri))
                {
                    MessageBox.Show(
                        "Vui lòng nhập vị trí là số nguyên.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtThayTheViTri.Focus();
                    return;
                }

                mangSoNguyen.ThayTheViTri(
                    viTri,
                    giaTriMoi);
            }

            HienThiMang();
        }

        // =========================================================
        // RESET
        // =========================================================

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Xóa đối tượng cũ
            mangSoNguyen = null;

            mangDaXuLy = "";

            // Xóa dữ liệu nhập
            txtNhapMang.Clear();

            // Xóa kết quả
            txtKetQuaMang.Clear();

            XoaKetQua();
        }

        // =========================================================
        // THOÁT
        // =========================================================

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Chỉ gọi Close().
            // Việc hỏi xác nhận sẽ do OnFormClosing xử lý.
            Close();
        }

        // =========================================================
        // XÁC NHẬN ĐÓNG FORM
        // =========================================================

        protected override void OnFormClosing(
            FormClosingEventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc chắn muốn đóng Form không?",
                    "Xác nhận đóng",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            base.OnFormClosing(e);
        }

        // =========================================================
        // LOAD
        // =========================================================

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // =========================================================
        // ENUM CHỨC NĂNG
        // =========================================================

        private enum ChucNang
        {
            SapXep,
            TimKiem,
            Xoa,
            Them,
            ThayThe
        }
    }
}
