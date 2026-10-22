using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace SinhVien_Combo
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

            // Designer chưa gắn các sự kiện Click
            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;

            Load += Form1_Load;
        }

        // =========================================
        // 1. KHI FORM ĐƯỢC LOAD
        // =========================================
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập định dạng ngày sinh
            mskNgaySinh.Mask = "00/00/0000";
            mskNgaySinh.PromptChar = '_';

            // Lấy mã lớp từ SQL Server
            LoadDanhSachLop();

            txtMaSV.Focus();
        }

        // =========================================
        // 2. HIỂN THỊ MÃ LỚP LÊN COMBOBOX
        // =========================================
        private void LoadDanhSachLop()
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql =
                        "SELECT MaLop FROM Lop ORDER BY MaLop";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    using (SqlDataReader reader =
                        cmd.ExecuteReader())
                    {
                        // Xóa dữ liệu mẫu trong Designer
                        cboLop.Items.Clear();

                        while (reader.Read())
                        {
                            cboLop.Items.Add(
                                reader["MaLop"].ToString());
                        }
                    }
                }

                cboLop.SelectedIndex = -1;
            }
            catch (SqlException ex)
            {
                XuLyLoiSQL(ex);
            }
        }

        // =========================================
        // 3. XÓA DỮ LIỆU ĐANG NHẬP
        // =========================================
        private void XoaDuLieuNhap()
        {
            cboLop.SelectedIndex = -1;
            txtMaSV.Clear();
            txtHoTen.Clear();
            mskNgaySinh.Clear();

            txtMaSV.Focus();
        }

        // =========================================
        // 4. KIỂM TRA NGÀY SINH
        // =========================================
        private bool KiemTraNgaySinh(
            out DateTime ngaySinh)
        {
            ngaySinh = DateTime.MinValue;

            if (!mskNgaySinh.MaskCompleted)
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ ngày sinh!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                mskNgaySinh.Focus();
                return false;
            }

            bool hopLe = DateTime.TryParseExact(
                mskNgaySinh.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngaySinh);

            if (!hopLe)
            {
                MessageBox.Show(
                    "Ngày sinh không hợp lệ!\n" +
                    "Vui lòng nhập đúng ngày/tháng/năm.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                mskNgaySinh.Focus();
                return false;
            }

            if (ngaySinh.Date > DateTime.Today)
            {
                MessageBox.Show(
                    "Ngày sinh không được ở tương lai!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                mskNgaySinh.Focus();
                return false;
            }

            return true;
        }

        // =========================================
        // 5. KIỂM TRA TUỔI THEO NĂM SINH
        // =========================================
        private bool KiemTraTuoi(DateTime ngaySinh)
        {
            int tuoi = DateTime.Today.Year - ngaySinh.Year;

            if (tuoi < 17)
            {
                MessageBox.Show(
                    "Sinh viên phải từ 17 tuổi trở lên!\n" +
                    "Tuổi được tính theo năm sinh.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                mskNgaySinh.Focus();
                return false;
            }

            return true;
        }

        // =========================================
        // 6. THÊM SINH VIÊN
        // =========================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLop = cboLop.Text.Trim();
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();

            // Kiểm tra lớp
            if (cboLop.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn lớp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboLop.Focus();
                return;
            }

            // Kiểm tra mã sinh viên
            if (string.IsNullOrWhiteSpace(maSV))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã sinh viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaSV.Focus();
                return;
            }

            // Kiểm tra họ tên
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ tên sinh viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtHoTen.Focus();
                return;
            }

            // Kiểm tra ngày sinh
            if (!KiemTraNgaySinh(out DateTime ngaySinh))
                return;

            // Kiểm tra tuổi >= 17 theo năm sinh
            if (!KiemTraTuoi(ngaySinh))
                return;

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra khóa chính: mã sinh viên
                    string sqlKiemTra =
                        "SELECT COUNT(*) FROM SinhVien " +
                        "WHERE MaSinhVien = @MaSV";

                    using (SqlCommand cmd =
                        new SqlCommand(sqlKiemTra, conn))
                    {
                        cmd.Parameters.Add(
                            "@MaSV", SqlDbType.NVarChar, 50)
                            .Value = maSV;

                        int soLuong = Convert.ToInt32(
                            cmd.ExecuteScalar());

                        if (soLuong > 0)
                        {
                            MessageBox.Show(
                                "Mã sinh viên đã tồn tại!\n" +
                                "Vui lòng nhập mã khác.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtMaSV.Focus();
                            txtMaSV.SelectAll();
                            return;
                        }
                    }

                    // Thêm sinh viên
                    string sqlThem =
                        "INSERT INTO SinhVien " +
                        "(MaLop, MaSinhVien, TenSinhVien, NgaySinh) " +
                        "VALUES (@MaLop, @MaSV, @HoTen, @NgaySinh)";

                    using (SqlCommand cmd =
                        new SqlCommand(sqlThem, conn))
                    {
                        cmd.Parameters.Add(
                            "@MaLop", SqlDbType.NVarChar, 50)
                            .Value = maLop;

                        cmd.Parameters.Add(
                            "@MaSV", SqlDbType.NVarChar, 50)
                            .Value = maSV;

                        cmd.Parameters.Add(
                            "@HoTen", SqlDbType.NVarChar, 200)
                            .Value = hoTen;

                        cmd.Parameters.Add(
                            "@NgaySinh", SqlDbType.Date)
                            .Value = ngaySinh.Date;

                        int ketQua = cmd.ExecuteNonQuery();

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
        // 7. XÓA SINH VIÊN THEO MÃ
        // =========================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();

            // Chỉ cần nhập mã sinh viên
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

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra sinh viên có tồn tại không
                    string sqlKiemTra =
                        "SELECT COUNT(*) FROM SinhVien " +
                        "WHERE MaSinhVien = @MaSV";

                    using (SqlCommand cmd =
                        new SqlCommand(sqlKiemTra, conn))
                    {
                        cmd.Parameters.Add(
                            "@MaSV", SqlDbType.NVarChar, 50)
                            .Value = maSV;

                        int soLuong = Convert.ToInt32(
                            cmd.ExecuteScalar());

                        if (soLuong == 0)
                        {
                            MessageBox.Show(
                                "Không tìm thấy sinh viên có mã " +
                                maSV + "!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }

                    // Hỏi xác nhận trước khi xóa
                    DialogResult result = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa sinh viên " +
                        "có mã " + maSV + " không?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result != DialogResult.Yes)
                        return;

                    // Xóa sinh viên theo mã
                    string sqlXoa =
                        "DELETE FROM SinhVien " +
                        "WHERE MaSinhVien = @MaSV";

                    using (SqlCommand cmd =
                        new SqlCommand(sqlXoa, conn))
                    {
                        cmd.Parameters.Add(
                            "@MaSV", SqlDbType.NVarChar, 50)
                            .Value = maSV;

                        int ketQua = cmd.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show(
                                "Xóa sinh viên thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            XoaDuLieuNhap();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy sinh viên cần xóa!",
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
        // 8. SỬA THÔNG TIN SINH VIÊN
        // =========================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();

            // Mã sinh viên là khóa chính
            if (string.IsNullOrWhiteSpace(maSV))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã sinh viên cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaSV.Focus();
                return;
            }

            bool suaLop = cboLop.SelectedIndex >= 0;
            bool suaHoTen = !string.IsNullOrWhiteSpace(hoTen);
            bool suaNgaySinh =
                mskNgaySinh.MaskedTextProvider
                    .AssignedEditPositionCount > 0;

            if (!suaLop && !suaHoTen && !suaNgaySinh)
            {
                MessageBox.Show(
                    "Vui lòng nhập ít nhất một thông tin cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DateTime ngaySinh = DateTime.MinValue;

            if (suaNgaySinh)
            {
                if (!KiemTraNgaySinh(out ngaySinh))
                    return;

                if (!KiemTraTuoi(ngaySinh))
                    return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Chỉ cập nhật trường được nhập
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;

                        System.Collections.Generic.List<string> truongSua =
                            new System.Collections.Generic.List<string>();

                        if (suaLop)
                        {
                            truongSua.Add("MaLop = @MaLop");

                            cmd.Parameters.Add(
                                "@MaLop", SqlDbType.NVarChar, 50)
                                .Value = cboLop.Text.Trim();
                        }

                        if (suaHoTen)
                        {
                            truongSua.Add(
                                "TenSinhVien = @HoTen");

                            cmd.Parameters.Add(
                                "@HoTen", SqlDbType.NVarChar, 200)
                                .Value = hoTen;
                        }

                        if (suaNgaySinh)
                        {
                            truongSua.Add(
                                "NgaySinh = @NgaySinh");

                            cmd.Parameters.Add(
                                "@NgaySinh", SqlDbType.Date)
                                .Value = ngaySinh.Date;
                        }

                        cmd.CommandText =
                            "UPDATE SinhVien SET " +
                            string.Join(", ", truongSua) +
                            " WHERE MaSinhVien = @MaSV";

                        cmd.Parameters.Add(
                            "@MaSV", SqlDbType.NVarChar, 50)
                            .Value = maSV;

                        int ketQua = cmd.ExecuteNonQuery();

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
        // 9. XỬ LÝ KHÓA CHÍNH / KHÓA NGOẠI
        // =========================================
        private void XuLyLoiSQL(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show(
                    "Mã sinh viên đã tồn tại hoặc " +
                    "dữ liệu bị trùng khóa!",
                    "Lỗi khóa chính",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (ex.Number == 547)
            {
                MessageBox.Show(
                    "Không thể thực hiện thao tác vì " +
                    "vi phạm ràng buộc khóa ngoại hoặc CHECK.\n" +
                    "Hãy kiểm tra mã lớp hoặc dữ liệu " +
                    "liên quan đến sinh viên!",
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
