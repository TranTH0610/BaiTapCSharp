
namespace TuDienAnhViet
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
            this.tabTuDien = new System.Windows.Forms.TabControl();
            this.tabAnhViet = new System.Windows.Forms.TabPage();
            this.tabVietAnh = new System.Windows.Forms.TabPage();

            this.lblTiengAnh = new System.Windows.Forms.Label();
            this.lblTiengViet = new System.Windows.Forms.Label();

            this.txtTiengAnh = new System.Windows.Forms.TextBox();
            this.lstTiengAnh = new System.Windows.Forms.ListBox();
            this.txtNghiaTiengViet = new System.Windows.Forms.TextBox();

            this.lblTuTiengViet = new System.Windows.Forms.Label();
            this.lblNghiaTiengAnh = new System.Windows.Forms.Label();

            this.txtTuTiengViet = new System.Windows.Forms.TextBox();
            this.lstTuTiengViet = new System.Windows.Forms.ListBox();
            this.txtNghiaTiengAnh = new System.Windows.Forms.TextBox();

            this.btnThoat = new System.Windows.Forms.Button();

            this.tabTuDien.SuspendLayout();
            this.tabAnhViet.SuspendLayout();
            this.tabVietAnh.SuspendLayout();
            this.SuspendLayout();

            //
            // tabTuDien
            //
            this.tabTuDien.Controls.Add(this.tabAnhViet);
            this.tabTuDien.Controls.Add(this.tabVietAnh);

            this.tabTuDien.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.tabTuDien.Location =
                new System.Drawing.Point(25, 30);

            this.tabTuDien.Name = "tabTuDien";

            this.tabTuDien.SelectedIndex = 0;

            this.tabTuDien.Size =
                new System.Drawing.Size(390, 335);

            this.tabTuDien.TabIndex = 0;

            //
            // tabAnhViet
            //
            this.tabAnhViet.Controls.Add(this.lblTiengAnh);
            this.tabAnhViet.Controls.Add(this.lblTiengViet);
            this.tabAnhViet.Controls.Add(this.txtTiengAnh);
            this.tabAnhViet.Controls.Add(this.lstTiengAnh);
            this.tabAnhViet.Controls.Add(this.txtNghiaTiengViet);

            this.tabAnhViet.Location =
                new System.Drawing.Point(4, 25);

            this.tabAnhViet.Name = "tabAnhViet";

            this.tabAnhViet.Padding =
                new System.Windows.Forms.Padding(3);

            this.tabAnhViet.Size =
                new System.Drawing.Size(382, 306);

            this.tabAnhViet.TabIndex = 0;

            this.tabAnhViet.Text = "ANH - VIỆT";
            this.tabAnhViet.UseVisualStyleBackColor = true;

            //
            // lblTiengAnh
            //
            this.lblTiengAnh.AutoSize = true;

            this.lblTiengAnh.Location =
                new System.Drawing.Point(10, 15);

            this.lblTiengAnh.Name = "lblTiengAnh";

            this.lblTiengAnh.Size =
                new System.Drawing.Size(73, 17);

            this.lblTiengAnh.TabIndex = 0;
            this.lblTiengAnh.Text = "Tiếng Anh";

            //
            // lblTiengViet
            //
            this.lblTiengViet.AutoSize = true;

            this.lblTiengViet.Location =
                new System.Drawing.Point(193, 15);

            this.lblTiengViet.Name = "lblTiengViet";

            this.lblTiengViet.Size =
                new System.Drawing.Size(72, 17);

            this.lblTiengViet.TabIndex = 1;
            this.lblTiengViet.Text = "Tiếng Việt";

            //
            // txtTiengAnh
            //
            this.txtTiengAnh.Location =
                new System.Drawing.Point(10, 37);

            this.txtTiengAnh.Name = "txtTiengAnh";

            this.txtTiengAnh.Size =
                new System.Drawing.Size(165, 23);

            this.txtTiengAnh.TabIndex = 2;

            //
            // lstTiengAnh
            //
            this.lstTiengAnh.FormattingEnabled = true;

            this.lstTiengAnh.ItemHeight = 16;

            this.lstTiengAnh.Location =
                new System.Drawing.Point(10, 60);

            this.lstTiengAnh.Name = "lstTiengAnh";

            this.lstTiengAnh.Size =
                new System.Drawing.Size(165, 228);

            this.lstTiengAnh.TabIndex = 3;

            this.lstTiengAnh.IntegralHeight = false;

            this.lstTiengAnh.Items.AddRange(new object[]
            {
                "student",
                "teacher",
                "worker",
                "hat",
                "head",
                "mouse",
                "cat",
                "dog",
                "snake",
                "lamb",
                "loan",
                "frog",
                "sheep"
            });

            //
            // txtNghiaTiengViet
            //
            this.txtNghiaTiengViet.Location =
                new System.Drawing.Point(193, 37);

            this.txtNghiaTiengViet.Multiline = true;

            this.txtNghiaTiengViet.Name =
                "txtNghiaTiengViet";

            this.txtNghiaTiengViet.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;

            this.txtNghiaTiengViet.Size =
                new System.Drawing.Size(175, 251);

            this.txtNghiaTiengViet.TabIndex = 4;

            this.txtNghiaTiengViet.Text =
                "Sinh viên, học sinh";

            //
            // tabVietAnh
            //
            this.tabVietAnh.Controls.Add(this.lblTuTiengViet);
            this.tabVietAnh.Controls.Add(this.lblNghiaTiengAnh);
            this.tabVietAnh.Controls.Add(this.txtTuTiengViet);
            this.tabVietAnh.Controls.Add(this.lstTuTiengViet);
            this.tabVietAnh.Controls.Add(this.txtNghiaTiengAnh);

            this.tabVietAnh.Location =
                new System.Drawing.Point(4, 25);

            this.tabVietAnh.Name = "tabVietAnh";

            this.tabVietAnh.Padding =
                new System.Windows.Forms.Padding(3);

            this.tabVietAnh.Size =
                new System.Drawing.Size(382, 306);

            this.tabVietAnh.TabIndex = 1;

            this.tabVietAnh.Text = "VIỆT - ANH";
            this.tabVietAnh.UseVisualStyleBackColor = true;

            //
            // lblTuTiengViet
            //
            this.lblTuTiengViet.AutoSize = true;

            this.lblTuTiengViet.Location =
                new System.Drawing.Point(10, 15);

            this.lblTuTiengViet.Name = "lblTuTiengViet";
            this.lblTuTiengViet.Text = "Tiếng Việt";

            //
            // lblNghiaTiengAnh
            //
            this.lblNghiaTiengAnh.AutoSize = true;

            this.lblNghiaTiengAnh.Location =
                new System.Drawing.Point(193, 15);

            this.lblNghiaTiengAnh.Name =
                "lblNghiaTiengAnh";

            this.lblNghiaTiengAnh.Text = "Tiếng Anh";

            //
            // txtTuTiengViet
            //
            this.txtTuTiengViet.Location =
                new System.Drawing.Point(10, 37);

            this.txtTuTiengViet.Name = "txtTuTiengViet";

            this.txtTuTiengViet.Size =
                new System.Drawing.Size(165, 23);

            this.txtTuTiengViet.TabIndex = 0;

            //
            // lstTuTiengViet
            //
            this.lstTuTiengViet.FormattingEnabled = true;

            this.lstTuTiengViet.ItemHeight = 16;
            this.lstTuTiengViet.IntegralHeight = false;

            this.lstTuTiengViet.Location =
                new System.Drawing.Point(10, 60);

            this.lstTuTiengViet.Name = "lstTuTiengViet";

            this.lstTuTiengViet.Size =
                new System.Drawing.Size(165, 228);

            this.lstTuTiengViet.TabIndex = 1;

            this.lstTuTiengViet.Items.AddRange(new object[]
            {
                "Sinh viên",
                "Giáo viên",
                "Công nhân",
                "Mũ",
                "Đầu",
                "Chuột",
                "Mèo",
                "Chó",
                "Rắn",
                "Cừu",
                "Ếch"
            });

            //
            // txtNghiaTiengAnh
            //
            this.txtNghiaTiengAnh.Location =
                new System.Drawing.Point(193, 37);

            this.txtNghiaTiengAnh.Multiline = true;

            this.txtNghiaTiengAnh.Name =
                "txtNghiaTiengAnh";

            this.txtNghiaTiengAnh.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;

            this.txtNghiaTiengAnh.Size =
                new System.Drawing.Size(175, 251);

            this.txtNghiaTiengAnh.TabIndex = 2;

            this.txtNghiaTiengAnh.Text = "student";

            //
            // btnThoat
            //
            this.btnThoat.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 10F);

            this.btnThoat.Location =
                new System.Drawing.Point(340, 372);

            this.btnThoat.Name = "btnThoat";

            this.btnThoat.Size =
                new System.Drawing.Size(100, 30);

            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;

            //
            // Form1
            //
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(455, 415);

            this.Controls.Add(this.tabTuDien);
            this.Controls.Add(this.btnThoat);

            this.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 8.25F);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Name = "Form1";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "TỪ ĐIỂN ANH VIỆT - VIỆT ANH";

            this.tabAnhViet.ResumeLayout(false);
            this.tabAnhViet.PerformLayout();

            this.tabVietAnh.ResumeLayout(false);
            this.tabVietAnh.PerformLayout();

            this.tabTuDien.ResumeLayout(false);

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabTuDien;
        private System.Windows.Forms.TabPage tabAnhViet;
        private System.Windows.Forms.TabPage tabVietAnh;

        private System.Windows.Forms.Label lblTiengAnh;
        private System.Windows.Forms.Label lblTiengViet;
        private System.Windows.Forms.TextBox txtTiengAnh;
        private System.Windows.Forms.ListBox lstTiengAnh;
        private System.Windows.Forms.TextBox txtNghiaTiengViet;

        private System.Windows.Forms.Label lblTuTiengViet;
        private System.Windows.Forms.Label lblNghiaTiengAnh;
        private System.Windows.Forms.TextBox txtTuTiengViet;
        private System.Windows.Forms.ListBox lstTuTiengViet;
        private System.Windows.Forms.TextBox txtNghiaTiengAnh;

        private System.Windows.Forms.Button btnThoat;
    }
}
