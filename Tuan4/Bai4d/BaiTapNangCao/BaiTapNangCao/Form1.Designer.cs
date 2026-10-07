namespace BaiTapNangCao
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lblSoKhachHang;
        private System.Windows.Forms.TextBox txtSoKhachHang;

        private System.Windows.Forms.CheckBox chkSinhVien;

        private System.Windows.Forms.GroupBox grpNuocUong;
        private System.Windows.Forms.RadioButton rdoCafeDen;
        private System.Windows.Forms.RadioButton rdoCafeDa;
        private System.Windows.Forms.RadioButton rdoCafeSua;
        private System.Windows.Forms.RadioButton rdoCafeKem;
        private System.Windows.Forms.RadioButton rdoCafeSuaDa;

        private System.Windows.Forms.GroupBox grpThucAn;
        private System.Windows.Forms.CheckBox chkBanMyTrung;
        private System.Windows.Forms.CheckBox chkMyXaoBo;
        private System.Windows.Forms.CheckBox chkBanMyCa;
        private System.Windows.Forms.CheckBox chkMyCay;
        private System.Windows.Forms.CheckBox chkMyTomTrung;

        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.Label lblTongKhachHang;
        private System.Windows.Forms.TextBox txtTongKhachHang;
        private System.Windows.Forms.TextBox txtTongKhachHangExtra;

        private System.Windows.Forms.Label lblTongTienThanhToan;
        private System.Windows.Forms.TextBox txtTongTienThanhToan;

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
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lblSoKhachHang = new System.Windows.Forms.Label();
            this.txtSoKhachHang = new System.Windows.Forms.TextBox();
            this.chkSinhVien = new System.Windows.Forms.CheckBox();
            this.grpNuocUong = new System.Windows.Forms.GroupBox();
            this.rdoCafeDen = new System.Windows.Forms.RadioButton();
            this.rdoCafeDa = new System.Windows.Forms.RadioButton();
            this.rdoCafeSua = new System.Windows.Forms.RadioButton();
            this.rdoCafeKem = new System.Windows.Forms.RadioButton();
            this.rdoCafeSuaDa = new System.Windows.Forms.RadioButton();
            this.grpThucAn = new System.Windows.Forms.GroupBox();
            this.chkBanMyTrung = new System.Windows.Forms.CheckBox();
            this.chkMyXaoBo = new System.Windows.Forms.CheckBox();
            this.chkBanMyCa = new System.Windows.Forms.CheckBox();
            this.chkMyCay = new System.Windows.Forms.CheckBox();
            this.chkMyTomTrung = new System.Windows.Forms.CheckBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTongKhachHang = new System.Windows.Forms.Label();
            this.txtTongKhachHang = new System.Windows.Forms.TextBox();
            this.txtTongKhachHangExtra = new System.Windows.Forms.TextBox();
            this.lblTongTienThanhToan = new System.Windows.Forms.Label();
            this.txtTongTienThanhToan = new System.Windows.Forms.TextBox();
            this.grpNuocUong.SuspendLayout();
            this.grpThucAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Orange;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(440, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CAFE SINH VIÊN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(30, 70);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(103, 16);
            this.lblTenKhachHang.TabIndex = 1;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(150, 68);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(320, 22);
            this.txtTenKhachHang.TabIndex = 2;
            // 
            // lblSoKhachHang
            // 
            this.lblSoKhachHang.AutoSize = true;
            this.lblSoKhachHang.Location = new System.Drawing.Point(30, 105);
            this.lblSoKhachHang.Name = "lblSoKhachHang";
            this.lblSoKhachHang.Size = new System.Drawing.Size(96, 16);
            this.lblSoKhachHang.TabIndex = 3;
            this.lblSoKhachHang.Text = "Số khách hàng";
            // 
            // txtSoKhachHang
            // 
            this.txtSoKhachHang.Location = new System.Drawing.Point(150, 103);
            this.txtSoKhachHang.Name = "txtSoKhachHang";
            this.txtSoKhachHang.Size = new System.Drawing.Size(320, 22);
            this.txtSoKhachHang.TabIndex = 4;
            // 
            // chkSinhVien
            // 
            this.chkSinhVien.AutoSize = true;
            this.chkSinhVien.Location = new System.Drawing.Point(350, 140);
            this.chkSinhVien.Name = "chkSinhVien";
            this.chkSinhVien.Size = new System.Drawing.Size(93, 20);
            this.chkSinhVien.TabIndex = 5;
            this.chkSinhVien.Text = "Sinh viên ?";
            this.chkSinhVien.UseVisualStyleBackColor = true;
            // 
            // grpNuocUong
            // 
            this.grpNuocUong.Controls.Add(this.rdoCafeDen);
            this.grpNuocUong.Controls.Add(this.rdoCafeDa);
            this.grpNuocUong.Controls.Add(this.rdoCafeSua);
            this.grpNuocUong.Controls.Add(this.rdoCafeKem);
            this.grpNuocUong.Controls.Add(this.rdoCafeSuaDa);
            this.grpNuocUong.Location = new System.Drawing.Point(30, 170);
            this.grpNuocUong.Name = "grpNuocUong";
            this.grpNuocUong.Size = new System.Drawing.Size(215, 170);
            this.grpNuocUong.TabIndex = 6;
            this.grpNuocUong.TabStop = false;
            this.grpNuocUong.Text = "Nước uống";
            // 
            // rdoCafeDen
            // 
            this.rdoCafeDen.AutoSize = true;
            this.rdoCafeDen.Location = new System.Drawing.Point(15, 30);
            this.rdoCafeDen.Name = "rdoCafeDen";
            this.rdoCafeDen.Size = new System.Drawing.Size(82, 20);
            this.rdoCafeDen.TabIndex = 0;
            this.rdoCafeDen.Text = "Cafe đen";
            this.rdoCafeDen.UseVisualStyleBackColor = true;
            // 
            // rdoCafeDa
            // 
            this.rdoCafeDa.AutoSize = true;
            this.rdoCafeDa.Location = new System.Drawing.Point(120, 30);
            this.rdoCafeDa.Name = "rdoCafeDa";
            this.rdoCafeDa.Size = new System.Drawing.Size(75, 20);
            this.rdoCafeDa.TabIndex = 1;
            this.rdoCafeDa.Text = "Cafe đá";
            this.rdoCafeDa.UseVisualStyleBackColor = true;
            // 
            // rdoCafeSua
            // 
            this.rdoCafeSua.AutoSize = true;
            this.rdoCafeSua.Location = new System.Drawing.Point(15, 70);
            this.rdoCafeSua.Name = "rdoCafeSua";
            this.rdoCafeSua.Size = new System.Drawing.Size(81, 20);
            this.rdoCafeSua.TabIndex = 2;
            this.rdoCafeSua.Text = "Cafe sữa";
            this.rdoCafeSua.UseVisualStyleBackColor = true;
            // 
            // rdoCafeKem
            // 
            this.rdoCafeKem.AutoSize = true;
            this.rdoCafeKem.Location = new System.Drawing.Point(120, 70);
            this.rdoCafeKem.Name = "rdoCafeKem";
            this.rdoCafeKem.Size = new System.Drawing.Size(85, 20);
            this.rdoCafeKem.TabIndex = 3;
            this.rdoCafeKem.Text = "Cafe kem";
            this.rdoCafeKem.UseVisualStyleBackColor = true;
            // 
            // rdoCafeSuaDa
            // 
            this.rdoCafeSuaDa.AutoSize = true;
            this.rdoCafeSuaDa.Location = new System.Drawing.Point(15, 110);
            this.rdoCafeSuaDa.Name = "rdoCafeSuaDa";
            this.rdoCafeSuaDa.Size = new System.Drawing.Size(100, 20);
            this.rdoCafeSuaDa.TabIndex = 4;
            this.rdoCafeSuaDa.Text = "Cafe sữa đá";
            this.rdoCafeSuaDa.UseVisualStyleBackColor = true;
            // 
            // grpThucAn
            // 
            this.grpThucAn.Controls.Add(this.chkBanMyTrung);
            this.grpThucAn.Controls.Add(this.chkMyXaoBo);
            this.grpThucAn.Controls.Add(this.chkBanMyCa);
            this.grpThucAn.Controls.Add(this.chkMyCay);
            this.grpThucAn.Controls.Add(this.chkMyTomTrung);
            this.grpThucAn.Location = new System.Drawing.Point(255, 170);
            this.grpThucAn.Name = "grpThucAn";
            this.grpThucAn.Size = new System.Drawing.Size(253, 170);
            this.grpThucAn.TabIndex = 7;
            this.grpThucAn.TabStop = false;
            this.grpThucAn.Text = "Thức ăn";
            // 
            // chkBanMyTrung
            // 
            this.chkBanMyTrung.AutoSize = true;
            this.chkBanMyTrung.Location = new System.Drawing.Point(6, 21);
            this.chkBanMyTrung.Name = "chkBanMyTrung";
            this.chkBanMyTrung.Size = new System.Drawing.Size(113, 20);
            this.chkBanMyTrung.TabIndex = 0;
            this.chkBanMyTrung.Text = "Bánh mỳ trứng";
            this.chkBanMyTrung.UseVisualStyleBackColor = true;
            // 
            // chkMyXaoBo
            // 
            this.chkMyXaoBo.AutoSize = true;
            this.chkMyXaoBo.Location = new System.Drawing.Point(153, 21);
            this.chkMyXaoBo.Name = "chkMyXaoBo";
            this.chkMyXaoBo.Size = new System.Drawing.Size(91, 20);
            this.chkMyXaoBo.TabIndex = 1;
            this.chkMyXaoBo.Text = "Mỳ xào bò";
            this.chkMyXaoBo.UseVisualStyleBackColor = true;
            // 
            // chkBanMyCa
            // 
            this.chkBanMyCa.AutoSize = true;
            this.chkBanMyCa.Location = new System.Drawing.Point(6, 56);
            this.chkBanMyCa.Name = "chkBanMyCa";
            this.chkBanMyCa.Size = new System.Drawing.Size(99, 20);
            this.chkBanMyCa.TabIndex = 2;
            this.chkBanMyCa.Text = "Bánh mỳ cá";
            this.chkBanMyCa.UseVisualStyleBackColor = true;
            // 
            // chkMyCay
            // 
            this.chkMyCay.AutoSize = true;
            this.chkMyCay.Location = new System.Drawing.Point(153, 56);
            this.chkMyCay.Name = "chkMyCay";
            this.chkMyCay.Size = new System.Drawing.Size(72, 20);
            this.chkMyCay.TabIndex = 3;
            this.chkMyCay.Text = "Mỳ cay";
            this.chkMyCay.UseVisualStyleBackColor = true;
            // 
            // chkMyTomTrung
            // 
            this.chkMyTomTrung.AutoSize = true;
            this.chkMyTomTrung.Location = new System.Drawing.Point(6, 93);
            this.chkMyTomTrung.Name = "chkMyTomTrung";
            this.chkMyTomTrung.Size = new System.Drawing.Size(104, 20);
            this.chkMyTomTrung.TabIndex = 4;
            this.chkMyTomTrung.Text = "Mỳ tôm trứng";
            this.chkMyTomTrung.UseVisualStyleBackColor = true;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(30, 355);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(95, 35);
            this.btnTinhTien.TabIndex = 8;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(140, 355);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(95, 35);
            this.btnNhapLai.TabIndex = 9;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(250, 355);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(95, 35);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(360, 355);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 35);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // lblTongKhachHang
            // 
            this.lblTongKhachHang.AutoSize = true;
            this.lblTongKhachHang.Location = new System.Drawing.Point(30, 410);
            this.lblTongKhachHang.Name = "lblTongKhachHang";
            this.lblTongKhachHang.Size = new System.Drawing.Size(111, 16);
            this.lblTongKhachHang.TabIndex = 12;
            this.lblTongKhachHang.Text = "Tổng khách hàng";
            // 
            // txtTongKhachHang
            // 
            this.txtTongKhachHang.Location = new System.Drawing.Point(182, 408);
            this.txtTongKhachHang.Name = "txtTongKhachHang";
            this.txtTongKhachHang.Size = new System.Drawing.Size(288, 22);
            this.txtTongKhachHang.TabIndex = 13;
            // 
            // txtTongKhachHangExtra
            // 
            this.txtTongKhachHangExtra.Location = new System.Drawing.Point(182, 435);
            this.txtTongKhachHangExtra.Name = "txtTongKhachHangExtra";
            this.txtTongKhachHangExtra.Size = new System.Drawing.Size(288, 22);
            this.txtTongKhachHangExtra.TabIndex = 14;
            // 
            // lblTongTienThanhToan
            // 
            this.lblTongTienThanhToan.AutoSize = true;
            this.lblTongTienThanhToan.Location = new System.Drawing.Point(30, 468);
            this.lblTongTienThanhToan.Name = "lblTongTienThanhToan";
            this.lblTongTienThanhToan.Size = new System.Drawing.Size(127, 16);
            this.lblTongTienThanhToan.TabIndex = 15;
            this.lblTongTienThanhToan.Text = "Tổng tiền thanh toán";
            // 
            // txtTongTienThanhToan
            // 
            this.txtTongTienThanhToan.Location = new System.Drawing.Point(182, 465);
            this.txtTongTienThanhToan.Name = "txtTongTienThanhToan";
            this.txtTongTienThanhToan.Size = new System.Drawing.Size(284, 22);
            this.txtTongTienThanhToan.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 530);
            this.Controls.Add(this.txtTongTienThanhToan);
            this.Controls.Add(this.lblTongTienThanhToan);
            this.Controls.Add(this.txtTongKhachHangExtra);
            this.Controls.Add(this.txtTongKhachHang);
            this.Controls.Add(this.lblTongKhachHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.grpThucAn);
            this.Controls.Add(this.grpNuocUong);
            this.Controls.Add(this.chkSinhVien);
            this.Controls.Add(this.txtSoKhachHang);
            this.Controls.Add(this.lblSoKhachHang);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán tiền";
            this.grpNuocUong.ResumeLayout(false);
            this.grpNuocUong.PerformLayout();
            this.grpThucAn.ResumeLayout(false);
            this.grpThucAn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}