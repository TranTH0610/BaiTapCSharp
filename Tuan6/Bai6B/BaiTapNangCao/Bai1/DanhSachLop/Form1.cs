using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DanhSachLop
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

            // Gắn sự kiện cho các Button
            // Designer chưa gắn sự kiện Click
            btnHienThiDuLieu.Click += btnHienThiDuLieu_Click;
            btnThoat.Click += btnThoat_Click;

            Load += Form1_Load;
        }

        // ==========================================
        // 1. KHI FORM ĐƯỢC LOAD
        // ==========================================
        private void Form1_Load(object sender, EventArgs e)
        {
            // Không cho phép chỉnh sửa dữ liệu trực tiếp
            dgvDanhSachLop.ReadOnly = true;

            // Không cho thêm hoặc xóa dòng thủ công
            dgvDanhSachLop.AllowUserToAddRows = false;
            dgvDanhSachLop.AllowUserToDeleteRows = false;

            // Chọn nguyên dòng
            dgvDanhSachLop.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // Không chọn sẵn dòng khi mở Form
            dgvDanhSachLop.ClearSelection();
        }

        // ==========================================
        // 2. HIỂN THỊ DỮ LIỆU LỚP
        // ==========================================
        private void btnHienThiDuLieu_Click(
            object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Lấy thông tin các lớp từ SQL Server
                    string sql =
                        "SELECT MaLop, TenLop, MaKhoa " +
                        "FROM Lop " +
                        "ORDER BY MaLop";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    using (SqlDataReader reader =
                        cmd.ExecuteReader())
                    {
                        // Xóa dữ liệu cũ trước khi hiển thị
                        dgvDanhSachLop.Rows.Clear();

                        int stt = 1;

                        // Đọc từng dòng dữ liệu từ SQL Server
                        while (reader.Read())
                        {
                            string maLop =
                                reader["MaLop"].ToString();

                            string tenLop =
                                reader["TenLop"].ToString();

                            string maKhoa =
                                reader["MaKhoa"].ToString();

                            // Thêm một dòng vào DataGridView
                            dgvDanhSachLop.Rows.Add(
                                stt,
                                maLop,
                                tenLop,
                                maKhoa);

                            stt++;
                        }
                    }
                }

                // Không chọn sẵn dòng nào
                dgvDanhSachLop.ClearSelection();

                // Thông báo nếu chưa có dữ liệu
                if (dgvDanhSachLop.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Bảng Lop hiện chưa có dữ liệu!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Lỗi SQL Server:\n" + ex.Message,
                    "Lỗi kết nối hoặc truy vấn",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // 3. CHỨC NĂNG THOÁT
        // ==========================================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
