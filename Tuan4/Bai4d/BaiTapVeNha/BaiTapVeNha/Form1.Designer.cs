namespace BaiTapVeNha
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblSoNgayO;
        private System.Windows.Forms.TextBox txtSoNgayO;

        private System.Windows.Forms.GroupBox grpLoaiPhong;
        private System.Windows.Forms.RadioButton rdoPhongDon;
        private System.Windows.Forms.RadioButton rdoPhongDoi;
        private System.Windows.Forms.RadioButton rdoPhongBa;

        private System.Windows.Forms.GroupBox grpTienNghi;
        private System.Windows.Forms.CheckBox chkTivi;
        private System.Windows.Forms.CheckBox chkInternet;
        private System.Windows.Forms.CheckBox chkMayNuocNong;

        private System.Windows.Forms.GroupBox grpDichVu;
        private System.Windows.Forms.CheckBox chkKaraoke;
        private System.Windows.Forms.CheckBox chkAnSang;

        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnNhapMoi;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtThanhTien;

        private System.Windows.Forms.Button btnTongKet;
        private System.Windows.Forms.GroupBox grpThongTinTongKet;
        private System.Windows.Forms.Label lblSoLuotNguoi;
        private System.Windows.Forms.TextBox txtSoLuotNguoi;
        private System.Windows.Forms.Label lblTongSoTien;
        private System.Windows.Forms.TextBox txtTongSoTien;

        private System.Windows.Forms.Button btnThoat;

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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblSoNgayO = new System.Windows.Forms.Label();
            this.txtSoNgayO = new System.Windows.Forms.TextBox();
            this.grpLoaiPhong = new System.Windows.Forms.GroupBox();
            this.rdoPhongDon = new System.Windows.Forms.RadioButton();
            this.rdoPhongDoi = new System.Windows.Forms.RadioButton();
            this.rdoPhongBa = new System.Windows.Forms.RadioButton();
            this.grpTienNghi = new System.Windows.Forms.GroupBox();
            this.chkTivi = new System.Windows.Forms.CheckBox();
            this.chkInternet = new System.Windows.Forms.CheckBox();
            this.chkMayNuocNong = new System.Windows.Forms.CheckBox();
            this.grpDichVu = new System.Windows.Forms.GroupBox();
            this.chkKaraoke = new System.Windows.Forms.CheckBox();
            this.chkAnSang = new System.Windows.Forms.CheckBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnNhapMoi = new System.Windows.Forms.Button();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnTongKet = new System.Windows.Forms.Button();
            this.grpThongTinTongKet = new System.Windows.Forms.GroupBox();
            this.lblSoLuotNguoi = new System.Windows.Forms.Label();
            this.txtSoLuotNguoi = new System.Windows.Forms.TextBox();
            this.lblTongSoTien = new System.Windows.Forms.Label();
            this.txtTongSoTien = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpLoaiPhong.SuspendLayout();
            this.grpTienNghi.SuspendLayout();
            this.grpDichVu.SuspendLayout();
            this.grpThongTinTongKet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Orange;
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(590, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "KHÁCH SẠN THANH THANH - TRẢ PHÒNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(25, 75);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(67, 16);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(110, 73);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(300, 22);
            this.txtHoTen.TabIndex = 2;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(45, 115);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 16);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(110, 113);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(300, 22);
            this.txtDiaChi.TabIndex = 4;
            // 
            // lblSoNgayO
            // 
            this.lblSoNgayO.AutoSize = true;
            this.lblSoNgayO.Location = new System.Drawing.Point(25, 155);
            this.lblSoNgayO.Name = "lblSoNgayO";
            this.lblSoNgayO.Size = new System.Drawing.Size(71, 16);
            this.lblSoNgayO.TabIndex = 5;
            this.lblSoNgayO.Text = "Số ngày ở:";
            // 
            // txtSoNgayO
            // 
            this.txtSoNgayO.Location = new System.Drawing.Point(110, 153);
            this.txtSoNgayO.Name = "txtSoNgayO";
            this.txtSoNgayO.Size = new System.Drawing.Size(125, 22);
            this.txtSoNgayO.TabIndex = 6;
            // 
            // grpLoaiPhong
            // 
            this.grpLoaiPhong.Controls.Add(this.rdoPhongDon);
            this.grpLoaiPhong.Controls.Add(this.rdoPhongDoi);
            this.grpLoaiPhong.Controls.Add(this.rdoPhongBa);
            this.grpLoaiPhong.Location = new System.Drawing.Point(25, 200);
            this.grpLoaiPhong.Name = "grpLoaiPhong";
            this.grpLoaiPhong.Size = new System.Drawing.Size(120, 130);
            this.grpLoaiPhong.TabIndex = 7;
            this.grpLoaiPhong.TabStop = false;
            this.grpLoaiPhong.Text = "Loại phòng";
            // 
            // rdoPhongDon
            // 
            this.rdoPhongDon.AutoSize = true;
            this.rdoPhongDon.Checked = true;
            this.rdoPhongDon.Location = new System.Drawing.Point(15, 25);
            this.rdoPhongDon.Name = "rdoPhongDon";
            this.rdoPhongDon.Size = new System.Drawing.Size(93, 20);
            this.rdoPhongDon.TabIndex = 0;
            this.rdoPhongDon.TabStop = true;
            this.rdoPhongDon.Text = "Phòng đơn";
            this.rdoPhongDon.UseVisualStyleBackColor = true;
            // 
            // rdoPhongDoi
            // 
            this.rdoPhongDoi.AutoSize = true;
            this.rdoPhongDoi.Location = new System.Drawing.Point(15, 60);
            this.rdoPhongDoi.Name = "rdoPhongDoi";
            this.rdoPhongDoi.Size = new System.Drawing.Size(89, 20);
            this.rdoPhongDoi.TabIndex = 1;
            this.rdoPhongDoi.Text = "Phòng đôi";
            this.rdoPhongDoi.UseVisualStyleBackColor = true;
            // 
            // rdoPhongBa
            // 
            this.rdoPhongBa.AutoSize = true;
            this.rdoPhongBa.Location = new System.Drawing.Point(15, 95);
            this.rdoPhongBa.Name = "rdoPhongBa";
            this.rdoPhongBa.Size = new System.Drawing.Size(86, 20);
            this.rdoPhongBa.TabIndex = 2;
            this.rdoPhongBa.Text = "Phòng ba";
            this.rdoPhongBa.UseVisualStyleBackColor = true;
            // 
            // grpTienNghi
            // 
            this.grpTienNghi.Controls.Add(this.chkTivi);
            this.grpTienNghi.Controls.Add(this.chkInternet);
            this.grpTienNghi.Controls.Add(this.chkMayNuocNong);
            this.grpTienNghi.Location = new System.Drawing.Point(155, 200);
            this.grpTienNghi.Name = "grpTienNghi";
            this.grpTienNghi.Size = new System.Drawing.Size(135, 130);
            this.grpTienNghi.TabIndex = 8;
            this.grpTienNghi.TabStop = false;
            this.grpTienNghi.Text = "Tiện nghi";
            // 
            // chkTivi
            // 
            this.chkTivi.AutoSize = true;
            this.chkTivi.Checked = true;
            this.chkTivi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTivi.Location = new System.Drawing.Point(15, 25);
            this.chkTivi.Name = "chkTivi";
            this.chkTivi.Size = new System.Drawing.Size(51, 20);
            this.chkTivi.TabIndex = 0;
            this.chkTivi.Text = "Tivi";
            this.chkTivi.UseVisualStyleBackColor = true;
            // 
            // chkInternet
            // 
            this.chkInternet.AutoSize = true;
            this.chkInternet.Checked = true;
            this.chkInternet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInternet.Location = new System.Drawing.Point(15, 60);
            this.chkInternet.Name = "chkInternet";
            this.chkInternet.Size = new System.Drawing.Size(72, 20);
            this.chkInternet.TabIndex = 1;
            this.chkInternet.Text = "Internet";
            this.chkInternet.UseVisualStyleBackColor = true;
            // 
            // chkMayNuocNong
            // 
            this.chkMayNuocNong.AutoSize = true;
            this.chkMayNuocNong.Checked = true;
            this.chkMayNuocNong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMayNuocNong.Location = new System.Drawing.Point(15, 95);
            this.chkMayNuocNong.Name = "chkMayNuocNong";
            this.chkMayNuocNong.Size = new System.Drawing.Size(120, 20);
            this.chkMayNuocNong.TabIndex = 2;
            this.chkMayNuocNong.Text = "Máy nước nóng";
            this.chkMayNuocNong.UseVisualStyleBackColor = true;
            // 
            // grpDichVu
            // 
            this.grpDichVu.Controls.Add(this.chkKaraoke);
            this.grpDichVu.Controls.Add(this.chkAnSang);
            this.grpDichVu.Location = new System.Drawing.Point(300, 200);
            this.grpDichVu.Name = "grpDichVu";
            this.grpDichVu.Size = new System.Drawing.Size(110, 130);
            this.grpDichVu.TabIndex = 9;
            this.grpDichVu.TabStop = false;
            this.grpDichVu.Text = "Dịch vụ";
            // 
            // chkKaraoke
            // 
            this.chkKaraoke.AutoSize = true;
            this.chkKaraoke.Location = new System.Drawing.Point(15, 50);
            this.chkKaraoke.Name = "chkKaraoke";
            this.chkKaraoke.Size = new System.Drawing.Size(80, 20);
            this.chkKaraoke.TabIndex = 0;
            this.chkKaraoke.Text = "Karaoke";
            this.chkKaraoke.UseVisualStyleBackColor = true;
            // 
            // chkAnSang
            // 
            this.chkAnSang.AutoSize = true;
            this.chkAnSang.Checked = true;
            this.chkAnSang.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAnSang.Location = new System.Drawing.Point(15, 90);
            this.chkAnSang.Name = "chkAnSang";
            this.chkAnSang.Size = new System.Drawing.Size(78, 20);
            this.chkAnSang.TabIndex = 1;
            this.chkAnSang.Text = "Ăn sáng";
            this.chkAnSang.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(425, 70);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(85, 32);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnNhapMoi
            // 
            this.btnNhapMoi.Location = new System.Drawing.Point(520, 70);
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Size = new System.Drawing.Size(95, 32);
            this.btnNhapMoi.TabIndex = 11;
            this.btnNhapMoi.Text = "Nhập mới";
            this.btnNhapMoi.UseVisualStyleBackColor = true;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(425, 120);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(72, 16);
            this.lblThanhTien.TabIndex = 12;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(500, 118);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(115, 22);
            this.txtThanhTien.TabIndex = 13;
            // 
            // btnTongKet
            // 
            this.btnTongKet.Location = new System.Drawing.Point(425, 160);
            this.btnTongKet.Name = "btnTongKet";
            this.btnTongKet.Size = new System.Drawing.Size(85, 28);
            this.btnTongKet.TabIndex = 14;
            this.btnTongKet.Text = "Tổng Kết";
            this.btnTongKet.UseVisualStyleBackColor = true;
            // 
            // grpThongTinTongKet
            // 
            this.grpThongTinTongKet.Controls.Add(this.lblSoLuotNguoi);
            this.grpThongTinTongKet.Controls.Add(this.txtSoLuotNguoi);
            this.grpThongTinTongKet.Controls.Add(this.lblTongSoTien);
            this.grpThongTinTongKet.Controls.Add(this.txtTongSoTien);
            this.grpThongTinTongKet.Location = new System.Drawing.Point(420, 195);
            this.grpThongTinTongKet.Name = "grpThongTinTongKet";
            this.grpThongTinTongKet.Size = new System.Drawing.Size(195, 95);
            this.grpThongTinTongKet.TabIndex = 15;
            this.grpThongTinTongKet.TabStop = false;
            this.grpThongTinTongKet.Text = "Thông tin tổng kết";
            // 
            // lblSoLuotNguoi
            // 
            this.lblSoLuotNguoi.AutoSize = true;
            this.lblSoLuotNguoi.Location = new System.Drawing.Point(3, 23);
            this.lblSoLuotNguoi.Name = "lblSoLuotNguoi";
            this.lblSoLuotNguoi.Size = new System.Drawing.Size(87, 16);
            this.lblSoLuotNguoi.TabIndex = 0;
            this.lblSoLuotNguoi.Text = "Số lượt người:";
            // 
            // txtSoLuotNguoi
            // 
            this.txtSoLuotNguoi.Location = new System.Drawing.Point(95, 23);
            this.txtSoLuotNguoi.Name = "txtSoLuotNguoi";
            this.txtSoLuotNguoi.Size = new System.Drawing.Size(90, 22);
            this.txtSoLuotNguoi.TabIndex = 1;
            // 
            // lblTongSoTien
            // 
            this.lblTongSoTien.AutoSize = true;
            this.lblTongSoTien.Location = new System.Drawing.Point(3, 61);
            this.lblTongSoTien.Name = "lblTongSoTien";
            this.lblTongSoTien.Size = new System.Drawing.Size(84, 16);
            this.lblTongSoTien.TabIndex = 2;
            this.lblTongSoTien.Text = "Tổng số tiền:";
            // 
            // txtTongSoTien
            // 
            this.txtTongSoTien.Location = new System.Drawing.Point(95, 58);
            this.txtTongSoTien.Name = "txtTongSoTien";
            this.txtTongSoTien.Size = new System.Drawing.Size(90, 22);
            this.txtTongSoTien.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(425, 305);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(190, 30);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 430);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grpThongTinTongKet);
            this.Controls.Add(this.btnTongKet);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.btnNhapMoi);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.grpDichVu);
            this.Controls.Add(this.grpTienNghi);
            this.Controls.Add(this.grpLoaiPhong);
            this.Controls.Add(this.txtSoNgayO);
            this.Controls.Add(this.lblSoNgayO);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHÁCH SẠN THANH THANH - TRẢ PHÒNG";
            this.grpLoaiPhong.ResumeLayout(false);
            this.grpLoaiPhong.PerformLayout();
            this.grpTienNghi.ResumeLayout(false);
            this.grpTienNghi.PerformLayout();
            this.grpDichVu.ResumeLayout(false);
            this.grpDichVu.PerformLayout();
            this.grpThongTinTongKet.ResumeLayout(false);
            this.grpThongTinTongKet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}