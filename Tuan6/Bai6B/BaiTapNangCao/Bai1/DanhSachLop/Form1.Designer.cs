
namespace DanhSachLop
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
            this.btnHienThiDuLieu = new System.Windows.Forms.Button();
            this.dgvDanhSachLop = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();

            this.pnlNoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)
                (this.dgvDanhSachLop)).BeginInit();
            this.SuspendLayout();

            //
            // pnlNoiDung
            //
            this.pnlNoiDung.BackColor =
                System.Drawing.Color.FromArgb(245, 245, 245);

            this.pnlNoiDung.Controls.Add(this.btnHienThiDuLieu);
            this.pnlNoiDung.Controls.Add(this.dgvDanhSachLop);
            this.pnlNoiDung.Controls.Add(this.btnThoat);

            this.pnlNoiDung.Location =
                new System.Drawing.Point(5, 5);

            this.pnlNoiDung.Name = "pnlNoiDung";

            this.pnlNoiDung.Size =
                new System.Drawing.Size(596, 326);

            this.pnlNoiDung.TabIndex = 0;

            //
            // btnHienThiDuLieu
            //
            this.btnHienThiDuLieu.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 9F);

            this.btnHienThiDuLieu.Location =
                new System.Drawing.Point(33, 10);

            this.btnHienThiDuLieu.Name = "btnHienThiDuLieu";

            this.btnHienThiDuLieu.Size =
                new System.Drawing.Size(98, 25);

            this.btnHienThiDuLieu.TabIndex = 0;
            this.btnHienThiDuLieu.Text = "Hiển thị dữ liệu";
            this.btnHienThiDuLieu.UseVisualStyleBackColor = true;

            //
            // dgvDanhSachLop
            //
            this.dgvDanhSachLop.AllowUserToAddRows = false;
            this.dgvDanhSachLop.AllowUserToDeleteRows = false;

            this.dgvDanhSachLop.AllowUserToResizeRows = false;

            this.dgvDanhSachLop.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvDanhSachLop.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.dgvDanhSachLop.ColumnHeadersHeight = 26;

            this.dgvDanhSachLop.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode
                .DisableResizing;

            this.dgvDanhSachLop.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colSTT,
                    this.colMaLop,
                    this.colTenLop,
                    this.colMaKhoa
                });

            this.dgvDanhSachLop.EnableHeadersVisualStyles = false;

            this.dgvDanhSachLop.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(250, 250, 250);

            this.dgvDanhSachLop.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.Black;

            this.dgvDanhSachLop.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif",
                    9F,
                    System.Drawing.FontStyle.Regular);

            this.dgvDanhSachLop.DefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 9F);

            this.dgvDanhSachLop.GridColor =
                System.Drawing.Color.FromArgb(235, 235, 235);

            this.dgvDanhSachLop.Location =
                new System.Drawing.Point(33, 42);

            this.dgvDanhSachLop.Name = "dgvDanhSachLop";

            this.dgvDanhSachLop.ReadOnly = true;

            this.dgvDanhSachLop.RowHeadersVisible = false;

            this.dgvDanhSachLop.RowTemplate.Height = 22;

            this.dgvDanhSachLop.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvDanhSachLop.MultiSelect = false;

            this.dgvDanhSachLop.Size =
                new System.Drawing.Size(500, 221);

            this.dgvDanhSachLop.TabIndex = 1;

            //
            // colSTT
            //
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 73;
            this.colSTT.SortMode =
                System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            //
            // colMaLop
            //
            this.colMaLop.HeaderText = "Mã lớp";
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.ReadOnly = true;
            this.colMaLop.Width = 137;
            this.colMaLop.SortMode =
                System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            //
            // colTenLop
            //
            this.colTenLop.HeaderText = "Tên lớp";
            this.colTenLop.Name = "colTenLop";
            this.colTenLop.ReadOnly = true;
            this.colTenLop.Width = 181;
            this.colTenLop.SortMode =
                System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            //
            // colMaKhoa
            //
            this.colMaKhoa.HeaderText = "Mã khoa";
            this.colMaKhoa.Name = "colMaKhoa";
            this.colMaKhoa.ReadOnly = true;
            this.colMaKhoa.Width = 105;
            this.colMaKhoa.SortMode =
                System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            //
            // btnThoat
            //
            this.btnThoat.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 9F);

            this.btnThoat.Location =
                new System.Drawing.Point(408, 271);

            this.btnThoat.Name = "btnThoat";

            this.btnThoat.Size =
                new System.Drawing.Size(125, 42);

            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;

            //
            // Form1
            //
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(105, 190, 235);

            this.ClientSize =
                new System.Drawing.Size(606, 336);

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

            this.Text = "Danh sách Lớp";

            this.pnlNoiDung.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvDanhSachLop)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlNoiDung;

        private System.Windows.Forms.Button btnHienThiDuLieu;
        private System.Windows.Forms.DataGridView dgvDanhSachLop;

        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhoa;

        private System.Windows.Forms.Button btnThoat;
    }
}
