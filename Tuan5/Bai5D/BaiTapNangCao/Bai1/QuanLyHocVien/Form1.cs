
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyHocVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Cho phép chọn nhiều học viên
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.SelectionMode = SelectionMode.MultiExtended;

            // Gắn sự kiện cho các MenuItem
            mnuNhapHocVien.Click += mnuNhapHocVien_Click;
            mnuChuyenSangLopA.Click += mnuChuyenSangLopA_Click;
            mnuChuyenSangLopB.Click += mnuChuyenSangLopB_Click;
            mnuXoaHocVien.Click += mnuXoaHocVien_Click;
            mnuKetThuc.Click += mnuKetThuc_Click;

            // Hỏi xác nhận khi đóng Form
            FormClosing += Form1_FormClosing;
        }

        // ==========================================
        // 1. NHẬP HỌC VIÊN MỚI
        // ==========================================
        private void mnuNhapHocVien_Click(object sender, EventArgs e)
        {
            // Mở Form2 để nhập thông tin học viên
            using (Form2 frm = new Form2())
            {
                // Nhận dữ liệu khi Form2 cập nhật
                frm.ThemHocVien += ThemHocVienVaoLop;

                frm.ShowDialog(this);
            }
        }

        // ==========================================
        // 2. THÊM HỌC VIÊN VÀO LỚP TƯƠNG ỨNG
        // ==========================================
        private void ThemHocVienVaoLop(string hoTen, string lop)
        {
            if (lop == "Lớp A")
            {
                lstLopA.Items.Add(hoTen);
            }
            else if (lop == "Lớp B")
            {
                lstLopB.Items.Add(hoTen);
            }
        }

        // ==========================================
        // 3. CHUYỂN HỌC VIÊN TỪ LỚP B SANG LỚP A
        // ==========================================
        private void mnuChuyenSangLopA_Click(object sender, EventArgs e)
        {
            // Kiểm tra học viên đang chọn trong lớp B
            if (lstLopB.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn học viên trong Lớp B trước!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                lstLopB.Focus();
                return;
            }

            // Lấy danh sách học viên đang chọn
            string[] hocVienChon = lstLopB.SelectedItems
                .Cast<string>()
                .ToArray();

            // Chuyển sang lớp A
            foreach (string hoTen in hocVienChon)
            {
                lstLopA.Items.Add(hoTen);
            }

            // Xóa khỏi lớp B
            foreach (string hoTen in hocVienChon)
            {
                lstLopB.Items.Remove(hoTen);
            }

            lstLopB.ClearSelected();
        }

        // ==========================================
        // 4. CHUYỂN HỌC VIÊN TỪ LỚP A SANG LỚP B
        // ==========================================
        private void mnuChuyenSangLopB_Click(object sender, EventArgs e)
        {
            // Kiểm tra học viên đang chọn trong lớp A
            if (lstLopA.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn học viên trong Lớp A trước!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                lstLopA.Focus();
                return;
            }

            // Lấy danh sách học viên đang chọn
            string[] hocVienChon = lstLopA.SelectedItems
                .Cast<string>()
                .ToArray();

            // Chuyển sang lớp B
            foreach (string hoTen in hocVienChon)
            {
                lstLopB.Items.Add(hoTen);
            }

            // Xóa khỏi lớp A
            foreach (string hoTen in hocVienChon)
            {
                lstLopA.Items.Remove(hoTen);
            }

            lstLopA.ClearSelected();
        }

        // ==========================================
        // 5. XÓA CÁC HỌC VIÊN ĐANG CHỌN Ở CẢ HAI LỚP
        // ==========================================
        private void mnuXoaHocVien_Click(object sender, EventArgs e)
        {
            int soLuongChon =
                lstLopA.SelectedItems.Count +
                lstLopB.SelectedItems.Count;

            if (soLuongChon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn học viên cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Xác nhận trước khi xóa
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa " +
                soLuongChon + " học viên đang chọn không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            // Xóa các học viên được chọn trong lớp A
            int[] viTriA = lstLopA.SelectedIndices
                .Cast<int>()
                .OrderByDescending(i => i)
                .ToArray();

            foreach (int i in viTriA)
            {
                lstLopA.Items.RemoveAt(i);
            }

            // Xóa các học viên được chọn trong lớp B
            int[] viTriB = lstLopB.SelectedIndices
                .Cast<int>()
                .OrderByDescending(i => i)
                .ToArray();

            foreach (int i in viTriB)
            {
                lstLopB.Items.RemoveAt(i);
            }

            MessageBox.Show(
                "Xóa học viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ==========================================
        // 6. KẾT THÚC CHƯƠNG TRÌNH
        // ==========================================
        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            // Gọi Close để FormClosing hỏi xác nhận
            this.Close();
        }

        // ==========================================
        // 7. HỎI XÁC NHẬN KHI ĐÓNG FORM
        // ==========================================
        private void Form1_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn kết thúc chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Chọn No thì không đóng
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
