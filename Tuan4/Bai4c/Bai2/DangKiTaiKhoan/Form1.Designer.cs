namespace DangKiTaiKhoan
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.TenDangNhap = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.MatKhau = new System.Windows.Forms.TextBox();
            this.XacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.lblStar3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblStar3
            //
            this.lblStar3 = new System.Windows.Forms.Label();
            this.lblStar3.AutoSize = true;
            this.lblStar3.ForeColor = System.Drawing.Color.Red;
            this.lblStar3.Location = new System.Drawing.Point(400, 170);
            this.lblStar3.Name = "lblStar3";
            this.lblStar3.Text = "(*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Địa chỉ email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Xác nhận mật khẩu:";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.ForeColor = System.Drawing.Color.Blue;
            this.btnDangKy.Location = new System.Drawing.Point(180, 255);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(246, 35);
            this.btnDangKy.TabIndex = 9;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(180, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 37);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Đăng ký tài khoản";
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.Location = new System.Drawing.Point(180, 87);
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Size = new System.Drawing.Size(246, 22);
            this.TenDangNhap.TabIndex = 0;
            this.TenDangNhap.TextChanged += new System.EventHandler(this.TenDangNhap_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(180, 127);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(246, 22);
            this.email.TabIndex = 1;
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // MatKhau
            // 
            this.MatKhau.Location = new System.Drawing.Point(180, 167);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Size = new System.Drawing.Size(246, 22);
            this.MatKhau.TabIndex = 2;
            this.MatKhau.TextChanged += new System.EventHandler(this.MatKhau_TextChanged);
            this.MatKhau.UseSystemPasswordChar = true;
            // 
            // XacNhanMatKhau
            // 
            this.XacNhanMatKhau.Location = new System.Drawing.Point(180, 207);
            this.XacNhanMatKhau.Name = "XacNhanMatKhau";
            this.XacNhanMatKhau.Size = new System.Drawing.Size(246, 22);
            this.XacNhanMatKhau.TabIndex = 3;
            this.XacNhanMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XacNhanMatKhau_TextChanged);
            this.XacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 340);
            this.Controls.Add(this.XacNhanMatKhau);
            this.Controls.Add(this.MatKhau);
            this.Controls.Add(this.email);
            this.Controls.Add(this.TenDangNhap);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí tài khoản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox TenDangNhap;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox MatKhau;
        private System.Windows.Forms.TextBox XacNhanMatKhau;
        private System.Windows.Forms.Label lblStar3;
    }
}

