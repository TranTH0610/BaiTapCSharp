using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLCuaHang
{
    public partial class FormMain : Form
    {
        private int? selectedInvoice;
        private bool loading;
        public FormMain()
        {
            InitializeComponent();
        }

        // =========================================
        // HIỂN THỊ THÔNG BÁO LỖI
        // =========================================

        private void Safe(Action action)
        {
            try
            {
                action();
            }
            catch (SqlException ex)
            {
                string message;

                if (ex.Number >= 50000)
                {
                    // Thông báo nghiệp vụ từ stored procedure.
                    message = ex.Message;
                }
                else
                {
                    message =
                        "Không thể thao tác với SQL Server.\n" +
                        "Kiểm tra App.config và chạy Setup.sql.\n\n" +
                        ex.Message;
                }

                MessageBox.Show(
                    message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // =========================================
        // TẢI TOÀN BỘ DỮ LIỆU
        // =========================================

        private void LoadAll()
        {
            LoadStock();

            LoadProducts();

            LoadInvoices(selectedInvoice);

            lblTrangThai.Text =
                "Đã tải dữ liệu từ SQL Server • " +
                DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // =========================================
        // TẢI TỒN KHO HÔM NAY
        // =========================================

        private void LoadStock()
        {
            string sql = @"
                SELECT
                    p.MaSP,
                    p.TenSP,
                    k.NgayTon,
                    k.SLDau,
                    k.SLNhap,
                    k.SLBan,
                    k.SLDau + k.SLNhap - k.SLBan AS TonConLai
                FROM dbo.SANPHAM AS p
                INNER JOIN dbo.TONKHO AS k
                    ON p.MaSP = k.MaSP
                WHERE k.NgayTon = CONVERT(DATE, GETDATE())
                ORDER BY p.MaSP";

            gridTon.DataSource = Db.Query(sql);
        }

        // =========================================
        // TẢI SẢN PHẨM VÀO BẢNG VÀ COMBOBOX
        // =========================================

        private void LoadProducts()
        {
            string sql = @"
                SELECT MaSP, TenSP
                FROM dbo.SANPHAM
                ORDER BY MaSP";

            DataTable table = Db.Query(sql);

            gridHang.DataSource = table;

            cboSanPham.DataSource = table.Copy();

            cboSanPham.DisplayMember = "TenSP";

            cboSanPham.ValueMember = "MaSP";
        }

        // =========================================
        // TẢI DANH SÁCH HÓA ĐƠN
        // =========================================

        private void LoadInvoices(int? prefer)
        {
            loading = true;

            try
            {
                string sql = @"
                    SELECT
                        MaHD,
                        NgayTao,
                        TinhTrangThanhToan,
                        CASE
                            WHEN TinhTrangThanhToan = 1
                                THEN N'Đã thanh toán'
                            ELSE N'Chưa thanh toán'
                        END AS TrangThai
                    FROM dbo.HOADON
                    ORDER BY MaHD DESC";

                gridHoaDon.DataSource = Db.Query(sql);

                gridHoaDon
                    .Columns["TinhTrangThanhToan"]
                    .Visible = false;

                gridHoaDon.ClearSelection();

                gridHoaDon.CurrentCell = null;

                // Chọn lại hóa đơn vừa thao tác.
                if (prefer.HasValue)
                {
                    foreach (DataGridViewRow row
                        in gridHoaDon.Rows)
                    {
                        int id = Convert.ToInt32(
                            row.Cells["MaHD"].Value);

                        if (id == prefer.Value)
                        {
                            gridHoaDon.CurrentCell =
                                row.Cells["MaHD"];

                            row.Selected = true;

                            break;
                        }
                    }
                }
            }
            finally
            {
                loading = false;
            }

            ChonHoaDon();
        }

        // =========================================
        // BẬT/TẮT CONTROL NHẬP HÓA ĐƠN
        // =========================================

        private void SetEditing(bool enabled)
        {
            cboSanPham.Enabled = enabled;

            numSoLuong.Enabled = enabled;

            btnThemDong.Enabled = enabled;

            btnHuyDong.Enabled = enabled;

            btnThanhToan.Enabled = enabled;

            btnXoaRong.Enabled = enabled;
        }

        // =========================================
        // CHỌN HÓA ĐƠN VÀ XEM CHI TIẾT
        // =========================================

        private void ChonHoaDon()
        {
            if (loading)
            {
                return;
            }

            Safe(delegate
            {
                DataGridViewRow row =
                    gridHoaDon.CurrentRow;

                if (row == null)
                {
                    selectedInvoice = null;

                    txtMaHD.Clear();

                    SetEditing(false);

                    gridChiTiet.DataSource =
                        new DataTable();

                    return;
                }

                selectedInvoice = Convert.ToInt32(
                    row.Cells["MaHD"].Value);

                txtMaHD.Text =
                    selectedInvoice.Value.ToString();

                bool daThanhToan = Convert.ToBoolean(
                    row.Cells["TinhTrangThanhToan"].Value);

                SetEditing(!daThanhToan);

                string sql = @"
                    SELECT
                        c.MaSP,
                        p.TenSP,
                        c.SoLuong
                    FROM dbo.CHITIET_HOADON AS c
                    INNER JOIN dbo.SANPHAM AS p
                        ON p.MaSP = c.MaSP
                    WHERE c.MaHD = @id
                    ORDER BY c.MaSP";

                gridChiTiet.DataSource = Db.Query(
                    sql,
                    Db.P("@id", selectedInvoice.Value));
            });
        }

        // =========================================
        // LẤY MÃ HÓA ĐƠN ĐANG CHỌN
        // =========================================

        private int Invoice()
        {
            if (!selectedInvoice.HasValue)
            {
                throw new InvalidOperationException(
                    "Hãy tạo hoặc chọn hóa đơn.");
            }

            return selectedInvoice.Value;
        }

        // =========================================
        // TẠO TỒN KHO
        // =========================================

        private void TaoTon()
        {
            Safe(delegate
            {
                int soDong = Convert.ToInt32(
                    Db.Run("dbo.TaoTonKho"));

                LoadAll();

                tabs.SelectedIndex = 0;

                MessageBox.Show(
                    "Đã tạo " + soDong + " dòng tồn kho.\n" +
                    "Dòng đã có được giữ nguyên.",
                    "Tồn kho");
            });
        }

        // =========================================
        // THÊM SẢN PHẨM
        // =========================================

        private void ThemSanPham()
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên sản phẩm.");

                txtTen.Focus();

                return;
            }

            Safe(delegate
            {
                Db.Run(
                    "dbo.ThemSanPham",
                    Db.P("@TenSP", txtTen.Text.Trim()));

                txtTen.Clear();

                LoadProducts();

                LoadStock();

                txtTen.Focus();
            });
        }

        // =========================================
        // TẠO HÓA ĐƠN MỚI
        // =========================================

        private void TaoHoaDon()
        {
            Safe(delegate
            {
                int maHD = Convert.ToInt32(
                    Db.Run("dbo.TaoHoaDon"));

                LoadInvoices(maHD);
            });
        }

        // =========================================
        // THÊM SẢN PHẨM VÀO HÓA ĐƠN
        // =========================================

        private void ThemDong()
        {
            Safe(delegate
            {
                int maHD = Invoice();

                if (cboSanPham.SelectedValue == null)
                {
                    throw new InvalidOperationException(
                        "Chưa có sản phẩm.");
                }

                int maSP = Convert.ToInt32(
                    cboSanPham.SelectedValue);

                int soLuong = Convert.ToInt32(
                    numSoLuong.Value);

                Db.Run(
                    "dbo.ThemChiTiet",
                    Db.P("@MaHD", maHD),
                    Db.P("@MaSP", maSP),
                    Db.P("@SoLuong", soLuong));

                LoadStock();

                LoadInvoices(maHD);
            });
        }

        // =========================================
        // HỦY DÒNG HÀNG
        // =========================================

        private void HuyDong()
        {
            Safe(delegate
            {
                int maHD = Invoice();

                if (gridChiTiet.CurrentRow == null)
                {
                    throw new InvalidOperationException(
                        "Hãy chọn dòng hàng cần hủy.");
                }

                DialogResult result = MessageBox.Show(
                    "Hủy toàn bộ số lượng của dòng đã chọn " +
                    "và hoàn tồn?",
                    "Hủy dòng",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                int maSP = Convert.ToInt32(
                    gridChiTiet
                        .CurrentRow
                        .Cells["MaSP"]
                        .Value);

                Db.Run(
                    "dbo.HuyDong",
                    Db.P("@MaHD", maHD),
                    Db.P("@MaSP", maSP));

                LoadStock();

                LoadInvoices(maHD);
            });
        }

        // =========================================
        // THANH TOÁN
        // =========================================

        private void ThanhToan()
        {
            Safe(delegate
            {
                int maHD = Invoice();

                DialogResult result = MessageBox.Show(
                    "Chốt hóa đơn #" + maHD + "?\n" +
                    "Sau thanh toán không được sửa.",
                    "Thanh toán",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                Db.Run(
                    "dbo.ThanhToan",
                    Db.P("@MaHD", maHD));

                LoadInvoices(maHD);
            });
        }

        // =========================================
        // XÓA HÓA ĐƠN CHƯA CÓ SẢN PHẨM
        // =========================================

        private void XoaRong()
        {
            Safe(delegate
            {
                Db.Run(
                    "dbo.HuyHoaDonRong",
                    Db.P("@MaHD", Invoice()));

                LoadInvoices(null);
            });
        }
    }
}