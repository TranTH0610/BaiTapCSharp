using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace DanhSachSinhVien
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

            // Gắn sự kiện cho Form
            Load += Form1_Load;

            // Gắn sự kiện cho nút Lọc dữ liệu
            btnLocDuLieu.Click += btnLocDuLieu_Click;
        }

        // ==========================================
        // 1. SỰ KIỆN FORM LOAD
        // ==========================================
        private void Form1_Load(object sender, EventArgs e)
        {
            // Không cho sửa dữ liệu trực tiếp
            dgvDanhSachSinhVien.ReadOnly = true;

            // Không cho thêm hoặc xóa dòng
            dgvDanhSachSinhVien.AllowUserToAddRows = false;
            dgvDanhSachSinhVien.AllowUserToDeleteRows = false;

            // Không cho sửa tổng điểm
            txtTongDiem.ReadOnly = true;

            // Hiển thị mã môn học lên ComboBox
            LoadMonHoc();

            // Hiển thị tất cả điểm sinh viên
            HienThiDanhSachSinhVien("");
        }

        // ==========================================
        // 2. HIỂN THỊ MÃ MÔN HỌC LÊN COMBOBOX
        // ==========================================
        private void LoadMonHoc()
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
                        // Xóa danh sách cũ
                        cboMonHoc.Items.Clear();

                        // Item đầu tiên là khoảng trắng
                        // Đại diện cho tất cả môn học
                        cboMonHoc.Items.Add(" ");

                        // Thêm từng mã môn học
                        while (reader.Read())
                        {
                            string maMonHoc =
                                reader["MaMonHoc"].ToString();

                            cboMonHoc.Items.Add(maMonHoc);
                        }
                    }
                }

                // Mặc định chọn tất cả môn học
                cboMonHoc.SelectedIndex = 0;
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
        // 3. HIỂN THỊ DANH SÁCH SINH VIÊN
        // ==========================================
        private void HienThiDanhSachSinhVien(string maMonHoc)
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Lấy dữ liệu từ ba bảng:
                    // SinhVien, Diem, MonHoc
                    string sql =
                        "SELECT " +
                        "sv.TenSinhVien, " +
                        "sv.NgaySinh, " +
                        "mh.TenMonHoc, " +
                        "d.Diem " +
                        "FROM SinhVien sv " +
                        "INNER JOIN Diem d " +
                        "ON sv.MaSinhVien = d.MaSinhVien " +
                        "INNER JOIN MonHoc mh " +
                        "ON d.MaMonHoc = mh.MaMonHoc " +
                        "WHERE (@MaMonHoc = N'' " +
                        "OR d.MaMonHoc = @MaMonHoc) " +
                        "ORDER BY sv.TenSinhVien, mh.TenMonHoc";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add(
                            "@MaMonHoc",
                            SqlDbType.NVarChar, 50)
                            .Value = maMonHoc;

                        using (SqlDataReader reader =
                            cmd.ExecuteReader())
                        {
                            // Xóa dữ liệu cũ
                            dgvDanhSachSinhVien.Rows.Clear();

                            int stt = 1;
                            decimal tongDiem = 0;

                            // Đọc từng dòng dữ liệu
                            while (reader.Read())
                            {
                                // Lấy tên sinh viên
                                string tenSV =
                                    reader["TenSinhVien"].ToString();

                                // Lấy ngày sinh
                                string ngaySinh = "";

                                if (reader["NgaySinh"] != DBNull.Value)
                                {
                                    DateTime ngay =
                                        Convert.ToDateTime(
                                            reader["NgaySinh"]);

                                    ngaySinh =
                                        ngay.ToString("dd/MM/yyyy");
                                }

                                // Lấy tên môn học
                                string tenMonHoc =
                                    reader["TenMonHoc"].ToString();

                                // Lấy điểm
                                decimal diem = 0;

                                if (reader["Diem"] != DBNull.Value)
                                {
                                    diem = Convert.ToDecimal(
                                        reader["Diem"]);
                                }

                                // Thêm dữ liệu vào DataGridView
                                dgvDanhSachSinhVien.Rows.Add(
                                    stt,
                                    tenSV,
                                    ngaySinh,
                                    tenMonHoc,
                                    diem.ToString(
                                        "0.##",
                                        CultureInfo.GetCultureInfo("vi-VN"))
                                );

                                // Tính tổng điểm
                                tongDiem += diem;

                                // Tăng số thứ tự
                                stt++;
                            }

                            // Hiển thị tổng điểm
                            txtTongDiem.Text =
                                tongDiem.ToString(
                                    "0.##",
                                    CultureInfo.GetCultureInfo("vi-VN"));
                        }
                    }
                }

                // Không chọn sẵn dòng trong bảng
                dgvDanhSachSinhVien.ClearSelection();
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
        // 4. NÚT LỌC DỮ LIỆU
        // ==========================================
        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cboMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn môn học!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboMonHoc.Focus();
                return;
            }

            // Lấy mã môn học đang chọn
            string maMonHoc =
                cboMonHoc.SelectedItem.ToString().Trim();

            // Nếu chọn khoảng trắng:
            // maMonHoc = ""
            // => Hiển thị tất cả môn học

            // Nếu chọn mã môn học cụ thể:
            // => Chỉ hiển thị điểm môn học đó

            HienThiDanhSachSinhVien(maMonHoc);
        }

        // ==========================================
        // 5. XỬ LÝ LỖI SQL SERVER
        // ==========================================
        private void XuLyLoiSQL(SqlException ex)
        {
            MessageBox.Show(
                "Lỗi SQL Server:\n" + ex.Message,
                "Lỗi cơ sở dữ liệu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
