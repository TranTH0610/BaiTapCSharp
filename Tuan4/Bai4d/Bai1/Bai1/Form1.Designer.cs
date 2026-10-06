namespace Bai1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpChon;
        private System.Windows.Forms.RadioButton rdoBacNhat;
        private System.Windows.Forms.RadioButton rdoBacHai;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtKetQua;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpChon = new System.Windows.Forms.GroupBox();
            this.rdoBacHai = new System.Windows.Forms.RadioButton();
            this.rdoBacNhat = new System.Windows.Forms.RadioButton();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.grpChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(40, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(370, 35);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "GIẢI PHƯƠNG TRÌNH";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpChon
            // 
            this.grpChon.Controls.Add(this.rdoBacHai);
            this.grpChon.Controls.Add(this.rdoBacNhat);
            this.grpChon.Location = new System.Drawing.Point(30, 75);
            this.grpChon.Name = "grpChon";
            this.grpChon.Size = new System.Drawing.Size(390, 110);
            this.grpChon.TabIndex = 10;
            this.grpChon.TabStop = false;
            this.grpChon.Text = "Bạn vui lòng chọn";
            // 
            // rdoBacHai
            // 
            this.rdoBacHai.Location = new System.Drawing.Point(25, 65);
            this.rdoBacHai.Name = "rdoBacHai";
            this.rdoBacHai.Size = new System.Drawing.Size(220, 25);
            this.rdoBacHai.TabIndex = 0;
            this.rdoBacHai.Text = "Phương trình bậc hai";
            this.rdoBacHai.UseVisualStyleBackColor = true;
            // 
            // rdoBacNhat
            // 
            this.rdoBacNhat.Checked = true;
            this.rdoBacNhat.Location = new System.Drawing.Point(25, 30);
            this.rdoBacNhat.Name = "rdoBacNhat";
            this.rdoBacNhat.Size = new System.Drawing.Size(220, 25);
            this.rdoBacNhat.TabIndex = 1;
            this.rdoBacNhat.TabStop = true;
            this.rdoBacNhat.Text = "Phương trình bậc nhất";
            this.rdoBacNhat.UseVisualStyleBackColor = true;
            // 
            // lblA
            // 
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblA.Location = new System.Drawing.Point(12, 203);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(70, 25);
            this.lblA.TabIndex = 9;
            this.lblA.Text = "Nhập a:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(115, 203);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(210, 22);
            this.txtA.TabIndex = 8;
            // 
            // lblB
            // 
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblB.Location = new System.Drawing.Point(12, 251);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(79, 25);
            this.lblB.TabIndex = 7;
            this.lblB.Text = "Nhập b:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(115, 248);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(210, 22);
            this.txtB.TabIndex = 6;
            // 
            // lblC
            // 
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblC.ForeColor = System.Drawing.Color.Gray;
            this.lblC.Location = new System.Drawing.Point(12, 294);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(79, 25);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "Nhập c:";
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Location = new System.Drawing.Point(115, 293);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(210, 22);
            this.txtC.TabIndex = 4;
            // 
            // btnGiai
            // 
            this.btnGiai.Enabled = false;
            this.btnGiai.Location = new System.Drawing.Point(335, 203);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(85, 73);
            this.btnGiai.TabIndex = 3;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(335, 285);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 45);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // lblKetQua
            // 
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblKetQua.Location = new System.Drawing.Point(12, 359);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(79, 25);
            this.lblKetQua.TabIndex = 1;
            this.lblKetQua.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(115, 348);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(305, 85);
            this.txtKetQua.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(460, 500);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.grpChon);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giải phương trình bậc 1-2";
            this.grpChon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}