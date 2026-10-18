
namespace QuanLyDiem
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

            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();

            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
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

            this.pnlNoiDung.Controls.Add(this.lblMaSV);
            this.pnlNoiDung.Controls.Add(this.lblMaMH);
            this.pnlNoiDung.Controls.Add(this.lblDiem);

            this.pnlNoiDung.Controls.Add(this.txtMaSV);
            this.pnlNoiDung.Controls.Add(this.txtMaMH);
            this.pnlNoiDung.Controls.Add(this.txtDiem);

            this.pnlNoiDung.Controls.Add(this.btnThem);
            this.pnlNoiDung.Controls.Add(this.btnXoa);
            this.pnlNoiDung.Controls.Add(this.btnSua);

            this.pnlNoiDung.Location =
                new System.Drawing.Point(8, 8);

            this.pnlNoiDung.Name = "pnlNoiDung";

            this.pnlNoiDung.Size =
                new System.Drawing.Size(320, 180);

            this.pnlNoiDung.TabIndex = 0;

            //
            // lblMaSV
            //
            this.lblMaSV.AutoSize = true;

            this.lblMaSV.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.lblMaSV.Location =
                new System.Drawing.Point(15, 15);

            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã sv";

            //
            // txtMaSV
            //
            this.txtMaSV.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.txtMaSV.Location =
                new System.Drawing.Point(80, 12);

            this.txtMaSV.Name = "txtMaSV";

            this.txtMaSV.Size =
                new System.Drawing.Size(230, 23);

            this.txtMaSV.TabIndex = 1;

            //
            // lblMaMH
            //
            this.lblMaMH.AutoSize = true;

            this.lblMaMH.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.lblMaMH.Location =
                new System.Drawing.Point(15, 52);

            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.TabIndex = 2;
            this.lblMaMH.Text = "Mã mh";

            //
            // txtMaMH
            //
            this.txtMaMH.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.txtMaMH.Location =
                new System.Drawing.Point(80, 49);

            this.txtMaMH.Name = "txtMaMH";

            this.txtMaMH.Size =
                new System.Drawing.Size(230, 23);

            this.txtMaMH.TabIndex = 3;

            //
            // lblDiem
            //
            this.lblDiem.AutoSize = true;

            this.lblDiem.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.lblDiem.Location =
                new System.Drawing.Point(15, 89);

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
                new System.Drawing.Point(80, 86);

            this.txtDiem.Name = "txtDiem";

            this.txtDiem.Size =
                new System.Drawing.Size(230, 23);

            this.txtDiem.TabIndex = 5;

            //
            // btnThem
            //
            this.btnThem.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.btnThem.Location =
                new System.Drawing.Point(16, 135);

            this.btnThem.Name = "btnThem";

            this.btnThem.Size =
                new System.Drawing.Size(86, 38);

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
                new System.Drawing.Point(113, 135);

            this.btnXoa.Name = "btnXoa";

            this.btnXoa.Size =
                new System.Drawing.Size(86, 38);

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
                new System.Drawing.Point(210, 135);

            this.btnSua.Name = "btnSua";

            this.btnSua.Size =
                new System.Drawing.Size(86, 38);

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
                System.Drawing.Color.LightSkyBlue;

            this.ClientSize =
                new System.Drawing.Size(336, 196);

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

            this.Text = "Quản lý Điểm";

            this.pnlNoiDung.ResumeLayout(false);
            this.pnlNoiDung.PerformLayout();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlNoiDung;

        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lblDiem;

        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtDiem;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}
