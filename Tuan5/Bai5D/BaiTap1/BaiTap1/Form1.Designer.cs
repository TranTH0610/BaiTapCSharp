
namespace BaiTap1
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgoaiNgu = new System.Windows.Forms.Label();
            this.lblDanToc = new System.Windows.Forms.Label();

            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();

            this.grpGioiTinh = new System.Windows.Forms.Panel();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();

            this.chkAnh = new System.Windows.Forms.CheckBox();
            this.chkPhap = new System.Windows.Forms.CheckBox();
            this.chkHoa = new System.Windows.Forms.CheckBox();

            this.cboDanToc = new System.Windows.Forms.ComboBox();

            this.dgvSinhVien = new System.Windows.Forms.DataGridView();

            this.colHoTen =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colMaSV =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colGioiTinh =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colNgoaiNgu =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colDanToc =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();

            this.grpGioiTinh.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvSinhVien)).BeginInit();

            this.SuspendLayout();

            //
            // lblHoTen
            //
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 9F);

            this.lblHoTen.Location =
                new System.Drawing.Point(50, 25);

            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ và Tên";

            //
            // txtHoTen
            //
            this.txtHoTen.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 9F);

            this.txtHoTen.Location =
                new System.Drawing.Point(137, 18);

            this.txtHoTen.Name = "txtHoTen";

            this.txtHoTen.Size =
                new System.Drawing.Size(152, 21);

            this.txtHoTen.TabIndex = 1;

            //
            // lblMaSV
            //
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 9F);

            this.lblMaSV.Location =
                new System.Drawing.Point(50, 55);

            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.TabIndex = 2;
            this.lblMaSV.Text = "Mã sinh viên";

            //
            // txtMaSV
            //
            this.txtMaSV.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 9F);

            this.txtMaSV.Location =
                new System.Drawing.Point(137, 48);

            this.txtMaSV.Name = "txtMaSV";

            this.txtMaSV.Size =
                new System.Drawing.Size(152, 21);

            this.txtMaSV.TabIndex = 3;

            //
            // lblGioiTinh
            //
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 9F);

            this.lblGioiTinh.Location =
                new System.Drawing.Point(50, 84);

            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Text = "Giới tính";

            //
            // grpGioiTinh
            //
            this.grpGioiTinh.Controls.Add(this.radNam);
            this.grpGioiTinh.Controls.Add(this.radNu);

            this.grpGioiTinh.Location =
                new System.Drawing.Point(132, 76);

            this.grpGioiTinh.Name = "grpGioiTinh";

            this.grpGioiTinh.Size =
                new System.Drawing.Size(160, 27);

            this.grpGioiTinh.TabIndex = 4;

            //
            // radNam
            //
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;

            this.radNam.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 9F);

            this.radNam.Location =
                new System.Drawing.Point(5, 4);

            this.radNam.Name = "radNam";
            this.radNam.Size =
                new System.Drawing.Size(54, 19);

            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;

            //
            // radNu
            //
            this.radNu.AutoSize = true;

            this.radNu.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 9F);

            this.radNu.Location =
                new System.Drawing.Point(72, 4);

            this.radNu.Name = "radNu";
            this.radNu.Size =
                new System.Drawing.Size(43, 19);

            this.radNu.TabIndex = 1;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;

            //
            // lblNgoaiNgu
            //
            this.lblNgoaiNgu.AutoSize = true;

            this.lblNgoaiNgu.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 9F);

            this.lblNgoaiNgu.Location =
                new System.Drawing.Point(50, 113);

            this.lblNgoaiNgu.Name = "lblNgoaiNgu";
            this.lblNgoaiNgu.Text = "Ngoại ngữ";

            //
            // chkAnh
            //
            this.chkAnh.AutoSize = true;

            this.chkAnh.Checked = true;
            this.chkAnh.CheckState =
                System.Windows.Forms.CheckState.Checked;

            this.chkAnh.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 9F);

            this.chkAnh.Location =
                new System.Drawing.Point(137, 108);

            this.chkAnh.Name = "chkAnh";
            this.chkAnh.Size =
                new System.Drawing.Size(48, 19);

            this.chkAnh.TabIndex = 5;
            this.chkAnh.Text = "Anh";
            this.chkAnh.UseVisualStyleBackColor = true;

            //
            // chkPhap
            //
            this.chkPhap.AutoSize = true;

            this.chkPhap.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 9F);

            this.chkPhap.Location =
                new System.Drawing.Point(195, 108);

            this.chkPhap.Name = "chkPhap";
            this.chkPhap.Size =
                new System.Drawing.Size(54, 19);

            this.chkPhap.TabIndex = 6;
            this.chkPhap.Text = "Pháp";
            this.chkPhap.UseVisualStyleBackColor = true;

            //
            // chkHoa
            //
            this.chkHoa.AutoSize = true;

            this.chkHoa.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 9F);

            this.chkHoa.Location =
                new System.Drawing.Point(255, 108);

            this.chkHoa.Name = "chkHoa";
            this.chkHoa.Size =
                new System.Drawing.Size(49, 19);

            this.chkHoa.TabIndex = 7;
            this.chkHoa.Text = "Hoa";
            this.chkHoa.UseVisualStyleBackColor = true;

            //
            // lblDanToc
            //
            this.lblDanToc.AutoSize = true;

            this.lblDanToc.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 9F);

            this.lblDanToc.Location =
                new System.Drawing.Point(50, 144);

            this.lblDanToc.Name = "lblDanToc";
            this.lblDanToc.Text = "Dân tộc";

            //
            // cboDanToc
            //
            this.cboDanToc.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboDanToc.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 9F);

            this.cboDanToc.FormattingEnabled = true;

            this.cboDanToc.Items.AddRange(new object[]
            {
                "Kinh"
            });

            this.cboDanToc.Location =
                new System.Drawing.Point(137, 134);

            this.cboDanToc.Name = "cboDanToc";

            this.cboDanToc.Size =
                new System.Drawing.Size(152, 23);

            this.cboDanToc.TabIndex = 8;
            this.cboDanToc.SelectedIndex = 0;

            //
            // dgvSinhVien
            //
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AllowUserToResizeRows = false;

            this.dgvSinhVien.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvSinhVien.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.dgvSinhVien.ColumnHeadersHeight = 25;

            this.dgvSinhVien.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode
                .DisableResizing;

            this.dgvSinhVien.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colHoTen,
                    this.colMaSV,
                    this.colGioiTinh,
                    this.colNgoaiNgu,
                    this.colDanToc
                });

            this.dgvSinhVien.Location =
                new System.Drawing.Point(7, 165);

            this.dgvSinhVien.Name = "dgvSinhVien";

            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersVisible = false;

            this.dgvSinhVien.RowTemplate.Height = 22;

            this.dgvSinhVien.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvSinhVien.MultiSelect = false;

            this.dgvSinhVien.Size =
                new System.Drawing.Size(328, 114);

            this.dgvSinhVien.TabIndex = 9;

            this.dgvSinhVien.GridColor =
                System.Drawing.Color.FromArgb(238, 238, 238);

            this.dgvSinhVien.EnableHeadersVisualStyles = false;

            this.dgvSinhVien.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.WhiteSmoke;

            this.dgvSinhVien.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 8F);

            //
            // colHoTen
            //
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            this.colHoTen.Width = 122;

            //
            // colMaSV
            //
            this.colMaSV.HeaderText = "Mã sinh viên";
            this.colMaSV.Name = "colMaSV";
            this.colMaSV.ReadOnly = true;
            this.colMaSV.Width = 100;

            //
            // colGioiTinh
            //
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            this.colGioiTinh.Width = 72;

            //
            // colNgoaiNgu
            //
            this.colNgoaiNgu.HeaderText = "Ngoại ngữ";
            this.colNgoaiNgu.Name = "colNgoaiNgu";
            this.colNgoaiNgu.ReadOnly = true;
            this.colNgoaiNgu.Width = 95;

            //
            // colDanToc
            //
            this.colDanToc.HeaderText = "Dân tộc";
            this.colDanToc.Name = "colDanToc";
            this.colDanToc.ReadOnly = true;
            this.colDanToc.Width = 65;

            //
            // btnThem
            //
            this.btnThem.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 9F);

            this.btnThem.Location =
                new System.Drawing.Point(56, 290);

            this.btnThem.Name = "btnThem";

            this.btnThem.Size =
                new System.Drawing.Size(68, 29);

            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "✚ Thêm";
            this.btnThem.UseVisualStyleBackColor = true;

            //
            // btnXoa
            //
            this.btnXoa.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 9F);

            this.btnXoa.Location =
                new System.Drawing.Point(145, 290);

            this.btnXoa.Name = "btnXoa";

            this.btnXoa.Size =
                new System.Drawing.Size(68, 29);

            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "⊖ Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;

            //
            // btnSua
            //
            this.btnSua.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 9F);

            this.btnSua.Location =
                new System.Drawing.Point(230, 290);

            this.btnSua.Name = "btnSua";

            this.btnSua.Size =
                new System.Drawing.Size(68, 29);

            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "◉ Sửa";
            this.btnSua.UseVisualStyleBackColor = true;

            //
            // Form1
            //
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.WhiteSmoke;

            this.ClientSize =
                new System.Drawing.Size(342, 325);

            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);

            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.txtMaSV);

            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.grpGioiTinh);

            this.Controls.Add(this.lblNgoaiNgu);
            this.Controls.Add(this.chkAnh);
            this.Controls.Add(this.chkPhap);
            this.Controls.Add(this.chkHoa);

            this.Controls.Add(this.lblDanToc);
            this.Controls.Add(this.cboDanToc);

            this.Controls.Add(this.dgvSinhVien);

            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Name = "Form1";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "frmBaitap1";

            this.grpGioiTinh.ResumeLayout(false);
            this.grpGioiTinh.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvSinhVien)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgoaiNgu;
        private System.Windows.Forms.Label lblDanToc;

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;

        private System.Windows.Forms.Panel grpGioiTinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;

        private System.Windows.Forms.CheckBox chkAnh;
        private System.Windows.Forms.CheckBox chkPhap;
        private System.Windows.Forms.CheckBox chkHoa;

        private System.Windows.Forms.ComboBox cboDanToc;

        private System.Windows.Forms.DataGridView dgvSinhVien;

        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgoaiNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDanToc;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}
