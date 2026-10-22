
namespace QuanLySinhVien
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
            this.pnlNoiDung = new System.Windows.Forms.Panel();

            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();

            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.mskNgaySinh = new System.Windows.Forms.MaskedTextBox();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();

            this.pnlNoiDung.SuspendLayout();
            this.SuspendLayout();

            //
            // pnlNoiDung
            //
            this.pnlNoiDung.BackColor =
                System.Drawing.Color.FromArgb(245, 245, 245);

            this.pnlNoiDung.Controls.Add(this.lblMaLop);
            this.pnlNoiDung.Controls.Add(this.lblMaSV);
            this.pnlNoiDung.Controls.Add(this.lblHoTen);
            this.pnlNoiDung.Controls.Add(this.lblNgaySinh);

            this.pnlNoiDung.Controls.Add(this.txtMaLop);
            this.pnlNoiDung.Controls.Add(this.txtMaSV);
            this.pnlNoiDung.Controls.Add(this.txtHoTen);
            this.pnlNoiDung.Controls.Add(this.mskNgaySinh);

            this.pnlNoiDung.Controls.Add(this.btnThem);
            this.pnlNoiDung.Controls.Add(this.btnXoa);
            this.pnlNoiDung.Controls.Add(this.btnSua);

            this.pnlNoiDung.Location =
                new System.Drawing.Point(8, 8);

            this.pnlNoiDung.Name = "pnlNoiDung";

            this.pnlNoiDung.Size =
                new System.Drawing.Size(320, 216);

            this.pnlNoiDung.TabIndex = 0;

            //
            // lblMaLop
            //
            this.lblMaLop.AutoSize = true;

            this.lblMaLop.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 9F);

            this.lblMaLop.Location =
                new System.Drawing.Point(15, 20);

            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.TabIndex = 0;
            this.lblMaLop.Text = "Mã lớp";

            //
            // txtMaLop
            //
            this.txtMaLop.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.txtMaLop.Location =
                new System.Drawing.Point(82, 15);

            this.txtMaLop.Name = "txtMaLop";

            this.txtMaLop.Size =
                new System.Drawing.Size(228, 23);

            this.txtMaLop.TabIndex = 1;

            //
            // lblMaSV
            //
            this.lblMaSV.AutoSize = true;

            this.lblMaSV.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 9F);

            this.lblMaSV.Location =
                new System.Drawing.Point(15, 53);

            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.TabIndex = 2;
            this.lblMaSV.Text = "Mã sv";

            //
            // txtMaSV
            //
            this.txtMaSV.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.txtMaSV.Location =
                new System.Drawing.Point(82, 48);

            this.txtMaSV.Name = "txtMaSV";

            this.txtMaSV.Size =
                new System.Drawing.Size(228, 23);

            this.txtMaSV.TabIndex = 3;

            //
            // lblHoTen
            //
            this.lblHoTen.AutoSize = true;

            this.lblHoTen.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 9F);

            this.lblHoTen.Location =
                new System.Drawing.Point(15, 86);

            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ tên";

            //
            // txtHoTen
            //
            this.txtHoTen.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.txtHoTen.Location =
                new System.Drawing.Point(82, 81);

            this.txtHoTen.Name = "txtHoTen";

            this.txtHoTen.Size =
                new System.Drawing.Size(228, 23);

            this.txtHoTen.TabIndex = 5;

            //
            // lblNgaySinh
            //
            this.lblNgaySinh.AutoSize = true;

            this.lblNgaySinh.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 9F);

            this.lblNgaySinh.Location =
                new System.Drawing.Point(15, 119);

            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày sinh";

            //
            // mskNgaySinh
            //
            this.mskNgaySinh.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.mskNgaySinh.Location =
                new System.Drawing.Point(82, 114);

            this.mskNgaySinh.Name = "mskNgaySinh";

            this.mskNgaySinh.Size =
                new System.Drawing.Size(228, 23);

            this.mskNgaySinh.TabIndex = 7;

            this.mskNgaySinh.Mask = "00/00/0000";
            this.mskNgaySinh.PromptChar = '_';

            this.mskNgaySinh.TextMaskFormat =
                System.Windows.Forms.MaskFormat.IncludeLiterals;

            //
            // btnThem
            //
            this.btnThem.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.btnThem.Location =
                new System.Drawing.Point(20, 164);

            this.btnThem.Name = "btnThem";

            this.btnThem.Size =
                new System.Drawing.Size(82, 37);

            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;

            //
            // btnXoa
            //
            this.btnXoa.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.btnXoa.Location =
                new System.Drawing.Point(113, 164);

            this.btnXoa.Name = "btnXoa";

            this.btnXoa.Size =
                new System.Drawing.Size(82, 37);

            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;

            //
            // btnSua
            //
            this.btnSua.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.btnSua.Location =
                new System.Drawing.Point(206, 164);

            this.btnSua.Name = "btnSua";

            this.btnSua.Size =
                new System.Drawing.Size(82, 37);

            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;

            //
            // Form1
            //
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.LightSkyBlue;

            this.ClientSize =
                new System.Drawing.Size(336, 232);

            this.Controls.Add(this.pnlNoiDung);

            this.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 8.25F);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Name = "Form1";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Quản lý sinh viên";

            this.pnlNoiDung.ResumeLayout(false);
            this.pnlNoiDung.PerformLayout();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlNoiDung;

        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;

        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;

        private System.Windows.Forms.MaskedTextBox mskNgaySinh;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}
