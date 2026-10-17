
namespace QuanLyLop
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("05DHTH1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("05DHTH2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("05DHTH3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("05DHTH4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Danh sách lớp", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeDanhSachLop = new System.Windows.Forms.TreeView();
            this.lblChonLop = new System.Windows.Forms.Label();
            this.cboChonLop = new System.Windows.Forms.ComboBox();
            this.grpThongTinSinhVien = new System.Windows.Forms.GroupBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.chkThemLop = new System.Windows.Forms.CheckBox();
            this.grpThemLop = new System.Windows.Forms.GroupBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.grpThongTinSinhVien.SuspendLayout();
            this.grpThemLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeDanhSachLop
            // 
            this.treeDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.treeDanhSachLop.Location = new System.Drawing.Point(15, 15);
            this.treeDanhSachLop.Name = "treeDanhSachLop";
            treeNode1.Name = "";
            treeNode1.Text = "05DHTH1";
            treeNode2.Name = "";
            treeNode2.Text = "05DHTH2";
            treeNode3.Name = "";
            treeNode3.Text = "05DHTH3";
            treeNode4.Name = "";
            treeNode4.Text = "05DHTH4";
            treeNode5.Name = "nodeGoc";
            treeNode5.Text = "Danh sách lớp";
            this.treeDanhSachLop.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeDanhSachLop.Size = new System.Drawing.Size(240, 410);
            this.treeDanhSachLop.TabIndex = 0;
            this.treeDanhSachLop.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDanhSachLop_AfterSelect);
            // 
            // lblChonLop
            // 
            this.lblChonLop.AutoSize = true;
            this.lblChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblChonLop.Location = new System.Drawing.Point(273, 25);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(81, 20);
            this.lblChonLop.TabIndex = 1;
            this.lblChonLop.Text = "Chọn Lớp";
            // 
            // cboChonLop
            // 
            this.cboChonLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboChonLop.FormattingEnabled = true;
            this.cboChonLop.Items.AddRange(new object[] {
            "05DHTH1",
            "05DHTH2",
            "05DHTH3",
            "05DHTH4"});
            this.cboChonLop.Location = new System.Drawing.Point(375, 22);
            this.cboChonLop.Name = "cboChonLop";
            this.cboChonLop.Size = new System.Drawing.Size(250, 28);
            this.cboChonLop.TabIndex = 1;
            this.cboChonLop.SelectedIndexChanged += new System.EventHandler(this.cboChonLop_SelectedIndexChanged);
            // 
            // grpThongTinSinhVien
            // 
            this.grpThongTinSinhVien.Controls.Add(this.lblMaSV);
            this.grpThongTinSinhVien.Controls.Add(this.lblHoTen);
            this.grpThongTinSinhVien.Controls.Add(this.lblDiaChi);
            this.grpThongTinSinhVien.Controls.Add(this.txtMaSV);
            this.grpThongTinSinhVien.Controls.Add(this.txtHoTen);
            this.grpThongTinSinhVien.Controls.Add(this.txtDiaChi);
            this.grpThongTinSinhVien.Controls.Add(this.btnCapNhat);
            this.grpThongTinSinhVien.Controls.Add(this.btnXoa);
            this.grpThongTinSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpThongTinSinhVien.Location = new System.Drawing.Point(265, 65);
            this.grpThongTinSinhVien.Name = "grpThongTinSinhVien";
            this.grpThongTinSinhVien.Size = new System.Drawing.Size(375, 215);
            this.grpThongTinSinhVien.TabIndex = 2;
            this.grpThongTinSinhVien.TabStop = false;
            this.grpThongTinSinhVien.Text = "Thông tin sinh viên";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(8, 35);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(64, 20);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã SV:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(6, 85);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(69, 20);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ Tên:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(8, 132);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(69, 20);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa Chỉ:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(100, 32);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(260, 26);
            this.txtMaSV.TabIndex = 0;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(100, 82);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(260, 26);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(100, 132);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(260, 26);
            this.txtDiaChi.TabIndex = 2;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(100, 175);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(140, 30);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(260, 175);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // chkThemLop
            // 
            this.chkThemLop.AutoSize = true;
            this.chkThemLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkThemLop.Location = new System.Drawing.Point(265, 295);
            this.chkThemLop.Name = "chkThemLop";
            this.chkThemLop.Size = new System.Drawing.Size(100, 24);
            this.chkThemLop.TabIndex = 3;
            this.chkThemLop.Text = "Thêm lớp";
            this.chkThemLop.UseVisualStyleBackColor = false;
                this.chkThemLop.CheckedChanged += new System.EventHandler(this.chkThemLop_CheckedChanged);
            // 
            // grpThemLop
            // 
            this.grpThemLop.Controls.Add(this.lblTenLop);
            this.grpThemLop.Controls.Add(this.txtTenLop);
            this.grpThemLop.Controls.Add(this.btnThemLop);
            this.grpThemLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpThemLop.Location = new System.Drawing.Point(265, 325);
            this.grpThemLop.Name = "grpThemLop";
            this.grpThemLop.Size = new System.Drawing.Size(375, 100);
            this.grpThemLop.TabIndex = 4;
            this.grpThemLop.TabStop = false;
            this.grpThemLop.Text = "Thông tin lớp";
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(20, 35);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(64, 20);
            this.lblTenLop.TabIndex = 0;
            this.lblTenLop.Text = "Tên lớp";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(100, 32);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(150, 26);
            this.txtTenLop.TabIndex = 0;
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(265, 30);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(104, 30);
            this.btnThemLop.TabIndex = 1;
            this.btnThemLop.Text = "Thêm lớp";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 445);
            this.Controls.Add(this.treeDanhSachLop);
            this.Controls.Add(this.lblChonLop);
            this.Controls.Add(this.cboChonLop);
            this.Controls.Add(this.grpThongTinSinhVien);
            this.Controls.Add(this.chkThemLop);
            this.Controls.Add(this.grpThemLop);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.grpThongTinSinhVien.ResumeLayout(false);
            this.grpThongTinSinhVien.PerformLayout();
            this.grpThemLop.ResumeLayout(false);
            this.grpThemLop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeDanhSachLop;
        private System.Windows.Forms.Label lblChonLop;
        private System.Windows.Forms.ComboBox cboChonLop;

        private System.Windows.Forms.GroupBox grpThongTinSinhVien;

        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblDiaChi;

        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;

        private System.Windows.Forms.CheckBox chkThemLop;
        private System.Windows.Forms.GroupBox grpThemLop;

        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Button btnThemLop;
    }
}
