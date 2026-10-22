using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Diem_Combo
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

            // Designer chưa gắn sự kiện Click
            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;

            Load += Form1_Load;
        }

        // ==========================================
        // 1. KHI FORM ĐƯỢC LOAD
        // ==========================================
        private void Form1_Load(object sender, EventArgs e)
        {
            cboSinhVien.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboMonHoc.DropDownStyle =
                ComboBoxStyle.DropDownList;

            LoadDanhSachSinhVien();
            LoadDanhSachMonHoc();

            XoaDuLieuNhap();
        }

        // ==========================================
        // 2. HIỂN THỊ MÃ SINH VIÊN LÊN COMBOBOX
        // ==========================================
        private void LoadDanhSachSinhVien()
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql =
                        "SELECT MaSinhVien FROM SinhVien " +
                        "ORDER BY MaSinhVien";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    using (SqlDataReader reader =
                        cmd.ExecuteReader())
                    {
                        cboSinhVien.Items.Clear();

                        while (reader.Read())
                        {
                            cboSinhVien.Items.Add(
                                reader["MaSinhVien"].ToString());
                        }
                    }
                }

                cboSinhVien.SelectedIndex = -1;
            }
            catch (SqlException ex)
            {
                XuLyLoiSQL(ex);
            }
        }

        // ==========================================
        // 3. HIỂN THỊ MÃ MÔN HỌC LÊN COMBOBOX
        // ==========================================
        private void LoadDanhSachMonHoc()
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql =
                        "SELECT MaMonHoc FROM MonHoc " +
                        "ORDER BY MaMonHoc";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    using (SqlDataReader reader =
                        cmd.ExecuteReader())
                    {
                        cboMonHoc.Items.Clear();

                        while (reader.Read())
                        {
                            cboMonHoc.Items.Add(
                                reader["MaMonHoc"].ToString());
                        }
                    }
                }

                cboMonHoc.SelectedIndex = -1;
            }
            catch (SqlException ex)
            {
                XuLyLoiSQL(ex);
            }
        }

        // ==========================================
        // 4. XÓA DỮ LIỆU NHẬP TRÊN FORM
        // ==========================================
        private void XoaDuLieuNhap()
        {
            cboSinhVien.SelectedIndex = -1;
            cboMonHoc.SelectedIndex = -1;

            txtDiem.Clear();

            cboSinhVien.Focus();
        }

        // ==========================================
        // 5. KIỂM TRA COMBOBOX
        // ==========================================
        private bool KiemTraMa()
        {
            if (cboSinhVien.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn mã sinh viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboSinhVien.Focus();
                return false;
            }

            if (cboMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn mã môn học!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboMonHoc.Focus();
                return false;
            }

            return true;
        }

        // ==========================================
        // 6. KIỂM TRA ĐIỂM TỪ 0 ĐẾN 10
        // ==========================================
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

            // Chấp nhận cả dấu phẩy và dấu chấm
            string diemChuan = giaTri.Replace(',', '.');

            bool hopLe = decimal.TryParse(
                diemChuan,
                NumberStyles.AllowLeadingSign |
                NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture,
                out diem);

            if (!hopLe)
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

            if (diem < 0 || diem > 10)
            {
                MessageBox.Show(
                    "Điểm phải nằm trong khoảng từ 0 đến 10!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDiem.Focus();
                txtDiem.SelectAll();
                return false;
            }

            return true;
        }

        // ==========================================
        // 7. KIỂM TRA MÃ CÓ TỒN TẠI TRONG SQL KHÔNG
        // ==========================================
        private bool KiemTraTonTai(
            SqlConnection conn,
            string sql,
            string tenThamSo,
            string giaTri)
        {
            using (SqlCommand cmd =
                new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add(
                    tenThamSo, SqlDbType.NVarChar, 50)
                    .Value = giaTri;

                return Convert.ToInt32(
                    cmd.ExecuteScalar()) > 0;
            }
        }

        // ==========================================
        // 8. THÊM ĐIỂM
        // ==========================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraMa())
                return;

            if (!KiemTraDiem(out decimal diem))
                return;

            string maSV = cboSinhVien.Text.Trim();
            string maMonHoc = cboMonHoc.Text.Trim();

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra mã sinh viên tồn tại
                    bool sinhVienTonTai = KiemTraTonTai(
                        conn,
                        "SELECT COUNT(*) FROM SinhVien " +
                        "WHERE MaSinhVien = @MaSV",
                        "@MaSV",
                        maSV);

                    if (!sinhVienTonTai)
                    {
                        MessageBox.Show(
                            "Mã sinh viên không tồn tại!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    // Kiểm tra mã môn học tồn tại
                    bool monHocTonTai = KiemTraTonTai(
                        conn,
                        "SELECT COUNT(*) FROM MonHoc " +
                        "WHERE MaMonHoc = @MaMonHoc",
                        "@MaMonHoc",
                        maMonHoc);

                    if (!monHocTonTai)
                    {
                        MessageBox.Show(
                            "Mã môn học không tồn tại!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    // Kiểm tra trùng khóa chính
                    // gồm mã sinh viên và mã môn học
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
                                "Sinh viên đã có điểm của môn học này!\n" +
                                "Không thể thêm trùng khóa chính.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }

                    // Thêm dữ liệu vào bảng Điểm
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

                        SqlParameter pDiem =
                            cmd.Parameters.Add(
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

        // ==========================================
        // 9. XÓA ĐIỂM
        // ==========================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!KiemTraMa())
                return;

            string maSV = cboSinhVien.Text.Trim();
            string maMonHoc = cboMonHoc.Text.Trim();

            // Khi xóa không cần nhập điểm
            if (!string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show(
                    "Khi xóa, vui lòng để trống ô Điểm!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDiem.Focus();
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa điểm?\n" +
                "Mã sinh viên: " + maSV + "\n" +
                "Mã môn học: " + maMonHoc,
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
                                "Không tìm thấy điểm tương ứng " +
                                "với sinh viên và môn học đã chọn!",
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
        // 10. SỬA ĐIỂM
        // ==========================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraMa())
                return;

            if (!KiemTraDiem(out decimal diemMoi))
                return;

            string maSV = cboSinhVien.Text.Trim();
            string maMonHoc = cboMonHoc.Text.Trim();

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlSua =
                        "UPDATE Diem SET Diem = @Diem " +
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

                        SqlParameter pDiem =
                            cmd.Parameters.Add(
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
                                "Không tìm thấy điểm của sinh viên " +
                                "ở môn học đã chọn!",
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
        // 11. XỬ LÝ LỖI KHÓA CHÍNH / KHÓA NGOẠI
        // ==========================================
        private void XuLyLoiSQL(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show(
                    "Dữ liệu bị trùng khóa chính!\n" +
                    "Sinh viên đã có điểm ở môn học này.",
                    "Lỗi khóa chính",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (ex.Number == 547)
            {
                MessageBox.Show(
                    "Không thể thực hiện thao tác vì " +
                    "vi phạm ràng buộc khóa ngoại hoặc CHECK.\n" +
                    "Hãy kiểm tra mã sinh viên, mã môn học " +
                    "và giá trị điểm!",
                    "Lỗi ràng buộc dữ liệu",
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
