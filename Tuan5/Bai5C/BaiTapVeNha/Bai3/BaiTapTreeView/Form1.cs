
using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapTreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện
            Load -= Form1_Load;
            Load += Form1_Load;

            btnAdd.Click -= btnAdd_Click;
            btnAdd.Click += btnAdd_Click;

            btnExit.Click -= btnExit_Click;
            btnExit.Click += btnExit_Click;
        }

        // ========================================
        // 1. KHI FORM ĐƯỢC LOAD
        // ========================================
        private void Form1_Load(object sender, EventArgs e)
        {
            // Xóa các node cũ
            treeView1.Nodes.Clear();

            // Tạo các node từ A đến Z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                TreeNode node = new TreeNode(c.ToString());

                treeView1.Nodes.Add(node);
            }

            // Đặt con trỏ vào ô nhập tên
            txtFirstName.Focus();
        }

        // ========================================
        // 2. HÀM BỎ DẤU TIẾNG VIỆT
        // ========================================
        private string BoDauTiengViet(string chuoi)
        {
            string ketQua = chuoi.Normalize(
                NormalizationForm.FormD);

            StringBuilder sb = new StringBuilder();

            foreach (char c in ketQua)
            {
                UnicodeCategory loaiKyTu =
                    CharUnicodeInfo.GetUnicodeCategory(c);

                if (loaiKyTu != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }

            ketQua = sb.ToString()
                .Normalize(NormalizationForm.FormC);

            // Xử lý riêng chữ Đ và đ
            ketQua = ketQua.Replace('Đ', 'D');
            ketQua = ketQua.Replace('đ', 'd');

            return ketQua;
        }

        // ========================================
        // 3. THÊM NGƯỜI VÀO DANH BẠ
        // ========================================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ hai TextBox
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            // Kiểm tra dữ liệu
            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ và tên đệm!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtLastName.Focus();
                return;
            }

            // Ghép họ tên hoàn chỉnh
            string hoTen = firstName + ", " + lastName;

            // Bỏ dấu tên để xác định chữ cái A-Z
            string tenKhongDau = BoDauTiengViet(firstName);

            // Lấy chữ cái đầu của tên
            char kyTuDau = char.ToUpperInvariant(
                tenKhongDau[0]);

            // Kiểm tra ký tự đầu hợp lệ
            if (kyTuDau < 'A' || kyTuDau > 'Z')
            {
                MessageBox.Show(
                    "Tên phải bắt đầu bằng một chữ cái!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtFirstName.Focus();
                return;
            }

            // Tìm node ứng với chữ cái đầu
            TreeNode nodeChuCai = null;

            foreach (TreeNode node in treeView1.Nodes)
            {
                if (node.Text == kyTuDau.ToString())
                {
                    nodeChuCai = node;
                    break;
                }
            }

            if (nodeChuCai == null)
            {
                MessageBox.Show(
                    "Không tìm thấy nhóm chữ cái phù hợp!");
                return;
            }

            // Kiểm tra trùng họ tên trong danh bạ
            foreach (TreeNode node in treeView1.Nodes)
            {
                foreach (TreeNode nodeNguoi in node.Nodes)
                {
                    if (string.Equals(
                        nodeNguoi.Text,
                        hoTen,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show(
                            "Người này đã có trong danh bạ!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        txtFirstName.Focus();
                        return;
                    }
                }
            }

            // Tạo node người mới
            TreeNode nodeMoi = new TreeNode(hoTen);

            // Thêm người vào đúng nhóm chữ cái
            nodeChuCai.Nodes.Add(nodeMoi);

            // Sắp xếp các tên trong nhóm
            var danhSach = nodeChuCai.Nodes
                .Cast<TreeNode>()
                .OrderBy(n => n.Text,
                    StringComparer.Create(
                        new CultureInfo("vi-VN"), true))
                .ToArray();

            nodeChuCai.Nodes.Clear();
            nodeChuCai.Nodes.AddRange(danhSach);

            // Mở rộng nhóm chữ cái
            nodeChuCai.Expand();

            // Chọn người vừa thêm
            treeView1.SelectedNode = nodeMoi;
            nodeMoi.EnsureVisible();

            MessageBox.Show(
                "Đã thêm " + hoTen + " vào nhóm " + kyTuDau,
                "Thêm thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Xóa nội dung để nhập người tiếp theo
            txtFirstName.Clear();
            txtLastName.Clear();

            txtFirstName.Focus();
        }

        // ========================================
        // 4. THOÁT CHƯƠNG TRÌNH
        // ========================================
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
