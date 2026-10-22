
namespace BTVN_Tuan5
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();

            this.mnuBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaiKhac = new System.Windows.Forms.ToolStripMenuItem();

            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            //
            // menuStrip1
            //
            this.menuStrip1.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 9F);

            this.menuStrip1.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.mnuBai1,
                    this.mnuBai2,
                    this.mnuBaiKhac
                });

            this.menuStrip1.Location =
                new System.Drawing.Point(0, 0);

            this.menuStrip1.Name = "menuStrip1";

            this.menuStrip1.Size =
                new System.Drawing.Size(660, 26);

            this.menuStrip1.TabIndex = 0;

            //
            // mnuBai1
            //
            this.mnuBai1.Name = "mnuBai1";
            this.mnuBai1.Size =
                new System.Drawing.Size(51, 22);

            this.mnuBai1.Text = "Bài 1";

            //
            // mnuBai2
            //
            this.mnuBai2.Name = "mnuBai2";
            this.mnuBai2.Size =
                new System.Drawing.Size(51, 22);

            this.mnuBai2.Text = "Bài 2";

            //
            // mnuBaiKhac
            //
            this.mnuBaiKhac.Name = "mnuBaiKhac";
            this.mnuBaiKhac.Size =
                new System.Drawing.Size(35, 22);

            this.mnuBaiKhac.Text = "...";

            //
            // FormMain
            //
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(660, 430);

            this.Controls.Add(this.menuStrip1);

            this.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif", 8.25F);

            // Cho phép các Form bài tập mở bên trong Form chính
            this.IsMdiContainer = true;

            this.MainMenuStrip = this.menuStrip1;

            this.Name = "FormMain";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "BTVN_Tuan6";

            this.WindowState =
                System.Windows.Forms.FormWindowState.Normal;

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.ToolStripMenuItem mnuBai1;
        private System.Windows.Forms.ToolStripMenuItem mnuBai2;
        private System.Windows.Forms.ToolStripMenuItem mnuBaiKhac;
    }
}
