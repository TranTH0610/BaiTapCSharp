
namespace Diem_Combo
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

            this.lblSinhVien = new System.Windows.Forms.Label();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();

            this.cboSinhVien = new System.Windows.Forms.ComboBox();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.txtDiem = new System.Windows.Forms.TextBox();

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

            this.pnlNoiDung.Controls.Add(this.lblSinhVien);
            this.pnlNoiDung.Controls.Add(this.lblMonHoc);
            this.pnlNoiDung.Controls.Add(this.lblDiem);

            this.pnlNoiDung.Controls.Add(this.cboSinhVien);
            this.pnlNoiDung.Controls.Add(this.cboMonHoc);
            this.pnlNoiDung.Controls.Add(this.txtDiem);

            this.pnlNoiDung.Controls.Add(this.btnThem);
            this.pnlNoiDung.Controls.Add(this.btnXoa);
            this.pnlNoiDung.Controls.Add(this.btnSua);

            this.pnlNoiDung.Location =
                new System.Drawing.Point(8, 8);

            this.pnlNoiDung.Name = "pnlNoiDung";

            this.pnlNoiDung.Size =
                new System.Drawing.Size(300, 181);

            this.pnlNoiDung.TabIndex = 0;

            //
            // lblSinhVien
            //
            this.lblSinhVien.AutoSize = true;

            this.lblSinhVien.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 9F);

            this.lblSinhVien.Location =
                new System.Drawing.Point(12, 18);

            this.lblSinhVien.Name = "lblSinhVien";
            this.lblSinhVien.TabIndex = 0;
            this.lblSinhVien.Text = "Sinh viên";

            //
            // cboSinhVien
            //
            this.cboSinhVien.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboSinhVien.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.cboSinhVien.FormattingEnabled = true;

            this.cboSinhVien.Location =
                new System.Drawing.Point(78, 12);

            this.cboSinhVien.Name = "cboSinhVien";

            this.cboSinhVien.Size =
                new System.Drawing.Size(212, 24);

            this.cboSinhVien.TabIndex = 1;

            //
            // lblMonHoc
            //
            this.lblMonHoc.AutoSize = true;

            this.lblMonHoc.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 9F);

            this.lblMonHoc.Location =
                new System.Drawing.Point(12, 51);

            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.TabIndex = 2;
            this.lblMonHoc.Text = "Môn học";

            //
            // cboMonHoc
            //
            this.cboMonHoc.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboMonHoc.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.cboMonHoc.FormattingEnabled = true;

            this.cboMonHoc.Location =
                new System.Drawing.Point(78, 45);

            this.cboMonHoc.Name = "cboMonHoc";

            this.cboMonHoc.Size =
                new System.Drawing.Size(212, 24);

            this.cboMonHoc.TabIndex = 3;

            //
            // lblDiem
            //
            this.lblDiem.AutoSize = true;

            this.lblDiem.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 9F);

            this.lblDiem.Location =
                new System.Drawing.Point(12, 84);

            this.lblDiem.Name = "lblDiem";
            this.lblDiem.TabIndex = 4;
            this.lblDiem.Text = "Điểm";

            //
            // txtDiem
            //
            this.txtDiem.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.txtDiem.Location =
                new System.Drawing.Point(78, 79);

            this.txtDiem.Name = "txtDiem";

            this.txtDiem.Size =
                new System.Drawing.Size(212, 23);

            this.txtDiem.TabIndex = 5;

            //
            // btnThem
            //
            this.btnThem.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.btnThem.Location =
                new System.Drawing.Point(16, 133);

            this.btnThem.Name = "btnThem";

            this.btnThem.Size =
                new System.Drawing.Size(78, 35);

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
                new System.Drawing.Point(105, 133);

            this.btnXoa.Name = "btnXoa";

            this.btnXoa.Size =
                new System.Drawing.Size(78, 35);

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
                new System.Drawing.Point(194, 133);

            this.btnSua.Name = "btnSua";

            this.btnSua.Size =
                new System.Drawing.Size(78, 35);

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
                new System.Drawing.Size(316, 197);

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

            this.Text = "frmDiem_combo";

            this.pnlNoiDung.ResumeLayout(false);
            this.pnlNoiDung.PerformLayout();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlNoiDung;

        private System.Windows.Forms.Label lblSinhVien;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.Label lblDiem;

        private System.Windows.Forms.ComboBox cboSinhVien;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.TextBox txtDiem;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}
