
namespace QuanLyHocVien
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();

            this.mnuCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapHocVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenSangLopB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenSangLopA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoaHocVien = new System.Windows.Forms.ToolStripMenuItem();

            this.mnuKetThuc = new System.Windows.Forms.ToolStripMenuItem();

            this.grpLopA = new System.Windows.Forms.GroupBox();
            this.grpLopB = new System.Windows.Forms.GroupBox();

            this.lstLopA = new System.Windows.Forms.ListBox();
            this.lstLopB = new System.Windows.Forms.ListBox();

            this.menuStrip1.SuspendLayout();
            this.grpLopA.SuspendLayout();
            this.grpLopB.SuspendLayout();
            this.SuspendLayout();

            //
            // menuStrip1
            //
            this.menuStrip1.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.mnuCapNhat,
                    this.mnuKetThuc
                });

            this.menuStrip1.Location =
                new System.Drawing.Point(0, 0);

            this.menuStrip1.Name = "menuStrip1";

            this.menuStrip1.Size =
                new System.Drawing.Size(340, 26);

            this.menuStrip1.TabIndex = 0;

            //
            // mnuCapNhat
            //
            this.mnuCapNhat.DropDownItems.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.mnuNhapHocVien,
                    this.mnuChuyenSangLopB,
                    this.mnuChuyenSangLopA,
                    this.mnuXoaHocVien
                });

            this.mnuCapNhat.Font =
                new System.Drawing.Font(
                    "Times New Roman", 12F,
                    System.Drawing.FontStyle.Bold);

            this.mnuCapNhat.Name = "mnuCapNhat";
            this.mnuCapNhat.Text = "Cập nhật";

            //
            // mnuNhapHocVien
            //
            this.mnuNhapHocVien.Name = "mnuNhapHocVien";
            this.mnuNhapHocVien.Text = "Nhập học viên mới";

            //
            // mnuChuyenSangLopB
            //
            this.mnuChuyenSangLopB.Name = "mnuChuyenSangLopB";
            this.mnuChuyenSangLopB.Text = "Chuyển sang lớp B";

            //
            // mnuChuyenSangLopA
            //
            this.mnuChuyenSangLopA.Name = "mnuChuyenSangLopA";
            this.mnuChuyenSangLopA.Text = "Chuyển sang lớp A";

            //
            // mnuXoaHocVien
            //
            this.mnuXoaHocVien.Name = "mnuXoaHocVien";
            this.mnuXoaHocVien.Text = "Xóa học viên";

            //
            // mnuKetThuc
            //
            this.mnuKetThuc.Font =
                new System.Drawing.Font(
                    "Times New Roman", 12F,
                    System.Drawing.FontStyle.Bold);

            this.mnuKetThuc.Name = "mnuKetThuc";
            this.mnuKetThuc.Text = "Kết thúc";

            //
            // grpLopA
            //
            this.grpLopA.Controls.Add(this.lstLopA);

            this.grpLopA.Font =
                new System.Drawing.Font(
                    "Times New Roman", 12F);

            this.grpLopA.Location =
                new System.Drawing.Point(25, 47);

            this.grpLopA.Name = "grpLopA";

            this.grpLopA.Size =
                new System.Drawing.Size(155, 150);

            this.grpLopA.TabIndex = 1;
            this.grpLopA.TabStop = false;
            this.grpLopA.Text = "Lớp A";

            //
            // lstLopA
            //
            this.lstLopA.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.lstLopA.Font =
                new System.Drawing.Font(
                    "Times New Roman", 12F);

            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.IntegralHeight = false;

            this.lstLopA.Name = "lstLopA";
            this.lstLopA.TabIndex = 0;

            this.lstLopA.SelectionMode =
                System.Windows.Forms.SelectionMode.One;

            //
            // grpLopB
            //
            this.grpLopB.Controls.Add(this.lstLopB);

            this.grpLopB.Font =
                new System.Drawing.Font(
                    "Times New Roman", 12F);

            this.grpLopB.Location =
                new System.Drawing.Point(190, 47);

            this.grpLopB.Name = "grpLopB";

            this.grpLopB.Size =
                new System.Drawing.Size(125, 150);

            this.grpLopB.TabIndex = 2;
            this.grpLopB.TabStop = false;
            this.grpLopB.Text = "Lớp B";

            //
            // lstLopB
            //
            this.lstLopB.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.lstLopB.Font =
                new System.Drawing.Font(
                    "Times New Roman", 12F);

            this.lstLopB.FormattingEnabled = true;
            this.lstLopB.IntegralHeight = false;

            this.lstLopB.Name = "lstLopB";
            this.lstLopB.TabIndex = 0;

            this.lstLopB.SelectionMode =
                System.Windows.Forms.SelectionMode.One;

            //
            // Form1
            //
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(340, 218);

            this.Controls.Add(this.grpLopA);
            this.Controls.Add(this.grpLopB);
            this.Controls.Add(this.menuStrip1);

            this.MainMenuStrip = this.menuStrip1;

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Name = "Form1";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Quản lý học viên";

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();

            this.grpLopA.ResumeLayout(false);
            this.grpLopB.ResumeLayout(false);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.ToolStripMenuItem mnuCapNhat;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapHocVien;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenSangLopB;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenSangLopA;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaHocVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKetThuc;

        private System.Windows.Forms.GroupBox grpLopA;
        private System.Windows.Forms.GroupBox grpLopB;

        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.ListBox lstLopB;
    }
}
