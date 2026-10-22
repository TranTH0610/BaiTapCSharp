
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        // Kết nối SQL Server
        private readonly string connectionString =
            @"Server=THIEN\MSSQLSERVER01;" +
            "Database=QLSinhVien;" +
            "Integrated Security=True;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện cho các nút
            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;

            Load += Form1_Load;
        }

        // ========================================
        // 1. FORM LOAD
        // ========================================
        private void Form1_Load(object sender, EventArgs e)
        {
            XoaDuLieuNhap();
        }

        // ========================================
        // 2. XÓA CÁC TEXTBOX
        // ========================================
        private void XoaDuLieuNhap()
        {
            txtMaLop.Clear();
            txtMaSV.Clear();
            txtHoTen.Clear();
            mskNgaySinh.Clear();

            txtMaLop.Focus();
        }

        // ========================================
        // 3. KIỂM TRA NGÀY SINH
        // ========================================
        private bool KiemTraNgaySinh(
            string ngayNhap,
            out DateTime ngaySinh)
        {
            string[] dinhDang =
            {
                "dd/MM/yyyy",
                "d/M/yyyy",
                "dd-MM-yyyy",
                "d-M-yyyy"
            };

            return DateTime.TryParseExact(
                ngayNhap,
                dinhDang,
                CultureInfo.GetCultureInfo("vi-VN"),
                DateTimeStyles.None,
                out ngaySinh);
        }

        // ========================================
        // 4. CHỨC NĂNG THÊM SINH VIÊN
        // ========================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string maSV = txtMaSV.Text.Trim();
            string tenSV = txtHoTen.Text.Trim();
            string ngayNhap = mskNgaySinh.Text.Trim();

            // Kiểm tra các trường bắt buộc
            if (maLop == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập mã lớp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaLop.Focus();
                return;
            }

            if (maSV == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập mã sinh viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaSV.Focus();
                return;
            }

            if (tenSV == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập tên sinh viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtHoTen.Focus();
                return;
            }

            if (ngayNhap == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập ngày sinh!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                mskNgaySinh.Focus();
                return;
            }

            // Kiểm tra ngày sinh hợp lệ
            if (!KiemTraNgaySinh(
                ngayNhap, out DateTime ngaySinh))
            {
                MessageBox.Show(
                    "Ngày sinh không hợp lệ! " +
                    "Vui lòng nhập theo dd/MM/yyyy.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                mskNgaySinh.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra mã sinh viên có trùng không
                    string sqlKiemTra =
                        "SELECT COUNT(*) FROM SinhVien " +
                        "WHERE MaSinhVien = @MaSinhVien";

                    using (SqlCommand cmdKiemTra =
                        new SqlCommand(sqlKiemTra, conn))
                    {
                        cmdKiemTra.Parameters.Add(
                            "@MaSinhVien",
                            SqlDbType.NVarChar, 50).Value = maSV;

                        int soLuong = Convert.ToInt32(
                            cmdKiemTra.ExecuteScalar());

                        if (soLuong > 0)
                        {
                            MessageBox.Show(
                                "Mã sinh viên đã tồn tại!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtMaSV.Focus();
                            return;
                        }
                    }

                    // Thêm dữ liệu vào bảng SinhVien
                    string sqlThem =
                        "INSERT INTO SinhVien " +
                        "(MaLop, MaSinhVien, TenSinhVien, NgaySinh) " +
                        "VALUES " +
                        "(@MaLop, @MaSinhVien, @TenSinhVien, @NgaySinh)";

                    using (SqlCommand cmdThem =
                        new SqlCommand(sqlThem, conn))
                    {
                        cmdThem.Parameters.Add(
                            "@MaLop",
                            SqlDbType.NVarChar, 50).Value = maLop;

                        cmdThem.Parameters.Add(
                            "@MaSinhVien",
                            SqlDbType.NVarChar, 50).Value = maSV;

                        cmdThem.Parameters.Add(
                            "@TenSinhVien",
                            SqlDbType.NVarChar, 200).Value = tenSV;

                        cmdThem.Parameters.Add(
                            "@NgaySinh",
                            SqlDbType.Date).Value = ngaySinh.Date;

                        int ketQua = cmdThem.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show(
                                "Thêm sinh viên thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            XoaDuLieuNhap();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Lỗi SQL Server: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ========================================
        // 5. CHỨC NĂNG XÓA SINH VIÊN
        // ========================================

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();

            // 1. Kiểm tra mã sinh viên
            if (string.IsNullOrWhiteSpace(maSV))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã sinh viên cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaSV.Focus();
                return;
            }

            // 2. Hỏi xác nhận xóa
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sinh viên có mã " + maSV + " không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Nếu chọn No thì không xóa
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                // 3. Kết nối SQL Server
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 4. Xóa sinh viên chỉ dựa vào mã sinh viên
                    string sql =
                        "DELETE FROM SinhVien WHERE MaSinhVien = @MaSV";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add(
                            "@MaSV", SqlDbType.NVarChar, 50).Value = maSV;

                        // 5. Thực hiện xóa
                        int ketQua = cmd.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show(
                                "Xóa sinh viên thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            // Xóa dữ liệu trên Form
                            XoaDuLieuNhap();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy sinh viên có mã " + maSV + "!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                XuLyLoiSQL(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void XuLyLoiSQL(SqlException ex)
        {
            MessageBox.Show(
                "Lỗi cơ sở dữ liệu: " + ex.Message,
                "Lỗi SQL Server",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        // ========================================
        // 6. CHỨC NĂNG SỬA SINH VIÊN
        // ========================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string tenSV = txtHoTen.Text.Trim();
            string ngayNhap = mskNgaySinh.Text.Trim();

            // Mã sinh viên bắt buộc
            if (maSV == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập mã sinh viên cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaSV.Focus();
                return;
            }

            // Ít nhất một trường cần thay đổi
            if (maLop == "" &&
                tenSV == "" &&
                ngayNhap == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập ít nhất một thông tin " +
                    "cần thay đổi: Mã lớp, Tên sinh viên " +
                    "hoặc Ngày sinh!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Chỉ kiểm tra ngày sinh khi người dùng có nhập
            DateTime ngaySinh = DateTime.MinValue;

            if (ngayNhap != "" &&
                !KiemTraNgaySinh(ngayNhap, out ngaySinh))
            {
                MessageBox.Show(
                    "Ngày sinh không hợp lệ! " +
                    "Vui lòng nhập theo dd/MM/yyyy.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                mskNgaySinh.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Chỉ cập nhật các trường được nhập
                    string sqlSua =
                        "UPDATE SinhVien SET " +
                        "MaLop = CASE WHEN @MaLop = N'' " +
                        "THEN MaLop ELSE @MaLop END, " +

                        "TenSinhVien = CASE WHEN @TenSinhVien = N'' " +
                        "THEN TenSinhVien ELSE @TenSinhVien END, " +

                        "NgaySinh = COALESCE(@NgaySinh, NgaySinh) " +

                        "WHERE MaSinhVien = @MaSinhVien";

                    using (SqlCommand cmdSua =
                        new SqlCommand(sqlSua, conn))
                    {
                        cmdSua.Parameters.Add(
                            "@MaSinhVien",
                            SqlDbType.NVarChar, 50).Value = maSV;

                        cmdSua.Parameters.Add(
                            "@MaLop",
                            SqlDbType.NVarChar, 50).Value = maLop;

                        cmdSua.Parameters.Add(
                            "@TenSinhVien",
                            SqlDbType.NVarChar, 200).Value = tenSV;

                        SqlParameter ngaySinhParam =
                            cmdSua.Parameters.Add(
                                "@NgaySinh", SqlDbType.Date);

                        if (ngayNhap == "")
                        {
                            ngaySinhParam.Value = DBNull.Value;
                        }
                        else
                        {
                            ngaySinhParam.Value = ngaySinh.Date;
                        }

                        int ketQua = cmdSua.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show(
                                "Sửa thông tin sinh viên thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            XoaDuLieuNhap();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy sinh viên có mã " +
                                maSV + "!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Lỗi SQL Server: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
