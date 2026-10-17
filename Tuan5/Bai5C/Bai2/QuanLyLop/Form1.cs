using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            treeDanhSachLop.Nodes[0].Expand();
            chkThemLop.Checked = false;
            this.chkThemLop.Checked = false;
            this.chkThemLop.CheckState = System.Windows.Forms.CheckState.Unchecked;
            chkThemLop.CheckedChanged += chkThemLop_CheckedChanged;
        }
        //Hiện hoặc ẩn GroupBox Thông tin lớp
        private void chkThemLop_CheckedChanged(object sender, EventArgs e)
        {
            grpThongTinSinhVien.Visible = chkThemLop.Checked;
            if (chkThemLop.Checked)
            {
                txtTenLop.Focus();
            }
            else 
            {
                txtTenLop.Clear();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Ban đầu checkbox chưa được chọn
            chkThemLop.Checked = false;
            // Ẩn GroupBox Thông tin lớp
            grpThongTinSinhVien.Visible = false;
            // Không cho người dùng tự gõ tên lớp trong ComboBox
            cboChonLop.DropDownStyle = ComboBoxStyle.DropDownList;
            TreeNode nodeGoc = treeDanhSachLop.Nodes[0];
            // Nếu TreeView đã có sẵn các lớp thì đưa vào ComboBox
            cboChonLop.Items.Clear();
            foreach (TreeNode nodeLop in nodeGoc.Nodes)
            {
                cboChonLop.Items.Add(nodeLop.Text);
            }
            if (cboChonLop.Items.Count > 0)
            {
                cboChonLop.SelectedIndex = 0;
              
            }
            // Mặc định chọn lớp đầu tiên
            btnXoa.Enabled = false;
        }

        //Thêm lớp mới

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            string tenLop = txtTenLop.Text.Trim();
            if (string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Vui lòng nhập tên lớp!");
                txtTenLop.Focus();
                return;
            }
            TreeNode nodeGoc = treeDanhSachLop.Nodes[0];
            // Kiểm tra trùng tên lớp, không phân biệt hoa thường
            foreach (TreeNode nodeLop in nodeGoc.Nodes)
            {
                if (string.Equals(nodeLop.Text.Trim(), tenLop, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Tên lớp đã tồn tại!");
                    txtTenLop.Focus();
                    txtTenLop.SelectAll();
                    return;
                }
            }
            // Tạo node lớp mới
            TreeNode lopMoi= new TreeNode(tenLop);
            // Thêm vào TreeView
            nodeGoc.Nodes.Add(lopMoi);
           
            // Thêm vào ComboBox
            cboChonLop.Items.Add(tenLop);
            cboChonLop.SelectedItem = tenLop;
            // Chọn node lớp mới
            treeDanhSachLop.SelectedNode = lopMoi;
            // Mở rộng TreeView
            nodeGoc.Expand();
            // Xóa tên lớp vừa nhập
            txtTenLop.Clear();
            txtTenLop.Focus();
            MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TreeNode node = treeDanhSachLop.SelectedNode;
            if (node == null||!(node.Tag is SinhVien))
            {
                MessageBox.Show("Chỉ được phép xóa node sinh viên!");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên " + node.Text + "?",
        "Xác nhận xóa",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                node.Remove();

                txtMaSV.Clear();
                txtHoTen.Clear();
                txtDiaChi.Clear();

                btnXoa.Enabled = false;
            }
        }

        private void treeDanhSachLop_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;

            btnXoa.Enabled = node.Tag is SinhVien;

            if (node.Tag is SinhVien sv)
            {
                txtMaSV.Text = sv.MaSV;
                txtHoTen.Text = sv.HoTen;
                txtDiaChi.Text = sv.DiaChi;
            }
        }

        private void cboChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
            string maSV = txtMaSV.Text.Trim();
            string tenSV = txtHoTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
           // Kiểm tra các TextBox không được để trống
            if(string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(tenSV) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!");
                return;
            }
            // Phải chọn lớp trong ComboBox
            if(cboChonLop.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn lớp cho sinh viên!");
                cboChonLop.Focus();
                return;
            }
            // Kiểm tra mã sinh viên đã tồn tại trong toàn bộ TreeView chưa
            TreeNode nodeGoc = treeDanhSachLop.Nodes[0];
            foreach (TreeNode lop in nodeGoc.Nodes)
            {
                foreach (TreeNode nodeSV in lop.Nodes)
                {
                    if (nodeSV.Tag is SinhVien sv &&
                        string.Equals(sv.MaSV, maSV,
                            StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại!");

                        txtMaSV.Focus();
                        txtMaSV.SelectAll();
                        return;
                    }
                }
            }
            // Lấy tên lớp được chọn trong ComboBox
            string tenLop = cboChonLop.SelectedItem.ToString();

            TreeNode lopDuocChon = null;

            foreach (TreeNode nodeLop in nodeGoc.Nodes)
            {
                if (nodeLop.Text == tenLop)
                {
                    lopDuocChon = nodeLop;
                    break;
                }
            }

            if (lopDuocChon == null)
            {
                MessageBox.Show("Không tìm thấy lớp đã chọn!");
                return;
            }
            // Tạo đối tượng sinh viên
            SinhVien sinhVien = new SinhVien
            {
                MaSV = txtMaSV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
            };
            TreeNode nodeSv = new TreeNode(sinhVien.MaSV +" , " + sinhVien.HoTen + " , " + sinhVien.DiaChi );
            nodeSv.Tag = sinhVien;
            lopDuocChon.Nodes.Add(nodeSv);
            // Mở rộng lớp và sinh viên
            lopDuocChon.Expand();
            nodeSv.Expand();

            // Xóa các TextBox sau khi thêm
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();

            txtMaSV.Focus();
        }
    }
}
