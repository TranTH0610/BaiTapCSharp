using System;
using System.Windows.Forms;

namespace BTVN_Tuan5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            // Gắn sự kiện cho các menu
            mnuBai1.Click += mnuBai1_Click;
            mnuBai2.Click += mnuBai2_Click;
            mnuBaiKhac.Click += mnuBaiKhac_Click;
        }

        // ==========================================
        // 0. SỰ KIỆN KHI FORM CHÍNH ĐƯỢC MỞ
        // ==========================================
        private void Form1_Load(object sender, EventArgs e)
        {
            // Cho phép FormMain chứa các Form con
            this.IsMdiContainer = true;
        }

        // ==========================================
        // 1. MỞ FORM BÀI 1
        // ==========================================
        private void mnuBai1_Click(object sender, EventArgs e)
        {
            MoFormMDI(new BaiTap1.Form1());
        }

        // ==========================================
        // 2. MỞ FORM BÀI 2
        // ==========================================
        private void mnuBai2_Click(object sender, EventArgs e)
        {
            MoFormMDI(new DongHoDemNguoc.Form1());
        }

        // ==========================================
        // 3. MENU CÁC BÀI KHÁC
        // ==========================================
        private void mnuBaiKhac_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Chưa có bài tập khác được thêm vào!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ==========================================
        // 4. HÀM MỞ FORM CON BÊN TRONG FORM CHÍNH
        // ==========================================
        private void MoFormMDI(Form formCon)
        {
            // Nếu Form cùng loại đang mở thì
            // không tạo thêm một cửa sổ trùng
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == formCon.GetType())
                {
                    frm.Activate();
                    formCon.Dispose();
                    return;
                }
            }

            // Đặt FormMain làm Form cha
            formCon.MdiParent = this;

            // Mở Form con
            formCon.Show();
        }
    }
}