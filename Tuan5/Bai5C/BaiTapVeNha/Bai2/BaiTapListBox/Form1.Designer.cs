
namespace BaiTapListBox
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();

            this.grpListBox = new System.Windows.Forms.GroupBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lstDanhSach = new System.Windows.Forms.ListBox();

            this.grpXuLyListBox = new System.Windows.Forms.GroupBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnXoaDangChon = new System.Windows.Forms.Button();
            this.btnTangLen2 = new System.Windows.Forms.Button();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnChonSoChan = new System.Windows.Forms.Button();
            this.btnChonSoLe = new System.Windows.Forms.Button();

            this.btnKetThuc = new System.Windows.Forms.Button();

            this.pnlTieuDe.SuspendLayout();
            this.grpListBox.SuspendLayout();
            this.grpXuLyListBox.SuspendLayout();
            this.SuspendLayout();

            //
            // pnlTieuDe
            //
            this.pnlTieuDe.BackColor =
                System.Drawing.Color.FromArgb(245, 245, 245);

            this.pnlTieuDe.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlTieuDe.Controls.Add(this.lblTieuDe);

            this.pnlTieuDe.Location =
                new System.Drawing.Point(65, 0);

            this.pnlTieuDe.Name = "pnlTieuDe";

            this.pnlTieuDe.Size =
                new System.Drawing.Size(455, 57);

            this.pnlTieuDe.TabIndex = 0;

            //
            // lblTieuDe
            //
            this.lblTieuDe.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.lblTieuDe.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif",
                    20F,
                    System.Drawing.FontStyle.Bold);

            this.lblTieuDe.ForeColor =
                System.Drawing.Color.DarkOrange;

            this.lblTieuDe.Name = "lblTieuDe";

            this.lblTieuDe.Text = "LISTBOX";

            this.lblTieuDe.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            //
            // grpListBox
            //
            this.grpListBox.Controls.Add(this.txtNhap);
            this.grpListBox.Controls.Add(this.btnNhap);
            this.grpListBox.Controls.Add(this.lstDanhSach);

            this.grpListBox.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.grpListBox.Location =
                new System.Drawing.Point(73, 62);

            this.grpListBox.Name = "grpListBox";

            this.grpListBox.Size =
                new System.Drawing.Size(175, 313);

            this.grpListBox.TabIndex = 1;
            this.grpListBox.TabStop = false;

            this.grpListBox.Text = "Listbox";

            //
            // txtNhap
            //
            this.txtNhap.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 11F);

            this.txtNhap.Location =
                new System.Drawing.Point(7, 23);

            this.txtNhap.Name = "txtNhap";

            this.txtNhap.Size =
                new System.Drawing.Size(159, 24);

            this.txtNhap.TabIndex = 0;

            this.txtNhap.Text = "";

            //
            // btnNhap
            //
            this.btnNhap.BackColor =
                System.Drawing.Color.LightSkyBlue;

            this.btnNhap.FlatStyle =
                System.Windows.Forms.FlatStyle.Standard;

            this.btnNhap.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 11F);

            this.btnNhap.Location =
                new System.Drawing.Point(7, 57);

            this.btnNhap.Name = "btnNhap";

            this.btnNhap.Size =
                new System.Drawing.Size(159, 37);

            this.btnNhap.TabIndex = 1;

            this.btnNhap.Text = "Nhập";

            this.btnNhap.UseVisualStyleBackColor = false;

            //
            // lstDanhSach
            //
            this.lstDanhSach.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 11F);

            this.lstDanhSach.FormattingEnabled = true;

            this.lstDanhSach.IntegralHeight = false;

            this.lstDanhSach.ItemHeight = 18;

            this.lstDanhSach.Location =
                new System.Drawing.Point(7, 103);

            this.lstDanhSach.Name = "lstDanhSach";

            this.lstDanhSach.Size =
                new System.Drawing.Size(159, 202);

            this.lstDanhSach.TabIndex = 2;

            this.lstDanhSach.SelectionMode =
                System.Windows.Forms.SelectionMode.MultiExtended;

            //
            // grpXuLyListBox
            //
            this.grpXuLyListBox.Controls.Add(this.btnTinhTong);
            this.grpXuLyListBox.Controls.Add(this.btnXoaDauCuoi);
            this.grpXuLyListBox.Controls.Add(this.btnXoaDangChon);
            this.grpXuLyListBox.Controls.Add(this.btnTangLen2);
            this.grpXuLyListBox.Controls.Add(this.btnBinhPhuong);
            this.grpXuLyListBox.Controls.Add(this.btnChonSoChan);
            this.grpXuLyListBox.Controls.Add(this.btnChonSoLe);

            this.grpXuLyListBox.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.grpXuLyListBox.Location =
                new System.Drawing.Point(270, 62);

            this.grpXuLyListBox.Name = "grpXuLyListBox";

            this.grpXuLyListBox.Size =
                new System.Drawing.Size(245, 313);

            this.grpXuLyListBox.TabIndex = 2;
            this.grpXuLyListBox.TabStop = false;

            this.grpXuLyListBox.Text = "Xử lý Listbox";

            //
            // btnTinhTong
            //
            this.btnTinhTong.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.btnTinhTong.Location =
                new System.Drawing.Point(7, 25);

            this.btnTinhTong.Name = "btnTinhTong";

            this.btnTinhTong.Size =
                new System.Drawing.Size(231, 32);

            this.btnTinhTong.TabIndex = 0;

            this.btnTinhTong.Text =
                "Tổng các phần tử trong List";

            this.btnTinhTong.UseVisualStyleBackColor = true;

            //
            // btnXoaDauCuoi
            //
            this.btnXoaDauCuoi.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.btnXoaDauCuoi.Location =
                new System.Drawing.Point(7, 66);

            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";

            this.btnXoaDauCuoi.Size =
                new System.Drawing.Size(231, 32);

            this.btnXoaDauCuoi.TabIndex = 1;

            this.btnXoaDauCuoi.Text =
                "Xóa Phần tử đầu và cuối";

            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;

            //
            // btnXoaDangChon
            //
            this.btnXoaDangChon.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.btnXoaDangChon.Location =
                new System.Drawing.Point(7, 107);

            this.btnXoaDangChon.Name = "btnXoaDangChon";

            this.btnXoaDangChon.Size =
                new System.Drawing.Size(231, 32);

            this.btnXoaDangChon.TabIndex = 2;

            this.btnXoaDangChon.Text =
                "Xóa Phần tử đang chọn";

            this.btnXoaDangChon.UseVisualStyleBackColor = true;

            //
            // btnTangLen2
            //
            this.btnTangLen2.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.btnTangLen2.Location =
                new System.Drawing.Point(7, 148);

            this.btnTangLen2.Name = "btnTangLen2";

            this.btnTangLen2.Size =
                new System.Drawing.Size(231, 32);

            this.btnTangLen2.TabIndex = 3;

            this.btnTangLen2.Text =
                "Tăng mỗi phần tử lên 2";

            this.btnTangLen2.UseVisualStyleBackColor = true;

            //
            // btnBinhPhuong
            //
            this.btnBinhPhuong.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.btnBinhPhuong.Location =
                new System.Drawing.Point(7, 189);

            this.btnBinhPhuong.Name = "btnBinhPhuong";

            this.btnBinhPhuong.Size =
                new System.Drawing.Size(231, 32);

            this.btnBinhPhuong.TabIndex = 4;

            this.btnBinhPhuong.Text =
                "Thay bằng bình phương";

            this.btnBinhPhuong.UseVisualStyleBackColor = true;

            //
            // btnChonSoChan
            //
            this.btnChonSoChan.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.btnChonSoChan.Location =
                new System.Drawing.Point(7, 230);

            this.btnChonSoChan.Name = "btnChonSoChan";

            this.btnChonSoChan.Size =
                new System.Drawing.Size(231, 32);

            this.btnChonSoChan.TabIndex = 5;

            this.btnChonSoChan.Text = "Chọn số chẵn";

            this.btnChonSoChan.UseVisualStyleBackColor = true;

            //
            // btnChonSoLe
            //
            this.btnChonSoLe.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.btnChonSoLe.Location =
                new System.Drawing.Point(7, 271);

            this.btnChonSoLe.Name = "btnChonSoLe";

            this.btnChonSoLe.Size =
                new System.Drawing.Size(231, 32);

            this.btnChonSoLe.TabIndex = 6;

            this.btnChonSoLe.Text = "Chọn số lẻ";

            this.btnChonSoLe.UseVisualStyleBackColor = true;

            //
            // btnKetThuc
            //
            this.btnKetThuc.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 11F);

            this.btnKetThuc.Location =
                new System.Drawing.Point(80, 385);

            this.btnKetThuc.Name = "btnKetThuc";

            this.btnKetThuc.Size =
                new System.Drawing.Size(435, 34);

            this.btnKetThuc.TabIndex = 3;

            this.btnKetThuc.Text = "KẾT THÚC";

            this.btnKetThuc.UseVisualStyleBackColor = true;

            //
            // Form1
            //
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(240, 240, 240);

            this.ClientSize =
                new System.Drawing.Size(520, 430);

            this.Controls.Add(this.pnlTieuDe);
            this.Controls.Add(this.grpListBox);
            this.Controls.Add(this.grpXuLyListBox);
            this.Controls.Add(this.btnKetThuc);

            this.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 8.25F);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Name = "Form1";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "frmListbox";

            this.pnlTieuDe.ResumeLayout(false);
            this.grpListBox.ResumeLayout(false);
            this.grpListBox.PerformLayout();
            this.grpXuLyListBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTieuDe;

        private System.Windows.Forms.GroupBox grpListBox;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ListBox lstDanhSach;

        private System.Windows.Forms.GroupBox grpXuLyListBox;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnXoaDangChon;
        private System.Windows.Forms.Button btnTangLen2;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnChonSoChan;
        private System.Windows.Forms.Button btnChonSoLe;

        private System.Windows.Forms.Button btnKetThuc;
    }
}
