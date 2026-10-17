using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Chọn một số trong ComboBox thì hiển thị ước số
            cboDanhSach.SelectedIndexChanged += cboDanhSach_SelectedIndexChanged;
            // HotKey: Alt + chữ cái được gạch chân trên nút
            btnCapNhat.Text = "&Cập nhật";
            btnTongCacUocSo.Text = "&Tổng uớc";
            btnSoLuongUocSoChan.Text = "Số &lượng chẵn";
            btnSoLuongUocSoNguyenTo.Text = "Số lượng &nguyên tố";
            btnThoat.Text = "T&hoát";
            // Không cho nhập trực tiếp vào ComboBox
            cboDanhSach.DropDownStyle = ComboBoxStyle.DropDownList;
            // Chỉ hiển thị ước số sau khi đã chọn số
            lstUocSo.Items.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void btnSoLuongUocSoChan_Click(object sender, EventArgs e)
        {
            List<int> dem = LayDanhSachUoc();
            if (dem.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một số trước!");
                return;
            }
            int soluong = dem.Count(x => x % 2 == 0);
            MessageBox.Show("số lượng ước chẵn là: "+ soluong, "kết quả: " , MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        // Kiểm tra số nguyên tố
        private bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            if(n==2) return true;
            for(int i =2; i<= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        //Đếm số lượng ước số nguyên tố
        private void btnSoLuongUocSoNguyenTo_Click(object sender, EventArgs e)
        {
            List<int> dem = LayDanhSachUoc();
            if(dem.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một số trước!");
                return;
            }
            int soluong = dem.Count(x => KiemTraNguyenTo(x));
            MessageBox.Show(
                "Số lượng ước số nguyên tố là: " + soluong,
                "Kết quả",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        //Thoát ứng dụng có xác nhận
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chăc là muốn thoát ứng dụng không?","Xác nhận",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //Tính tổng các ước số
        private void btnTongCacUocSo_Click(object sender, EventArgs e)
        {
            List<int> uocSo = LayDanhSachUoc();
            if (uocSo.Count == 0) {
                MessageBox.Show("Vui lòng chọn một số trước!");
                return;
            }
            int tong = uocSo.Sum();
            MessageBox.Show(
                "Tổng các ước số là: " + tong,
                "Kết quả",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        // Hiển thị danh sách ước số
        private void cboDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUocSo.Items.Clear();
            if(cboDanhSach.SelectedItem == null)
            {
                return;
            }
            int n = (int)cboDanhSach.SelectedItem ;
            for (int i =1; i<=n ; i++)
            {
                if(n%i == 0)
                {
                    lstUocSo.Items.Add(i);
                }
            } 
        }
         // Lấy các ước số hiện có trong ListBox
         private List<int> LayDanhSachUoc()
        {
            return lstUocSo.Items.Cast<int>().ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Xóa danh sách khi mới mở Form
            cboDanhSach.Items.Clear();
            lstUocSo.Items.Clear();

            // Đặt con trỏ vào TextBox nhập số
            txtNhap.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string input = txtNhap.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show(
                    "Vui lòng nhập số trước khi nhấn Cập nhật!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNhap.Focus();
                return;
            }

            if (!int.TryParse(input, out int n) || n <= 0)
            {
                MessageBox.Show(
                   "Vui lòng nhập số nguyên dương!",
                   "Dữ liệu không hợp lệ",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                txtNhap.Focus();
                txtNhap.SelectAll();
                return;
            }
            // Kiểm tra số đã tồn tại chưa
            if (cboDanhSach.Items.Contains(n))
            {
                MessageBox.Show(
                    "Số " + n + " đã tồn tại trong danh sách!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtNhap.Clear();
                txtNhap.Focus();
                return;
            }
            // Thêm số vào ComboBox
            cboDanhSach.Items.Add(n);
            // Chọn số vừa thêm để hiển thị các ước số
            cboDanhSach.SelectedItem = n;
            txtNhap.Clear();
            txtNhap.Focus();
        }
    }
}
