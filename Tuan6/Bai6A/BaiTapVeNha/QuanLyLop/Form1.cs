using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyLop
{
    public partial class Form1 : Form
    {
        // ==========================================
        // KẾT NỐI SQL SERVER
        // ==========================================
        private readonly string connectionString =
            @"Server=THIEN\MSSQLSERVER01;" +
            "Database=QLSinhVien;" +
            "Integrated Security=True;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();

            // Tránh gắn trùng sự kiện từ Designer
            Load -= Form1_Load;
            Load += Form1_Load;

            btnThem.Click -= btnThem_Click;
            btnThem.Click += btnThem_Click;

            btnXoa.Click -= btnXoa_Click;
            btnXoa.Click += btnXoa_Click;

            btnSua.Click -= btnSua_Click;
            btnSua.Click += btnSua_Click;
        }

        // ==========================================
        // 1. KHI FORM ĐƯỢC LOAD
        // ==========================================
        private void Form1_Load(object sender, EventArgs e)
        {
            XoaDuLieuNhap();
        }

        // ==========================================
        // 2. XÓA DỮ LIỆU CÁC TEXTBOX
        // ==========================================
        private void XoaDuLieuNhap()
        {
            txtMaKhoa.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();

            txtMaKhoa.Focus();
        }

        // ==========================================
        // 3. CHỨC NĂNG THÊM LỚP
        // ==========================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();

            // Kiểm tra mã khoa
            if (string.IsNullOrWhiteSpace(maKhoa))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã khoa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaKhoa.Focus();
                return;
            }

            // Kiểm tra mã lớp
            if (string.IsNullOrWhiteSpace(maLop))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã lớp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaLop.Focus();
                return;
            }

            // Kiểm tra tên lớp
            if (string.IsNullOrWhiteSpace(tenLop))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên lớp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenLop.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra mã lớp đã tồn tại chưa
                    string sqlKiemTra =
                        "SELECT COUNT(*) FROM Lop " +
                        "WHERE MaLop = @MaLop";

                    using (SqlCommand cmdKiemTra =
                        new SqlCommand(sqlKiemTra, conn))
                    {
                        cmdKiemTra.Parameters.Add(
                            "@MaLop", SqlDbType.NVarChar, 50)
                            .Value = maLop;

                        int soLuong = Convert.ToInt32(
                            cmdKiemTra.ExecuteScalar());

                        if (soLuong > 0)
                        {
                            MessageBox.Show(
                                "Mã lớp đã tồn tại!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtMaLop.Focus();
                            txtMaLop.SelectAll();
                            return;
                        }
                    }

                    // Thêm lớp mới vào bảng Lop
                    string sqlThem =
                        "INSERT INTO Lop " +
                        "(MaKhoa, MaLop, TenLop) " +
                        "VALUES (@MaKhoa, @MaLop, @TenLop)";

                    using (SqlCommand cmdThem =
                        new SqlCommand(sqlThem, conn))
                    {
                        cmdThem.Parameters.Add(
                            "@MaKhoa", SqlDbType.NVarChar, 50)
                            .Value = maKhoa;

                        cmdThem.Parameters.Add(
                            "@MaLop", SqlDbType.NVarChar, 50)
                            .Value = maLop;

                        cmdThem.Parameters.Add(
                            "@TenLop", SqlDbType.NVarChar, 200)
                            .Value = tenLop;

                        int ketQua = cmdThem.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show(
                                "Thêm lớp thành công!",
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

        // ==========================================
        // 4. CHỨC NĂNG XÓA LỚP
        // ==========================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();

            // Chỉ bắt buộc mã lớp
            if (string.IsNullOrWhiteSpace(maLop))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã lớp cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaLop.Focus();
                return;
            }

            // Không được nhập mã khoa
            if (!string.IsNullOrWhiteSpace(maKhoa))
            {
                MessageBox.Show(
                    "Khi xóa chỉ cần nhập mã lớp!\n" +
                    "Vui lòng để trống mã khoa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaKhoa.Focus();
                return;
            }

            // Không được nhập tên lớp
            if (!string.IsNullOrWhiteSpace(tenLop))
            {
                MessageBox.Show(
                    "Khi xóa chỉ cần nhập mã lớp!\n" +
                    "Vui lòng để trống tên lớp.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenLop.Focus();
                return;
            }

            // Xác nhận xóa
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa lớp có mã " +
                maLop + " không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Xóa lớp theo mã lớp
                    string sqlXoa =
                        "DELETE FROM Lop " +
                        "WHERE MaLop = @MaLop";

                    using (SqlCommand cmdXoa =
                        new SqlCommand(sqlXoa, conn))
                    {
                        cmdXoa.Parameters.Add(
                            "@MaLop", SqlDbType.NVarChar, 50)
                            .Value = maLop;

                        int ketQua = cmdXoa.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show(
                                "Xóa lớp thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            XoaDuLieuNhap();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy lớp có mã " +
                                maLop + "!",
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

        // ==========================================
        // 5. CHỨC NĂNG SỬA LỚP
        // ==========================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();

            // Mã lớp bắt buộc phải nhập
            if (string.IsNullOrWhiteSpace(maLop))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã lớp cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaLop.Focus();
                return;
            }

            // Mã khoa và tên lớp phải có ít nhất
            // một trường được nhập
            if (string.IsNullOrWhiteSpace(maKhoa) &&
                string.IsNullOrWhiteSpace(tenLop))
            {
                MessageBox.Show(
                    "Vui lòng nhập ít nhất một thông tin " +
                    "cần sửa:\n" +
                    "- Mã khoa\n" +
                    "- Tên lớp",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmdSua = new SqlCommand())
                    {
                        cmdSua.Connection = conn;

                        // Danh sách các trường cần sửa
                        List<string> cacTruongSua =
                            new List<string>();

                        // Nếu có nhập mã khoa thì sửa mã khoa
                        if (!string.IsNullOrWhiteSpace(maKhoa))
                        {
                            cacTruongSua.Add(
                                "MaKhoa = @MaKhoa");

                            cmdSua.Parameters.Add(
                                "@MaKhoa",
                                SqlDbType.NVarChar, 50)
                                .Value = maKhoa;
                        }

                        // Nếu có nhập tên lớp thì sửa tên lớp
                        if (!string.IsNullOrWhiteSpace(tenLop))
                        {
                            cacTruongSua.Add(
                                "TenLop = @TenLop");

                            cmdSua.Parameters.Add(
                                "@TenLop",
                                SqlDbType.NVarChar, 200)
                                .Value = tenLop;
                        }

                        // Tạo lệnh UPDATE dựa vào
                        // những trường có dữ liệu
                        string sqlSua =
                            "UPDATE Lop SET " +
                            string.Join(", ", cacTruongSua) +
                            " WHERE MaLop = @MaLop";

                        cmdSua.CommandText = sqlSua;

                        cmdSua.Parameters.Add(
                            "@MaLop", SqlDbType.NVarChar, 50)
                            .Value = maLop;

                        int ketQua = cmdSua.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show(
                                "Sửa thông tin lớp thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            XoaDuLieuNhap();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy lớp có mã " +
                                maLop + "!",
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

        // ==========================================
        // 6. XỬ LÝ LỖI SQL SERVER
        // ==========================================
        private void XuLyLoiSQL(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show(
                    "Mã lớp đã tồn tại hoặc dữ liệu bị trùng khóa!",
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (ex.Number == 547)
            {
                MessageBox.Show(
                    "Dữ liệu vi phạm ràng buộc khóa ngoại " +
                    "hoặc CHECK!\n" +
                    "Hãy kiểm tra mã khoa hoặc các dữ liệu " +
                    "đang liên kết với lớp.",
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
