using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyMonHoc
{
    public partial class Form1 : Form
    {
        // Kết nối SQL Server
        string connectionString =
      @"Server=THIEN\MSSQLSERVER01;" +
      "Database=QLSinhVien;" +
      "User Id=sa;" +
      "Password=Thien12345;" +
      "Encrypt=True;" +
      "TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện cho các Button
            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;

            Load += Form1_Load;
        }

        // ========================================
        // 1. KHI FORM ĐƯỢC LOAD
        // ========================================
        private void Form1_Load(object sender, EventArgs e)
        {
            txtMaMonHoc.Clear();
            txtTenMonHoc.Clear();

            txtMaMonHoc.Focus();
        }

        // ========================================
        // 2. XÓA NỘI DUNG TEXTBOX SAU KHI XỬ LÝ
        // ========================================
        private void XoaDuLieuNhap()
        {
            txtMaMonHoc.Clear();
            txtTenMonHoc.Clear();

            txtMaMonHoc.Focus();
        }

        // ========================================
        // 3. KIỂM TRA DỮ LIỆU THÊM / SỬA
        // ========================================
        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMaMonHoc.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã môn học!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaMonHoc.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenMonHoc.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên môn học!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenMonHoc.Focus();
                return false;
            }

            return true;
        }

        // ========================================
        // 4. CHỨC NĂNG THÊM MÔN HỌC
        // ========================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã và tên môn học
            if (!KiemTraDuLieu())
                return;

            string maMonHoc = txtMaMonHoc.Text.Trim();
            string tenMonHoc = txtTenMonHoc.Text.Trim();

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra mã môn học đã tồn tại
                    string sqlKiemTra =
                        "SELECT COUNT(*) FROM MonHoc " +
                        "WHERE MaMonHoc = @MaMonHoc";

                    using (SqlCommand cmdKiemTra =
                        new SqlCommand(sqlKiemTra, conn))
                    {
                        cmdKiemTra.Parameters.Add(
                            "@MaMonHoc", SqlDbType.NVarChar, 50)
                            .Value = maMonHoc;

                        int soLuong = Convert.ToInt32(
                            cmdKiemTra.ExecuteScalar());

                        if (soLuong > 0)
                        {
                            MessageBox.Show(
                                "Mã môn học đã tồn tại!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtMaMonHoc.Focus();
                            txtMaMonHoc.SelectAll();
                            return;
                        }
                    }

                    // Thêm môn học mới
                    string sqlThem =
                        "INSERT INTO MonHoc (MaMonHoc, TenMonHoc) " +
                        "VALUES (@MaMonHoc, @TenMonHoc)";

                    using (SqlCommand cmdThem =
                        new SqlCommand(sqlThem, conn))
                    {
                        cmdThem.Parameters.Add(
                            "@MaMonHoc", SqlDbType.NVarChar, 50)
                            .Value = maMonHoc;

                        cmdThem.Parameters.Add(
                            "@TenMonHoc", SqlDbType.NVarChar, 200)
                            .Value = tenMonHoc;

                        int ketQua = cmdThem.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show(
                                "Thêm môn học thành công!",
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
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Mã môn học đã tồn tại!");
                }
                else
                {
                    MessageBox.Show(
                        "Lỗi cơ sở dữ liệu: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
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
        // 5. CHỨC NĂNG XÓA MÔN HỌC
        // ========================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maMonHoc = txtMaMonHoc.Text.Trim();
            string tenMonHoc = txtTenMonHoc.Text.Trim();

            // Mã môn học không được rỗng
            if (string.IsNullOrWhiteSpace(maMonHoc))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã môn học cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaMonHoc.Focus();
                return;
            }

            // Khi xóa, không được nhập tên môn học
            if (!string.IsNullOrWhiteSpace(tenMonHoc))
            {
                MessageBox.Show(
                    "Khi xóa chỉ nhập mã môn học, " +
                    "không nhập tên môn học!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenMonHoc.Focus();
                return;
            }

            // Xác nhận trước khi xóa
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa môn học có mã " +
                maMonHoc + " không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlXoa =
                        "DELETE FROM MonHoc " +
                        "WHERE MaMonHoc = @MaMonHoc";

                    using (SqlCommand cmdXoa =
                        new SqlCommand(sqlXoa, conn))
                    {
                        cmdXoa.Parameters.Add(
                            "@MaMonHoc", SqlDbType.NVarChar, 50)
                            .Value = maMonHoc;

                        int ketQua = cmdXoa.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show(
                                "Xóa môn học thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            XoaDuLieuNhap();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy môn học có mã " +
                                maMonHoc + "!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show(
                        "Không thể xóa môn học vì đang có " +
                        "dữ liệu khác tham chiếu đến môn học này!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(
                        "Lỗi cơ sở dữ liệu: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
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
        // 6. CHỨC NĂNG SỬA MÔN HỌC
        // ========================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu
            if (!KiemTraDuLieu())
                return;

            string maMonHoc = txtMaMonHoc.Text.Trim();
            string tenMonHoc = txtTenMonHoc.Text.Trim();

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Sửa tên môn học theo mã môn học
                    string sqlSua =
                        "UPDATE MonHoc " +
                        "SET TenMonHoc = @TenMonHoc " +
                        "WHERE MaMonHoc = @MaMonHoc";

                    using (SqlCommand cmdSua =
                        new SqlCommand(sqlSua, conn))
                    {
                        cmdSua.Parameters.Add(
                            "@MaMonHoc", SqlDbType.NVarChar, 50)
                            .Value = maMonHoc;

                        cmdSua.Parameters.Add(
                            "@TenMonHoc", SqlDbType.NVarChar, 200)
                            .Value = tenMonHoc;

                        int ketQua = cmdSua.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show(
                                "Sửa môn học thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            XoaDuLieuNhap();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy môn học có mã " +
                                maMonHoc + "!",
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
                    "Lỗi cơ sở dữ liệu: " + ex.Message,
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
