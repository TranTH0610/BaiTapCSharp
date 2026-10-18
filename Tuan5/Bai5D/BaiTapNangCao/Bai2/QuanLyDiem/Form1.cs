using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class Form1 : Form
    {
        // =========================================
        // KẾT NỐI SQL SERVER
        // =========================================
        private readonly string connectionString =
            @"Server=THIEN\MSSQLSERVER01;" +
            "Database=QLSinhVien;" +
            "Integrated Security=True;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();

            // Gỡ và gắn lại các sự kiện cùng handler
            // để tránh đăng ký trùng với Designer.
            Load -= Form1_Load;
            Load += Form1_Load;

            btnThem.Click -= btnThem_Click;
            btnThem.Click += btnThem_Click;

            btnXoa.Click -= btnXoa_Click;
            btnXoa.Click += btnXoa_Click;

            btnSua.Click -= btnSua_Click;
            btnSua.Click += btnSua_Click;
        }

        // =========================================
        // 1. FORM LOAD
        // =========================================
        private void Form1_Load(object sender, EventArgs e)
        {
            XoaDuLieuNhap();
        }

        // =========================================
        // 2. XÓA DỮ LIỆU TRONG CÁC TEXTBOX
        // =========================================
        private void XoaDuLieuNhap()
        {
            txtMaSV.Clear();
            txtMaMH.Clear();
            txtDiem.Clear();

            txtMaSV.Focus();
        }

        // =========================================
        // 3. KIỂM TRA MÃ SINH VIÊN, MÃ MÔN HỌC
        // =========================================
        private bool KiemTraMa()
        {
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

            if (string.IsNullOrWhiteSpace(txtMaMH.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã môn học!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaMH.Focus();
                return false;
            }

            return true;
        }

        // =========================================
        // 4. KIỂM TRA ĐIỂM
        // =========================================
        private bool KiemTraDiem(out decimal diem)
        {
            diem = 0;

            string giaTri = txtDiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(giaTri))
            {
                MessageBox.Show(
                    "Vui lòng nhập điểm!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDiem.Focus();
                return false;
            }

            // Chấp nhận 8,5 hoặc 8.5
            // Không chấp nhận ký tự không phải số
            string diemChuan = giaTri.Replace(',', '.');

            if (!decimal.TryParse(
                diemChuan,
                NumberStyles.AllowLeadingSign |
                NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture,
                out diem))
            {
                MessageBox.Show(
                    "Điểm phải là số hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDiem.Focus();
                txtDiem.SelectAll();
                return false;
            }

            return true;
        }

        // =========================================
        // 5. CHỨC NĂNG THÊM ĐIỂM
        // =========================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraMa())
                return;

            if (!KiemTraDiem(out decimal diem))
                return;

            string maSV = txtMaSV.Text.Trim();
            string maMonHoc = txtMaMH.Text.Trim();

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra điểm của sinh viên
                    // ở môn học này đã tồn tại chưa.
                    string sqlKiemTra =
                        "SELECT COUNT(*) FROM Diem " +
                        "WHERE MaSinhVien = @MaSV " +
                        "AND MaMonHoc = @MaMonHoc";

                    using (SqlCommand cmd =
                        new SqlCommand(sqlKiemTra, conn))
                    {
                        cmd.Parameters.Add(
                            "@MaSV", SqlDbType.NVarChar, 50)
                            .Value = maSV;

                        cmd.Parameters.Add(
                            "@MaMonHoc", SqlDbType.NVarChar, 50)
                            .Value = maMonHoc;

                        int soLuong = Convert.ToInt32(
                            cmd.ExecuteScalar());

                        if (soLuong > 0)
                        {
                            MessageBox.Show(
                                "Sinh viên này đã có điểm " +
                                "ở môn học đã chọn!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }

                    // Thêm điểm vào cơ sở dữ liệu
                    string sqlThem =
                        "INSERT INTO Diem " +
                        "(MaSinhVien, MaMonHoc, Diem) " +
                        "VALUES (@MaSV, @MaMonHoc, @Diem)";

                    using (SqlCommand cmd =
                        new SqlCommand(sqlThem, conn))
                    {
                        cmd.Parameters.Add(
                            "@MaSV", SqlDbType.NVarChar, 50)
                            .Value = maSV;

                        cmd.Parameters.Add(
                            "@MaMonHoc", SqlDbType.NVarChar, 50)
                            .Value = maMonHoc;

                        SqlParameter pDiem = cmd.Parameters.Add(
                            "@Diem", SqlDbType.Decimal);

                        pDiem.Precision = 10;
                        pDiem.Scale = 4;
                        pDiem.Value = diem;

                        int ketQua = cmd.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show(
                                "Thêm điểm thành công!",
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

        // =========================================
        // 6. CHỨC NĂNG XÓA ĐIỂM
        // =========================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Chỉ bắt buộc mã SV và mã môn học
            if (!KiemTraMa())
                return;

            string maSV = txtMaSV.Text.Trim();
            string maMonHoc = txtMaMH.Text.Trim();

            // Khi xóa, ô điểm phải để trống
            if (!string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show(
                    "Khi xóa chỉ nhập mã sinh viên " +
                    "và mã môn học.\n" +
                    "Vui lòng để trống ô Điểm!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDiem.Focus();
                return;
            }

            // Hỏi xác nhận xóa
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa điểm của:\n" +
                "Mã sinh viên: " + maSV + "\n" +
                "Mã môn học: " + maMonHoc + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Xóa theo cả mã sinh viên và mã môn học
                    string sqlXoa =
                        "DELETE FROM Diem " +
                        "WHERE MaSinhVien = @MaSV " +
                        "AND MaMonHoc = @MaMonHoc";

                    using (SqlCommand cmd =
                        new SqlCommand(sqlXoa, conn))
                    {
                        cmd.Parameters.Add(
                            "@MaSV", SqlDbType.NVarChar, 50)
                            .Value = maSV;

                        cmd.Parameters.Add(
                            "@MaMonHoc", SqlDbType.NVarChar, 50)
                            .Value = maMonHoc;

                        int ketQua = cmd.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show(
                                "Xóa điểm thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            XoaDuLieuNhap();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy điểm của sinh viên " +
                                "ở môn học này!",
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

        // =========================================
        // 7. CHỨC NĂNG SỬA ĐIỂM
        // =========================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraMa())
                return;

            if (!KiemTraDiem(out decimal diemMoi))
                return;

            string maSV = txtMaSV.Text.Trim();
            string maMonHoc = txtMaMH.Text.Trim();

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Chỉ cập nhật điểm
                    // Không thay đổi mã sinh viên, mã môn học.
                    string sqlSua =
                        "UPDATE Diem " +
                        "SET Diem = @Diem " +
                        "WHERE MaSinhVien = @MaSV " +
                        "AND MaMonHoc = @MaMonHoc";

                    using (SqlCommand cmd =
                        new SqlCommand(sqlSua, conn))
                    {
                        cmd.Parameters.Add(
                            "@MaSV", SqlDbType.NVarChar, 50)
                            .Value = maSV;

                        cmd.Parameters.Add(
                            "@MaMonHoc", SqlDbType.NVarChar, 50)
                            .Value = maMonHoc;

                        SqlParameter pDiem = cmd.Parameters.Add(
                            "@Diem", SqlDbType.Decimal);

                        pDiem.Precision = 10;
                        pDiem.Scale = 4;
                        pDiem.Value = diemMoi;

                        int ketQua = cmd.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show(
                                "Sửa điểm thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            XoaDuLieuNhap();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy điểm tương ứng " +
                                "với mã sinh viên và mã môn học!",
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

        // =========================================
        // 8. XỬ LÝ LỖI SQL SERVER
        // =========================================
        private void XuLyLoiSQL(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show(
                    "Dữ liệu bị trùng khóa!",
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (ex.Number == 547)
            {
                MessageBox.Show(
                    "Dữ liệu vi phạm ràng buộc SQL Server.\n" +
                    "Hãy kiểm tra mã sinh viên, mã môn học " +
                    "và giá trị điểm!",
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(
                    "Lỗi SQL Server:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

