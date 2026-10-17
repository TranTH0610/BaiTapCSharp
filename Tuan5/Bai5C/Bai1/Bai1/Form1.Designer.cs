using System;

namespace Bai1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpNhapSo = new System.Windows.Forms.GroupBox();
            this.cboDanhSach = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.lblDanhSachUocSo = new System.Windows.Forms.Label();
            this.lstUocSo = new System.Windows.Forms.ListBox();
            this.btnTongCacUocSo = new System.Windows.Forms.Button();
            this.btnSoLuongUocSoChan = new System.Windows.Forms.Button();
            this.btnSoLuongUocSoNguyenTo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpNhapSo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNhapSo
            // 
            this.grpNhapSo.Controls.Add(this.cboDanhSach);
            this.grpNhapSo.Controls.Add(this.btnCapNhat);
            this.grpNhapSo.Controls.Add(this.txtNhap);
            this.grpNhapSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNhapSo.Location = new System.Drawing.Point(25, 25);
            this.grpNhapSo.Name = "grpNhapSo";
            this.grpNhapSo.Size = new System.Drawing.Size(280, 170);
            this.grpNhapSo.TabIndex = 0;
            this.grpNhapSo.TabStop = false;
            this.grpNhapSo.Text = "Nhập Số";
            // 
            // cboDanhSach
            // 
            this.cboDanhSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhSach.FormattingEnabled = true;
            this.cboDanhSach.Location = new System.Drawing.Point(20, 95);
            this.cboDanhSach.Name = "cboDanhSach";
            this.cboDanhSach.Size = new System.Drawing.Size(240, 24);
            this.cboDanhSach.TabIndex = 2;
            this.cboDanhSach.SelectedIndexChanged += new System.EventHandler(this.cboDanhSach_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(161, 30);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(99, 32);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(20, 35);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(135, 22);
            this.txtNhap.TabIndex = 0;
            // 
            // lblDanhSachUocSo
            // 
            this.lblDanhSachUocSo.AutoSize = true;
            this.lblDanhSachUocSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDanhSachUocSo.Location = new System.Drawing.Point(330, 25);
            this.lblDanhSachUocSo.Name = "lblDanhSachUocSo";
            this.lblDanhSachUocSo.Size = new System.Drawing.Size(177, 20);
            this.lblDanhSachUocSo.TabIndex = 1;
            this.lblDanhSachUocSo.Text = "Danh sách các ước số";
            // 
            // lstUocSo
            // 
            this.lstUocSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstUocSo.FormattingEnabled = true;
            this.lstUocSo.ItemHeight = 20;
            this.lstUocSo.Location = new System.Drawing.Point(330, 50);
            this.lstUocSo.Name = "lstUocSo";
            this.lstUocSo.Size = new System.Drawing.Size(250, 144);
            this.lstUocSo.TabIndex = 2;
            // 
            // btnTongCacUocSo
            // 
            this.btnTongCacUocSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTongCacUocSo.Location = new System.Drawing.Point(330, 210);
            this.btnTongCacUocSo.Name = "btnTongCacUocSo";
            this.btnTongCacUocSo.Size = new System.Drawing.Size(250, 35);
            this.btnTongCacUocSo.TabIndex = 3;
            this.btnTongCacUocSo.Text = "Tổng các ước số";
            this.btnTongCacUocSo.UseVisualStyleBackColor = true;
            this.btnTongCacUocSo.Click += new System.EventHandler(this.btnTongCacUocSo_Click);
            // 
            // btnSoLuongUocSoChan
            // 
            this.btnSoLuongUocSoChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSoLuongUocSoChan.Location = new System.Drawing.Point(330, 255);
            this.btnSoLuongUocSoChan.Name = "btnSoLuongUocSoChan";
            this.btnSoLuongUocSoChan.Size = new System.Drawing.Size(250, 35);
            this.btnSoLuongUocSoChan.TabIndex = 4;
            this.btnSoLuongUocSoChan.Text = "Số lượng các ước số chẵn";
            this.btnSoLuongUocSoChan.UseVisualStyleBackColor = true;
            this.btnSoLuongUocSoChan.Click += new System.EventHandler(this.btnSoLuongUocSoChan_Click);
            // 
            // btnSoLuongUocSoNguyenTo
            // 
            this.btnSoLuongUocSoNguyenTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSoLuongUocSoNguyenTo.Location = new System.Drawing.Point(330, 300);
            this.btnSoLuongUocSoNguyenTo.Name = "btnSoLuongUocSoNguyenTo";
            this.btnSoLuongUocSoNguyenTo.Size = new System.Drawing.Size(250, 35);
            this.btnSoLuongUocSoNguyenTo.TabIndex = 5;
            this.btnSoLuongUocSoNguyenTo.Text = "Số lượng các ước số nguyên tố";
            this.btnSoLuongUocSoNguyenTo.UseVisualStyleBackColor = true;
            this.btnSoLuongUocSoNguyenTo.Click += new System.EventHandler(this.btnSoLuongUocSoNguyenTo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThoat.Location = new System.Drawing.Point(210, 220);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 35);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 365);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSoLuongUocSoNguyenTo);
            this.Controls.Add(this.btnSoLuongUocSoChan);
            this.Controls.Add(this.btnTongCacUocSo);
            this.Controls.Add(this.lstUocSo);
            this.Controls.Add(this.lblDanhSachUocSo);
            this.Controls.Add(this.grpNhapSo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combobox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpNhapSo.ResumeLayout(false);
            this.grpNhapSo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox grpNhapSo;
        private System.Windows.Forms.ComboBox cboDanhSach;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label lblDanhSachUocSo;
        private System.Windows.Forms.ListBox lstUocSo;
        private System.Windows.Forms.Button btnTongCacUocSo;
        private System.Windows.Forms.Button btnSoLuongUocSoChan;
        private System.Windows.Forms.Button btnSoLuongUocSoNguyenTo;
        private System.Windows.Forms.Button btnThoat;
    }
}