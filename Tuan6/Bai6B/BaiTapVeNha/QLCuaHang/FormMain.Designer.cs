using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLCuaHang
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabs;

        private DataGridView gridTon;
        private DataGridView gridHang;
        private DataGridView gridHoaDon;
        private DataGridView gridChiTiet;

        private TextBox txtTen;
        private TextBox txtMaHD;

        private ComboBox cboSanPham;
        private NumericUpDown numSoLuong;

        private Button btnThemDong;
        private Button btnHuyDong;
        private Button btnThanhToan;
        private Button btnXoaRong;

        private Label lblTrangThai;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components =
                new System.ComponentModel.Container();

            // =============================
            // FORM CHÍNH
            // =============================

            this.Text = "QLCuaHang • Quản lý cửa hàng";

            this.Font = new Font("Segoe UI", 10F);

            this.ClientSize = new Size(1080, 740);

            this.MinimumSize = new Size(1000, 700);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.BackColor =
                Color.FromArgb(244, 247, 251);

            // =============================
            // MENU
            // =============================

            MenuStrip menu = new MenuStrip();

            menu.Items.Add(
                "Tạo tồn kho hôm nay",
                null,
                (s, e) => TaoTon());

            menu.Items.Add(
                "Thêm sản phẩm mới",
                null,
                (s, e) => tabs.SelectedIndex = 1);

            menu.Items.Add(
                "Bán hàng",
                null,
                (s, e) => tabs.SelectedIndex = 2);

            menu.Items.Add(
                "Làm mới",
                null,
                (s, e) => Safe(LoadAll));

            menu.Items.Add(
                "Kết thúc",
                null,
                (s, e) => Close());

            this.MainMenuStrip = menu;

            // =============================
            // TIÊU ĐỀ
            // =============================

            Label title = new Label
            {
                Text = "QUẢN LÝ CỬA HÀNG",

                Dock = DockStyle.Top,

                Height = 64,

                Font = new Font(
                    "Segoe UI",
                    20F,
                    FontStyle.Bold),

                ForeColor = Color.White,

                BackColor = Color.FromArgb(28, 58, 91),

                Padding = new Padding(20, 10, 0, 0)
            };

            // =============================
            // THANH TRẠNG THÁI
            // =============================

            lblTrangThai = new Label
            {
                Dock = DockStyle.Bottom,

                Height = 30,

                Padding = new Padding(12, 5, 0, 0),

                Text = "Sẵn sàng"
            };

            // =============================
            // BA TAB CHỨC NĂNG
            // =============================

            tabs = new TabControl
            {
                Dock = DockStyle.Fill,

                Padding = new Point(20, 8)
            };

            TabPage tabTon = new TabPage("01  Tồn kho")
            {
                Padding = new Padding(14)
            };

            TabPage tabSanPham =
                new TabPage("02  Thêm sản phẩm")
                {
                    Padding = new Padding(14)
                };

            TabPage tabBanHang =
                new TabPage("03  Bán hàng & thanh toán")
                {
                    Padding = new Padding(14)
                };

            tabs.TabPages.AddRange(
                new TabPage[]
                {
                    tabTon,
                    tabSanPham,
                    tabBanHang
                });

            // =============================
            // TAB TỒN KHO
            // =============================

            gridTon = CreateGrid();

            gridTon.Name = "gridTonKho";

            FlowLayoutPanel tonBar = CreateBar(60);

            tonBar.Controls.Add(
                CreateButton(
                    "Tạo tồn hôm nay",
                    (s, e) => TaoTon()));

            tonBar.Controls.Add(
                new Label
                {
                    AutoSize = true,

                    Text =
                        "Tồn còn lại = SL đầu + SL nhập − SL bán",

                    Margin = new Padding(12, 15, 0, 0)
                });

            tabTon.Controls.Add(gridTon);
            tabTon.Controls.Add(tonBar);

            // =============================
            // TAB THÊM SẢN PHẨM
            // =============================

            FlowLayoutPanel productBar = CreateBar(70);

            productBar.Controls.Add(
                new Label
                {
                    Text = "Tên sản phẩm",

                    AutoSize = true,

                    Margin = new Padding(0, 14, 8, 0)
                });

            txtTen = new TextBox
            {
                Name = "txtTenSP",

                Width = 340,

                MaxLength = 100,

                Margin = new Padding(0, 9, 10, 0)
            };

            productBar.Controls.Add(txtTen);

            productBar.Controls.Add(
                CreateButton(
                    "Thêm sản phẩm",
                    (s, e) => ThemSanPham()));

            gridHang = CreateGrid();

            gridHang.Name = "gridSanPham";

            tabSanPham.Controls.Add(gridHang);
            tabSanPham.Controls.Add(productBar);

            // =============================
            // TAB BÁN HÀNG
            // =============================

            TableLayoutPanel salesLayout =
                new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,

                    ColumnCount = 1,

                    RowCount = 4
                };

            salesLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 65));

            salesLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 65));

            salesLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 55));

            salesLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 45));

            // Hàng điều khiển hóa đơn.
            FlowLayoutPanel invoiceBar = CreateBar(65);

            invoiceBar.Dock = DockStyle.Fill;

            invoiceBar.Controls.Add(
                CreateButton(
                    "Tạo hóa đơn mới",
                    (s, e) => TaoHoaDon()));

            invoiceBar.Controls.Add(
                new Label
                {
                    Text = "Mã hóa đơn",

                    AutoSize = true,

                    Margin = new Padding(15, 14, 8, 0)
                });

            txtMaHD = new TextBox
            {
                ReadOnly = true,

                Width = 65,

                Margin = new Padding(0, 9, 10, 0)
            };

            invoiceBar.Controls.Add(txtMaHD);

            btnThanhToan = CreateButton(
                "Thanh toán",
                (s, e) => ThanhToan());

            invoiceBar.Controls.Add(btnThanhToan);

            btnXoaRong = CreateButton(
                "Xóa hóa đơn rỗng",
                (s, e) => XoaRong());

            invoiceBar.Controls.Add(btnXoaRong);

            // Hàng nhập sản phẩm và số lượng.
            FlowLayoutPanel lineBar = CreateBar(65);

            lineBar.Dock = DockStyle.Fill;

            lineBar.Controls.Add(
                new Label
                {
                    Text = "Sản phẩm",

                    AutoSize = true,

                    Margin = new Padding(0, 14, 8, 0)
                });

            cboSanPham = new ComboBox
            {
                Width = 300,

                DropDownStyle =
                    ComboBoxStyle.DropDownList,

                Margin = new Padding(0, 9, 10, 0)
            };

            lineBar.Controls.Add(cboSanPham);

            lineBar.Controls.Add(
                new Label
                {
                    Text = "Số lượng",

                    AutoSize = true,

                    Margin = new Padding(0, 14, 8, 0)
                });

            numSoLuong = new NumericUpDown
            {
                Minimum = 1,

                Maximum = 1000000,

                Width = 85,

                Margin = new Padding(0, 9, 10, 0)
            };

            lineBar.Controls.Add(numSoLuong);

            btnThemDong = CreateButton(
                "Thêm vào hóa đơn",
                (s, e) => ThemDong());

            lineBar.Controls.Add(btnThemDong);

            btnHuyDong = CreateButton(
                "Hủy dòng đã chọn",
                (s, e) => HuyDong());

            lineBar.Controls.Add(btnHuyDong);

            // Bảng chi tiết hóa đơn.
            GroupBox detailGroup = new GroupBox
            {
                Text = "Chi tiết hóa đơn đang chọn",

                Dock = DockStyle.Fill,

                Padding = new Padding(8, 24, 8, 8)
            };

            gridChiTiet = CreateGrid();

            detailGroup.Controls.Add(gridChiTiet);

            // Bảng danh sách hóa đơn.
            GroupBox invoiceGroup = new GroupBox
            {
                Text =
                    "Danh sách hóa đơn • chọn để xem / tiếp tục bán",

                Dock = DockStyle.Fill,

                Padding = new Padding(8, 24, 8, 8)
            };

            gridHoaDon = CreateGrid();

            gridHoaDon.SelectionChanged +=
                (s, e) => ChonHoaDon();

            invoiceGroup.Controls.Add(gridHoaDon);

            salesLayout.Controls.Add(invoiceBar, 0, 0);
            salesLayout.Controls.Add(lineBar, 0, 1);
            salesLayout.Controls.Add(detailGroup, 0, 2);
            salesLayout.Controls.Add(invoiceGroup, 0, 3);

            tabBanHang.Controls.Add(salesLayout);

            // =============================
            // ĐƯA CONTROL VÀO FORM
            // =============================

            this.Controls.Add(tabs);
            this.Controls.Add(title);
            this.Controls.Add(menu);
            this.Controls.Add(lblTrangThai);

            // Tải dữ liệu khi form xuất hiện.
            this.Shown += (s, e) => Safe(LoadAll);

            // Hỏi trước khi kết thúc.
            this.FormClosing += (s, e) =>
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn kết thúc chương trình?\n" +
                    "Hóa đơn chưa thanh toán vẫn được lưu.",
                    "Kết thúc",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            };

            SetEditing(false);
        }

        // Tạo thanh chứa các control nằm ngang.
        private static FlowLayoutPanel CreateBar(int height)
        {
            return new FlowLayoutPanel
            {
                Dock = DockStyle.Top,

                Height = height,

                WrapContents = false,

                AutoScroll = true
            };
        }

        // Tạo button dùng chung kiểu trình bày.
        private static Button CreateButton(
            string text,
            EventHandler click)
        {
            Button button = new Button
            {
                Text = text,

                AutoSize = true,

                Height = 38,

                MinimumSize = new Size(110, 38),

                FlatStyle = FlatStyle.Flat,

                BackColor = Color.FromArgb(31, 105, 160),

                ForeColor = Color.White,

                Margin = new Padding(0, 5, 10, 5)
            };

            button.Click += click;

            return button;
        }

        // Tạo DataGridView chỉ cho xem dữ liệu.
        private static DataGridView CreateGrid()
        {
            return new DataGridView
            {
                Dock = DockStyle.Fill,

                ReadOnly = true,

                AllowUserToAddRows = false,

                AllowUserToDeleteRows = false,

                MultiSelect = false,

                SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect,

                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill,

                BackgroundColor = Color.White,

                BorderStyle = BorderStyle.None,

                RowHeadersVisible = false,

                AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.AllCells,

                ColumnHeadersHeight = 38
            };
        }
    }
}