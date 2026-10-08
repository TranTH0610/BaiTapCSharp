namespace Bai2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhapMang;
        private System.Windows.Forms.TextBox txtNhapMang;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblKetQuaMang;
        private System.Windows.Forms.TextBox txtKetQuaMang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThucHien;

        private System.Windows.Forms.GroupBox grpSapXep;
        private System.Windows.Forms.RadioButton rdoSapXepTang;
        private System.Windows.Forms.RadioButton rdoSapXepGiam;

        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.RadioButton rdoTimGiaTri;
        private System.Windows.Forms.TextBox txtTimGiaTri;
        private System.Windows.Forms.RadioButton rdoTimViTri;
        private System.Windows.Forms.TextBox txtTimViTri;
        private System.Windows.Forms.Label lblSoTimDuoc;
        private System.Windows.Forms.TextBox txtSoTimDuoc;

        private System.Windows.Forms.GroupBox grpXoa;
        private System.Windows.Forms.RadioButton rdoXoaGiaTri;
        private System.Windows.Forms.TextBox txtXoaGiaTri;
        private System.Windows.Forms.RadioButton rdoXoaViTri;
        private System.Windows.Forms.TextBox txtXoaViTri;
        private System.Windows.Forms.Label lblCanSapXepTang1;

        private System.Windows.Forms.GroupBox grpThem;
        private System.Windows.Forms.RadioButton rdoThemGiaTri;
        private System.Windows.Forms.TextBox txtThemGiaTri;
        private System.Windows.Forms.Label lblTaiViTriThem;
        private System.Windows.Forms.TextBox txtTaiViTriThem;
        private System.Windows.Forms.Label lblCanSapXepTang2;

        private System.Windows.Forms.GroupBox grpTong;
        private System.Windows.Forms.Label lblTongMang;
        private System.Windows.Forms.TextBox txtTongMang;
        private System.Windows.Forms.Label lblTongChan;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.Label lblTongLe;
        private System.Windows.Forms.TextBox txtTongLe;
        private System.Windows.Forms.Button btnTinhTong;

        private System.Windows.Forms.GroupBox grpMaxMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Button btnTimMaxMin;

        private System.Windows.Forms.GroupBox grpThayThe;
        private System.Windows.Forms.RadioButton rdoThayTheGiaTri;
        private System.Windows.Forms.TextBox txtThayTheGiaTri;
        private System.Windows.Forms.RadioButton rdoThayTheViTri;
        private System.Windows.Forms.TextBox txtThayTheViTri;
        private System.Windows.Forms.Label lblSoThayThe;
        private System.Windows.Forms.TextBox txtSoThayThe;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNhapMang = new System.Windows.Forms.Label();
            this.txtNhapMang = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblKetQuaMang = new System.Windows.Forms.Label();
            this.txtKetQuaMang = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.grpSapXep = new System.Windows.Forms.GroupBox();
            this.rdoSapXepTang = new System.Windows.Forms.RadioButton();
            this.rdoSapXepGiam = new System.Windows.Forms.RadioButton();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.rdoTimGiaTri = new System.Windows.Forms.RadioButton();
            this.txtTimGiaTri = new System.Windows.Forms.TextBox();
            this.rdoTimViTri = new System.Windows.Forms.RadioButton();
            this.txtTimViTri = new System.Windows.Forms.TextBox();
            this.lblSoTimDuoc = new System.Windows.Forms.Label();
            this.txtSoTimDuoc = new System.Windows.Forms.TextBox();
            this.grpXoa = new System.Windows.Forms.GroupBox();
            this.rdoXoaGiaTri = new System.Windows.Forms.RadioButton();
            this.txtXoaGiaTri = new System.Windows.Forms.TextBox();
            this.rdoXoaViTri = new System.Windows.Forms.RadioButton();
            this.txtXoaViTri = new System.Windows.Forms.TextBox();
            this.lblCanSapXepTang1 = new System.Windows.Forms.Label();
            this.grpThem = new System.Windows.Forms.GroupBox();
            this.rdoThemGiaTri = new System.Windows.Forms.RadioButton();
            this.txtThemGiaTri = new System.Windows.Forms.TextBox();
            this.lblTaiViTriThem = new System.Windows.Forms.Label();
            this.txtTaiViTriThem = new System.Windows.Forms.TextBox();
            this.lblCanSapXepTang2 = new System.Windows.Forms.Label();
            this.grpTong = new System.Windows.Forms.GroupBox();
            this.lblTongMang = new System.Windows.Forms.Label();
            this.txtTongMang = new System.Windows.Forms.TextBox();
            this.lblTongChan = new System.Windows.Forms.Label();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.lblTongLe = new System.Windows.Forms.Label();
            this.txtTongLe = new System.Windows.Forms.TextBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.grpMaxMin = new System.Windows.Forms.GroupBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.btnTimMaxMin = new System.Windows.Forms.Button();
            this.grpThayThe = new System.Windows.Forms.GroupBox();
            this.rdoThayTheGiaTri = new System.Windows.Forms.RadioButton();
            this.txtThayTheGiaTri = new System.Windows.Forms.TextBox();
            this.rdoThayTheViTri = new System.Windows.Forms.RadioButton();
            this.txtThayTheViTri = new System.Windows.Forms.TextBox();
            this.lblSoThayThe = new System.Windows.Forms.Label();
            this.txtSoThayThe = new System.Windows.Forms.TextBox();
            this.grpSapXep.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.grpXoa.SuspendLayout();
            this.grpThem.SuspendLayout();
            this.grpTong.SuspendLayout();
            this.grpMaxMin.SuspendLayout();
            this.grpThayThe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(40, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mảng Số Nguyên";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNhapMang
            // 
            this.lblNhapMang.AutoSize = true;
            this.lblNhapMang.Location = new System.Drawing.Point(30, 75);
            this.lblNhapMang.Name = "lblNhapMang";
            this.lblNhapMang.Size = new System.Drawing.Size(83, 16);
            this.lblNhapMang.TabIndex = 1;
            this.lblNhapMang.Text = "Nhập mảng :";
            // 
            // txtNhapMang
            // 
            this.txtNhapMang.Location = new System.Drawing.Point(130, 73);
            this.txtNhapMang.Name = "txtNhapMang";
            this.txtNhapMang.Size = new System.Drawing.Size(260, 22);
            this.txtNhapMang.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(400, 71);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 30);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblKetQuaMang
            // 
            this.lblKetQuaMang.AutoSize = true;
            this.lblKetQuaMang.Location = new System.Drawing.Point(30, 115);
            this.lblKetQuaMang.Name = "lblKetQuaMang";
            this.lblKetQuaMang.Size = new System.Drawing.Size(95, 16);
            this.lblKetQuaMang.TabIndex = 4;
            this.lblKetQuaMang.Text = "Kết quả mảng :";
            // 
            // txtKetQuaMang
            // 
            this.txtKetQuaMang.Location = new System.Drawing.Point(130, 113);
            this.txtKetQuaMang.Name = "txtKetQuaMang";
            this.txtKetQuaMang.Size = new System.Drawing.Size(260, 22);
            this.txtKetQuaMang.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(400, 111);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 30);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(30, 155);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(90, 75);
            this.btnThucHien.TabIndex = 7;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            // 
            // grpSapXep
            // 
            this.grpSapXep.Controls.Add(this.rdoSapXepTang);
            this.grpSapXep.Controls.Add(this.rdoSapXepGiam);
            this.grpSapXep.Location = new System.Drawing.Point(130, 155);
            this.grpSapXep.Name = "grpSapXep";
            this.grpSapXep.Size = new System.Drawing.Size(350, 75);
            this.grpSapXep.TabIndex = 8;
            this.grpSapXep.TabStop = false;
            this.grpSapXep.Text = "Sắp Xếp";
            // 
            // rdoSapXepTang
            // 
            this.rdoSapXepTang.Checked = true;
            this.rdoSapXepTang.Location = new System.Drawing.Point(15, 30);
            this.rdoSapXepTang.Name = "rdoSapXepTang";
            this.rdoSapXepTang.Size = new System.Drawing.Size(140, 25);
            this.rdoSapXepTang.TabIndex = 0;
            this.rdoSapXepTang.TabStop = true;
            this.rdoSapXepTang.Text = "Sắp xếp Tăng";
            this.rdoSapXepTang.UseVisualStyleBackColor = true;
            // 
            // rdoSapXepGiam
            // 
            this.rdoSapXepGiam.Location = new System.Drawing.Point(180, 30);
            this.rdoSapXepGiam.Name = "rdoSapXepGiam";
            this.rdoSapXepGiam.Size = new System.Drawing.Size(140, 25);
            this.rdoSapXepGiam.TabIndex = 1;
            this.rdoSapXepGiam.Text = "Sắp xếp Giảm";
            this.rdoSapXepGiam.UseVisualStyleBackColor = true;
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.rdoTimGiaTri);
            this.grpTimKiem.Controls.Add(this.txtTimGiaTri);
            this.grpTimKiem.Controls.Add(this.rdoTimViTri);
            this.grpTimKiem.Controls.Add(this.txtTimViTri);
            this.grpTimKiem.Controls.Add(this.lblSoTimDuoc);
            this.grpTimKiem.Controls.Add(this.txtSoTimDuoc);
            this.grpTimKiem.Location = new System.Drawing.Point(12, 240);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(238, 115);
            this.grpTimKiem.TabIndex = 9;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm Kiếm";
            // 
            // rdoTimGiaTri
            // 
            this.rdoTimGiaTri.AutoSize = true;
            this.rdoTimGiaTri.Location = new System.Drawing.Point(15, 25);
            this.rdoTimGiaTri.Name = "rdoTimGiaTri";
            this.rdoTimGiaTri.Size = new System.Drawing.Size(131, 20);
            this.rdoTimGiaTri.TabIndex = 0;
            this.rdoTimGiaTri.Text = "Tìm giá trị cần tìm";
            this.rdoTimGiaTri.UseVisualStyleBackColor = true;
            // 
            // txtTimGiaTri
            // 
            this.txtTimGiaTri.Location = new System.Drawing.Point(160, 23);
            this.txtTimGiaTri.Name = "txtTimGiaTri";
            this.txtTimGiaTri.Size = new System.Drawing.Size(45, 22);
            this.txtTimGiaTri.TabIndex = 1;
            // 
            // rdoTimViTri
            // 
            this.rdoTimViTri.AutoSize = true;
            this.rdoTimViTri.Checked = true;
            this.rdoTimViTri.Location = new System.Drawing.Point(15, 55);
            this.rdoTimViTri.Name = "rdoTimViTri";
            this.rdoTimViTri.Size = new System.Drawing.Size(122, 20);
            this.rdoTimViTri.TabIndex = 2;
            this.rdoTimViTri.TabStop = true;
            this.rdoTimViTri.Text = "Tìm vị trí cần tìm";
            this.rdoTimViTri.UseVisualStyleBackColor = true;
            // 
            // txtTimViTri
            // 
            this.txtTimViTri.Location = new System.Drawing.Point(160, 53);
            this.txtTimViTri.Name = "txtTimViTri";
            this.txtTimViTri.Size = new System.Drawing.Size(45, 22);
            this.txtTimViTri.TabIndex = 3;
            // 
            // lblSoTimDuoc
            // 
            this.lblSoTimDuoc.AutoSize = true;
            this.lblSoTimDuoc.Location = new System.Drawing.Point(35, 85);
            this.lblSoTimDuoc.Name = "lblSoTimDuoc";
            this.lblSoTimDuoc.Size = new System.Drawing.Size(97, 16);
            this.lblSoTimDuoc.TabIndex = 4;
            this.lblSoTimDuoc.Text = "Số tìm được là :";
            // 
            // txtSoTimDuoc
            // 
            this.txtSoTimDuoc.Location = new System.Drawing.Point(160, 83);
            this.txtSoTimDuoc.Name = "txtSoTimDuoc";
            this.txtSoTimDuoc.Size = new System.Drawing.Size(45, 22);
            this.txtSoTimDuoc.TabIndex = 5;
            // 
            // grpXoa
            // 
            this.grpXoa.Controls.Add(this.rdoXoaGiaTri);
            this.grpXoa.Controls.Add(this.txtXoaGiaTri);
            this.grpXoa.Controls.Add(this.rdoXoaViTri);
            this.grpXoa.Controls.Add(this.txtXoaViTri);
            this.grpXoa.Controls.Add(this.lblCanSapXepTang1);
            this.grpXoa.Location = new System.Drawing.Point(260, 240);
            this.grpXoa.Name = "grpXoa";
            this.grpXoa.Size = new System.Drawing.Size(220, 115);
            this.grpXoa.TabIndex = 10;
            this.grpXoa.TabStop = false;
            this.grpXoa.Text = "Xóa";
            // 
            // rdoXoaGiaTri
            // 
            this.rdoXoaGiaTri.AutoSize = true;
            this.rdoXoaGiaTri.Location = new System.Drawing.Point(15, 25);
            this.rdoXoaGiaTri.Name = "rdoXoaGiaTri";
            this.rdoXoaGiaTri.Size = new System.Drawing.Size(136, 20);
            this.rdoXoaGiaTri.TabIndex = 0;
            this.rdoXoaGiaTri.Text = "Tìm giá trị cần xóa";
            this.rdoXoaGiaTri.UseVisualStyleBackColor = true;
            // 
            // txtXoaGiaTri
            // 
            this.txtXoaGiaTri.Location = new System.Drawing.Point(160, 23);
            this.txtXoaGiaTri.Name = "txtXoaGiaTri";
            this.txtXoaGiaTri.Size = new System.Drawing.Size(45, 22);
            this.txtXoaGiaTri.TabIndex = 1;
            // 
            // rdoXoaViTri
            // 
            this.rdoXoaViTri.AutoSize = true;
            this.rdoXoaViTri.Location = new System.Drawing.Point(15, 55);
            this.rdoXoaViTri.Name = "rdoXoaViTri";
            this.rdoXoaViTri.Size = new System.Drawing.Size(127, 20);
            this.rdoXoaViTri.TabIndex = 2;
            this.rdoXoaViTri.Text = "Tìm vị trí cần xóa";
            this.rdoXoaViTri.UseVisualStyleBackColor = true;
            // 
            // txtXoaViTri
            // 
            this.txtXoaViTri.Location = new System.Drawing.Point(160, 53);
            this.txtXoaViTri.Name = "txtXoaViTri";
            this.txtXoaViTri.Size = new System.Drawing.Size(45, 22);
            this.txtXoaViTri.TabIndex = 3;
            // 
            // lblCanSapXepTang1
            // 
            this.lblCanSapXepTang1.AutoSize = true;
            this.lblCanSapXepTang1.ForeColor = System.Drawing.Color.Red;
            this.lblCanSapXepTang1.Location = new System.Drawing.Point(55, 85);
            this.lblCanSapXepTang1.Name = "lblCanSapXepTang1";
            this.lblCanSapXepTang1.Size = new System.Drawing.Size(111, 16);
            this.lblCanSapXepTang1.TabIndex = 4;
            this.lblCanSapXepTang1.Text = "Cần sắp xếp tăng";
            // 
            // grpThem
            // 
            this.grpThem.Controls.Add(this.rdoThemGiaTri);
            this.grpThem.Controls.Add(this.txtThemGiaTri);
            this.grpThem.Controls.Add(this.lblTaiViTriThem);
            this.grpThem.Controls.Add(this.txtTaiViTriThem);
            this.grpThem.Controls.Add(this.lblCanSapXepTang2);
            this.grpThem.Location = new System.Drawing.Point(12, 365);
            this.grpThem.Name = "grpThem";
            this.grpThem.Size = new System.Drawing.Size(238, 105);
            this.grpThem.TabIndex = 11;
            this.grpThem.TabStop = false;
            this.grpThem.Text = "Thêm";
            // 
            // rdoThemGiaTri
            // 
            this.rdoThemGiaTri.AutoSize = true;
            this.rdoThemGiaTri.Location = new System.Drawing.Point(6, 25);
            this.rdoThemGiaTri.Name = "rdoThemGiaTri";
            this.rdoThemGiaTri.Size = new System.Drawing.Size(143, 20);
            this.rdoThemGiaTri.TabIndex = 0;
            this.rdoThemGiaTri.Text = "Tìm giá trị cần thêm";
            this.rdoThemGiaTri.UseVisualStyleBackColor = true;
            // 
            // txtThemGiaTri
            // 
            this.txtThemGiaTri.Location = new System.Drawing.Point(160, 23);
            this.txtThemGiaTri.Name = "txtThemGiaTri";
            this.txtThemGiaTri.Size = new System.Drawing.Size(45, 22);
            this.txtThemGiaTri.TabIndex = 1;
            // 
            // lblTaiViTriThem
            // 
            this.lblTaiViTriThem.AutoSize = true;
            this.lblTaiViTriThem.Location = new System.Drawing.Point(7, 55);
            this.lblTaiViTriThem.Name = "lblTaiViTriThem";
            this.lblTaiViTriThem.Size = new System.Drawing.Size(116, 16);
            this.lblTaiViTriThem.TabIndex = 2;
            this.lblTaiViTriThem.Text = "Tại vị trí cần thêm :";
            // 
            // txtTaiViTriThem
            // 
            this.txtTaiViTriThem.Location = new System.Drawing.Point(160, 53);
            this.txtTaiViTriThem.Name = "txtTaiViTriThem";
            this.txtTaiViTriThem.Size = new System.Drawing.Size(45, 22);
            this.txtTaiViTriThem.TabIndex = 3;
            // 
            // lblCanSapXepTang2
            // 
            this.lblCanSapXepTang2.AutoSize = true;
            this.lblCanSapXepTang2.ForeColor = System.Drawing.Color.Red;
            this.lblCanSapXepTang2.Location = new System.Drawing.Point(55, 80);
            this.lblCanSapXepTang2.Name = "lblCanSapXepTang2";
            this.lblCanSapXepTang2.Size = new System.Drawing.Size(111, 16);
            this.lblCanSapXepTang2.TabIndex = 4;
            this.lblCanSapXepTang2.Text = "Cần sắp xếp tăng";
            // 
            // grpTong
            // 
            this.grpTong.Controls.Add(this.lblTongMang);
            this.grpTong.Controls.Add(this.txtTongMang);
            this.grpTong.Controls.Add(this.lblTongChan);
            this.grpTong.Controls.Add(this.txtTongChan);
            this.grpTong.Controls.Add(this.lblTongLe);
            this.grpTong.Controls.Add(this.txtTongLe);
            this.grpTong.Controls.Add(this.btnTinhTong);
            this.grpTong.Location = new System.Drawing.Point(260, 365);
            this.grpTong.Name = "grpTong";
            this.grpTong.Size = new System.Drawing.Size(220, 105);
            this.grpTong.TabIndex = 12;
            this.grpTong.TabStop = false;
            this.grpTong.Text = "Tổng";
            // 
            // lblTongMang
            // 
            this.lblTongMang.AutoSize = true;
            this.lblTongMang.Location = new System.Drawing.Point(15, 23);
            this.lblTongMang.Name = "lblTongMang";
            this.lblTongMang.Size = new System.Drawing.Size(76, 16);
            this.lblTongMang.TabIndex = 0;
            this.lblTongMang.Text = "Tổng mảng";
            // 
            // txtTongMang
            // 
            this.txtTongMang.Location = new System.Drawing.Point(92, 21);
            this.txtTongMang.Name = "txtTongMang";
            this.txtTongMang.Size = new System.Drawing.Size(55, 22);
            this.txtTongMang.TabIndex = 1;
            // 
            // lblTongChan
            // 
            this.lblTongChan.AutoSize = true;
            this.lblTongChan.Location = new System.Drawing.Point(15, 51);
            this.lblTongChan.Name = "lblTongChan";
            this.lblTongChan.Size = new System.Drawing.Size(71, 16);
            this.lblTongChan.TabIndex = 2;
            this.lblTongChan.Text = "Tổng chẵn";
            // 
            // txtTongChan
            // 
            this.txtTongChan.Location = new System.Drawing.Point(92, 49);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.Size = new System.Drawing.Size(55, 22);
            this.txtTongChan.TabIndex = 3;
            // 
            // lblTongLe
            // 
            this.lblTongLe.AutoSize = true;
            this.lblTongLe.Location = new System.Drawing.Point(15, 79);
            this.lblTongLe.Name = "lblTongLe";
            this.lblTongLe.Size = new System.Drawing.Size(53, 16);
            this.lblTongLe.TabIndex = 4;
            this.lblTongLe.Text = "Tổng lẻ";
            // 
            // txtTongLe
            // 
            this.txtTongLe.Location = new System.Drawing.Point(92, 74);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.Size = new System.Drawing.Size(55, 22);
            this.txtTongLe.TabIndex = 5;
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(158, 17);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(62, 78);
            this.btnTinhTong.TabIndex = 6;
            this.btnTinhTong.Text = "Tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            // 
            // grpMaxMin
            // 
            this.grpMaxMin.Controls.Add(this.lblMax);
            this.grpMaxMin.Controls.Add(this.txtMax);
            this.grpMaxMin.Controls.Add(this.lblMin);
            this.grpMaxMin.Controls.Add(this.txtMin);
            this.grpMaxMin.Controls.Add(this.btnTimMaxMin);
            this.grpMaxMin.Location = new System.Drawing.Point(30, 480);
            this.grpMaxMin.Name = "grpMaxMin";
            this.grpMaxMin.Size = new System.Drawing.Size(220, 110);
            this.grpMaxMin.TabIndex = 13;
            this.grpMaxMin.TabStop = false;
            this.grpMaxMin.Text = "Max - Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(15, 30);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(90, 16);
            this.lblMax.TabIndex = 0;
            this.lblMax.Text = "Giá trị lớn nhất";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(115, 28);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(40, 22);
            this.txtMax.TabIndex = 1;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(15, 70);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(94, 16);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "Giá trị nhỏ nhất";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(115, 68);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(40, 22);
            this.txtMin.TabIndex = 3;
            // 
            // btnTimMaxMin
            // 
            this.btnTimMaxMin.Location = new System.Drawing.Point(165, 28);
            this.btnTimMaxMin.Name = "btnTimMaxMin";
            this.btnTimMaxMin.Size = new System.Drawing.Size(45, 62);
            this.btnTimMaxMin.TabIndex = 4;
            this.btnTimMaxMin.Text = "Tìm";
            this.btnTimMaxMin.UseVisualStyleBackColor = true;
            // 
            // grpThayThe
            // 
            this.grpThayThe.Controls.Add(this.rdoThayTheGiaTri);
            this.grpThayThe.Controls.Add(this.txtThayTheGiaTri);
            this.grpThayThe.Controls.Add(this.rdoThayTheViTri);
            this.grpThayThe.Controls.Add(this.txtThayTheViTri);
            this.grpThayThe.Controls.Add(this.lblSoThayThe);
            this.grpThayThe.Controls.Add(this.txtSoThayThe);
            this.grpThayThe.Location = new System.Drawing.Point(260, 480);
            this.grpThayThe.Name = "grpThayThe";
            this.grpThayThe.Size = new System.Drawing.Size(220, 110);
            this.grpThayThe.TabIndex = 14;
            this.grpThayThe.TabStop = false;
            this.grpThayThe.Text = "Thay Thế";
            // 
            // rdoThayTheGiaTri
            // 
            this.rdoThayTheGiaTri.AutoSize = true;
            this.rdoThayTheGiaTri.Location = new System.Drawing.Point(15, 22);
            this.rdoThayTheGiaTri.Name = "rdoThayTheGiaTri";
            this.rdoThayTheGiaTri.Size = new System.Drawing.Size(136, 20);
            this.rdoThayTheGiaTri.TabIndex = 0;
            this.rdoThayTheGiaTri.Text = "Giá trị cần thay thế";
            this.rdoThayTheGiaTri.UseVisualStyleBackColor = true;
            // 
            // txtThayTheGiaTri
            // 
            this.txtThayTheGiaTri.Location = new System.Drawing.Point(165, 20);
            this.txtThayTheGiaTri.Name = "txtThayTheGiaTri";
            this.txtThayTheGiaTri.Size = new System.Drawing.Size(40, 22);
            this.txtThayTheGiaTri.TabIndex = 1;
            // 
            // rdoThayTheViTri
            // 
            this.rdoThayTheViTri.AutoSize = true;
            this.rdoThayTheViTri.Location = new System.Drawing.Point(15, 50);
            this.rdoThayTheViTri.Name = "rdoThayTheViTri";
            this.rdoThayTheViTri.Size = new System.Drawing.Size(127, 20);
            this.rdoThayTheViTri.TabIndex = 2;
            this.rdoThayTheViTri.Text = "Vị trí cần thay thế";
            this.rdoThayTheViTri.UseVisualStyleBackColor = true;
            // 
            // txtThayTheViTri
            // 
            this.txtThayTheViTri.Location = new System.Drawing.Point(165, 48);
            this.txtThayTheViTri.Name = "txtThayTheViTri";
            this.txtThayTheViTri.Size = new System.Drawing.Size(40, 22);
            this.txtThayTheViTri.TabIndex = 3;
            // 
            // lblSoThayThe
            // 
            this.lblSoThayThe.AutoSize = true;
            this.lblSoThayThe.Location = new System.Drawing.Point(35, 78);
            this.lblSoThayThe.Name = "lblSoThayThe";
            this.lblSoThayThe.Size = new System.Drawing.Size(93, 16);
            this.lblSoThayThe.TabIndex = 4;
            this.lblSoThayThe.Text = "Số thay thế là :";
            // 
            // txtSoThayThe
            // 
            this.txtSoThayThe.Location = new System.Drawing.Point(165, 76);
            this.txtSoThayThe.Name = "txtSoThayThe";
            this.txtSoThayThe.Size = new System.Drawing.Size(40, 22);
            this.txtSoThayThe.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 650);
            this.Controls.Add(this.grpThayThe);
            this.Controls.Add(this.grpMaxMin);
            this.Controls.Add(this.grpTong);
            this.Controls.Add(this.grpThem);
            this.Controls.Add(this.grpXoa);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpSapXep);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtKetQuaMang);
            this.Controls.Add(this.lblKetQuaMang);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtNhapMang);
            this.Controls.Add(this.lblNhapMang);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mảng Số Nguyên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSapXep.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.grpXoa.ResumeLayout(false);
            this.grpXoa.PerformLayout();
            this.grpThem.ResumeLayout(false);
            this.grpThem.PerformLayout();
            this.grpTong.ResumeLayout(false);
            this.grpTong.PerformLayout();
            this.grpMaxMin.ResumeLayout(false);
            this.grpMaxMin.PerformLayout();
            this.grpThayThe.ResumeLayout(false);
            this.grpThayThe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}