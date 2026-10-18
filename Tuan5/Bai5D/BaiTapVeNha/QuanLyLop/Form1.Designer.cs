
namespace QuanLyLop
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

            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblTenLop = new System.Windows.Forms.Label();

            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();

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

            this.pnlNoiDung.Controls.Add(this.lblMaKhoa);
            this.pnlNoiDung.Controls.Add(this.lblMaLop);
            this.pnlNoiDung.Controls.Add(this.lblTenLop);

            this.pnlNoiDung.Controls.Add(this.txtMaKhoa);
            this.pnlNoiDung.Controls.Add(this.txtMaLop);
            this.pnlNoiDung.Controls.Add(this.txtTenLop);

            this.pnlNoiDung.Controls.Add(this.btnThem);
            this.pnlNoiDung.Controls.Add(this.btnXoa);
            this.pnlNoiDung.Controls.Add(this.btnSua);

            this.pnlNoiDung.Location =
                new System.Drawing.Point(8, 8);

            this.pnlNoiDung.Name = "pnlNoiDung";

            this.pnlNoiDung.Size =
                new System.Drawing.Size(320, 190);

            this.pnlNoiDung.TabIndex = 0;

            //
            // lblMaKhoa
            //
            this.lblMaKhoa.AutoSize = true;

            this.lblMaKhoa.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.lblMaKhoa.Location =
                new System.Drawing.Point(16, 19);

            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.TabIndex = 0;
            this.lblMaKhoa.Text = "Mã khoa";

            //
            // txtMaKhoa
            //
            this.txtMaKhoa.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.txtMaKhoa.Location =
                new System.Drawing.Point(84, 15);

            this.txtMaKhoa.Name = "txtMaKhoa";

            this.txtMaKhoa.Size =
                new System.Drawing.Size(226, 23);

            this.txtMaKhoa.TabIndex = 1;

            //
            // lblMaLop
            //
            this.lblMaLop.AutoSize = true;

            this.lblMaLop.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.lblMaLop.Location =
                new System.Drawing.Point(16, 54);

            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.TabIndex = 2;
            this.lblMaLop.Text = "Mã lớp";

            //
            // txtMaLop
            //
            this.txtMaLop.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.txtMaLop.Location =
                new System.Drawing.Point(84, 50);

            this.txtMaLop.Name = "txtMaLop";

            this.txtMaLop.Size =
                new System.Drawing.Size(226, 23);

            this.txtMaLop.TabIndex = 3;

            //
            // lblTenLop
            //
            this.lblTenLop.AutoSize = true;

            this.lblTenLop.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.lblTenLop.Location =
                new System.Drawing.Point(16, 89);

            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.TabIndex = 4;
            this.lblTenLop.Text = "Tên lớp";

            //
            // txtTenLop
            //
            this.txtTenLop.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.txtTenLop.Location =
                new System.Drawing.Point(84, 85);

            this.txtTenLop.Name = "txtTenLop";

            this.txtTenLop.Size =
                new System.Drawing.Size(226, 23);

            this.txtTenLop.TabIndex = 5;

            //
            // btnThem
            //
            this.btnThem.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.btnThem.Location =
                new System.Drawing.Point(21, 136);

            this.btnThem.Name = "btnThem";

            this.btnThem.Size =
                new System.Drawing.Size(82, 37);

            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;

            //
            // btnXoa
            //
            this.btnXoa.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.btnXoa.Location =
                new System.Drawing.Point(114, 136);

            this.btnXoa.Name = "btnXoa";

            this.btnXoa.Size =
                new System.Drawing.Size(82, 37);

            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;

            //
            // btnSua
            //
            this.btnSua.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.btnSua.Location =
                new System.Drawing.Point(207, 136);

            this.btnSua.Name = "btnSua";

            this.btnSua.Size =
                new System.Drawing.Size(82, 37);

            this.btnSua.TabIndex = 8;
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
                System.Drawing.Color.LightBlue;

            this.ClientSize =
                new System.Drawing.Size(336, 206);

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

            this.Text = "frmLop";

            this.pnlNoiDung.ResumeLayout(false);
            this.pnlNoiDung.PerformLayout();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlNoiDung;

        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblTenLop;

        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}
