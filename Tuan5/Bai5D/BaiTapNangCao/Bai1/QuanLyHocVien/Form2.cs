
using System;
using System.Windows.Forms;

namespace QuanLyHocVien
{
    public partial class Form2 : Form
    {
        // Sự kiện gửi họ tên và lớp về Form1
        public event Action<string, string> ThemHocVien;

        public Form2()
        {
            InitializeComponent();

            // Gắn sự kiện hai Button
            btnCapNhat.Click += btnCapNhat_Click;
            btnTroVe.Click += btnTroVe_Click;

            Load += Form2_Load;
        }

        // ==========================================
        // 1. KHI FORM2 LOAD
        // ==========================================
        private void Form2_Load(object sender, EventArgs e)
        {
            // Xóa nội dung mẫu trong TextBox
            txtHoTen.Clear();

            // ComboBox chỉ chứa Lớp A và Lớp B
            cboLop.Items.Clear();
            cboLop.Items.Add("Lớp A");
            cboLop.Items.Add("Lớp B");

            cboLop.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // Mặc định chọn Lớp A
            cboLop.SelectedIndex = 0;

            txtHoTen.Focus();
        }

        // ==========================================
        // 2. NÚT CẬP NHẬT
        // ==========================================
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();

            // Kiểm tra họ tên
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ và tên học viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtHoTen.Focus();
                return;
            }

            // Kiểm tra lớp được chọn
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

            // Lấy lớp được chọn
            string lop = cboLop.SelectedItem.ToString();

            // Gửi dữ liệu từ Form2 về Form1
            ThemHocVien?.Invoke(hoTen, lop);

            MessageBox.Show(
                "Cập nhật học viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Xóa họ tên để tiếp tục nhập học viên mới
            txtHoTen.Clear();
            txtHoTen.Focus();
        }

        // ==========================================
        // 3. NÚT TRỞ VỀ
        // ==========================================
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
