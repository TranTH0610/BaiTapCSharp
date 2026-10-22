
namespace QuanLyHocVien
{
    partial class Form2
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();

            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();

            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();

            this.SuspendLayout();

            //
            // lblHoTen
            //
            this.lblHoTen.AutoSize = true;

            this.lblHoTen.Font =
                new System.Drawing.Font(
                    "Times New Roman", 11F);

            this.lblHoTen.Location =
                new System.Drawing.Point(24, 30);

            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Text = "Họ và Tên";

            //
            // txtHoTen
            //
            this.txtHoTen.Font =
                new System.Drawing.Font(
                    "Times New Roman", 11F);

            this.txtHoTen.Location =
                new System.Drawing.Point(95, 25);

            this.txtHoTen.Name = "txtHoTen";

            this.txtHoTen.Size =
                new System.Drawing.Size(162, 24);

            this.txtHoTen.TabIndex = 0;

            //
            // lblLop
            //
            this.lblLop.AutoSize = true;

            this.lblLop.Font =
                new System.Drawing.Font(
                    "Times New Roman", 11F);

            this.lblLop.Location =
                new System.Drawing.Point(24, 65);

            this.lblLop.Name = "lblLop";
            this.lblLop.Text = "Lớp";

            //
            // cboLop
            //
            this.cboLop.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboLop.Font =
                new System.Drawing.Font(
                    "Times New Roman", 11F);

            this.cboLop.FormattingEnabled = true;

            this.cboLop.Items.AddRange(new object[]
            {
                "Lớp A",
                "Lớp B"
            });

            this.cboLop.Location =
                new System.Drawing.Point(95, 60);

            this.cboLop.Name = "cboLop";

            this.cboLop.Size =
                new System.Drawing.Size(162, 25);

            this.cboLop.TabIndex = 1;

            //
            // btnCapNhat
            //
            this.btnCapNhat.Font =
                new System.Drawing.Font(
                    "Times New Roman", 11F,
                    System.Drawing.FontStyle.Bold);

            this.btnCapNhat.Location =
                new System.Drawing.Point(95, 105);

            this.btnCapNhat.Name = "btnCapNhat";

            this.btnCapNhat.Size =
                new System.Drawing.Size(75, 27);

            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;

            //
            // btnTroVe
            //
            this.btnTroVe.Font =
                new System.Drawing.Font(
                    "Times New Roman", 11F,
                    System.Drawing.FontStyle.Bold);

            this.btnTroVe.Location =
                new System.Drawing.Point(177, 105);

            this.btnTroVe.Name = "btnTroVe";

            this.btnTroVe.Size =
                new System.Drawing.Size(80, 27);

            this.btnTroVe.TabIndex = 3;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;

            //
            // Form2
            //
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(274, 145);

            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);

            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.cboLop);

            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnTroVe);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Name = "Form2";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text = "Nhập học viên mới";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblLop;

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cboLop;

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnTroVe;
    }
}
