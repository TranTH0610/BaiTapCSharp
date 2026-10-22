
namespace DanhSachSinhVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlNoiDung = new System.Windows.Forms.Panel();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.btnLocDuLieu = new System.Windows.Forms.Button();
            this.dgvDanhSachSinhVien = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTongDiem = new System.Windows.Forms.Label();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.pnlNoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNoiDung
            // 
            this.pnlNoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlNoiDung.Controls.Add(this.lblMonHoc);
            this.pnlNoiDung.Controls.Add(this.cboMonHoc);
            this.pnlNoiDung.Controls.Add(this.btnLocDuLieu);
            this.pnlNoiDung.Controls.Add(this.dgvDanhSachSinhVien);
            this.pnlNoiDung.Controls.Add(this.lblTongDiem);
            this.pnlNoiDung.Controls.Add(this.txtTongDiem);
            this.pnlNoiDung.Location = new System.Drawing.Point(5, 5);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Size = new System.Drawing.Size(650, 407);
            this.pnlNoiDung.TabIndex = 0;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMonHoc.Location = new System.Drawing.Point(30, 30);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(67, 18);
            this.lblMonHoc.TabIndex = 0;
            this.lblMonHoc.Text = "Môn học";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(115, 23);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(235, 28);
            this.cboMonHoc.TabIndex = 1;
            // 
            // btnLocDuLieu
            // 
            this.btnLocDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLocDuLieu.Location = new System.Drawing.Point(402, 23);
            this.btnLocDuLieu.Name = "btnLocDuLieu";
            this.btnLocDuLieu.Size = new System.Drawing.Size(108, 26);
            this.btnLocDuLieu.TabIndex = 2;
            this.btnLocDuLieu.Text = "Lọc dữ liệu";
            this.btnLocDuLieu.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSachSinhVien
            // 
            this.dgvDanhSachSinhVien.AllowUserToAddRows = false;
            this.dgvDanhSachSinhVien.AllowUserToDeleteRows = false;
            this.dgvDanhSachSinhVien.AllowUserToResizeRows = false;
            this.dgvDanhSachSinhVien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachSinhVien.ColumnHeadersHeight = 25;
            this.dgvDanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDanhSachSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colTenSV,
            this.colNgaySinh,
            this.colTenMonHoc,
            this.colDiem});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachSinhVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachSinhVien.EnableHeadersVisualStyles = false;
            this.dgvDanhSachSinhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvDanhSachSinhVien.Location = new System.Drawing.Point(30, 65);
            this.dgvDanhSachSinhVien.MultiSelect = false;
            this.dgvDanhSachSinhVien.Name = "dgvDanhSachSinhVien";
            this.dgvDanhSachSinhVien.ReadOnly = true;
            this.dgvDanhSachSinhVien.RowHeadersVisible = false;
            this.dgvDanhSachSinhVien.RowHeadersWidth = 51;
            this.dgvDanhSachSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachSinhVien.Size = new System.Drawing.Size(598, 278);
            this.dgvDanhSachSinhVien.TabIndex = 3;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSTT.Width = 42;
            // 
            // colTenSV
            // 
            this.colTenSV.HeaderText = "Tên SV";
            this.colTenSV.MinimumWidth = 6;
            this.colTenSV.Name = "colTenSV";
            this.colTenSV.ReadOnly = true;
            this.colTenSV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTenSV.Width = 160;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.ReadOnly = true;
            this.colNgaySinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNgaySinh.Width = 130;
            // 
            // colTenMonHoc
            // 
            this.colTenMonHoc.HeaderText = "Tên môn học";
            this.colTenMonHoc.MinimumWidth = 6;
            this.colTenMonHoc.Name = "colTenMonHoc";
            this.colTenMonHoc.ReadOnly = true;
            this.colTenMonHoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTenMonHoc.Width = 140;
            // 
            // colDiem
            // 
            this.colDiem.HeaderText = "Điểm";
            this.colDiem.MinimumWidth = 6;
            this.colDiem.Name = "colDiem";
            this.colDiem.ReadOnly = true;
            this.colDiem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDiem.Width = 105;
            // 
            // lblTongDiem
            // 
            this.lblTongDiem.AutoSize = true;
            this.lblTongDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTongDiem.Location = new System.Drawing.Point(323, 369);
            this.lblTongDiem.Name = "lblTongDiem";
            this.lblTongDiem.Size = new System.Drawing.Size(78, 18);
            this.lblTongDiem.TabIndex = 4;
            this.lblTongDiem.Text = "Tổng điểm";
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTongDiem.Location = new System.Drawing.Point(403, 365);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.ReadOnly = true;
            this.txtTongDiem.Size = new System.Drawing.Size(93, 24);
            this.txtTongDiem.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(660, 417);
            this.Controls.Add(this.pnlNoiDung);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.pnlNoiDung.ResumeLayout(false);
            this.pnlNoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNoiDung;

        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Button btnLocDuLieu;

        private System.Windows.Forms.DataGridView dgvDanhSachSinhVien;

        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem;

        private System.Windows.Forms.Label lblTongDiem;
        private System.Windows.Forms.TextBox txtTongDiem;
    }
}
