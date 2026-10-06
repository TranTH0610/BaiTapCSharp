namespace BaiTapVeNha
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtDisplay;

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;

        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();

            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();

            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();

            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máy Tính Bỏ Túi";
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);

            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                18F,
                System.Drawing.FontStyle.Bold
            );

            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Máy Tính Bỏ Túi";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                14F
            );

            this.txtDisplay.ForeColor = System.Drawing.Color.Blue;
            this.txtDisplay.Location = new System.Drawing.Point(30, 75);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(300, 30);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.Text = "";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(30, 125);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(65, 45);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;

            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(108, 125);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(65, 45);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;

            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(186, 125);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(65, 45);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;

            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(264, 125);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(65, 45);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;

            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(30, 180);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(65, 45);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;

            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(108, 180);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(65, 45);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;

            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(186, 180);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(65, 45);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;

            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(264, 180);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(65, 45);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;

            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(30, 235);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(65, 45);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;

            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(108, 235);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(65, 45);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;

            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(186, 235);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(65, 45);
            this.btnEqual.TabIndex = 12;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;

            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(264, 235);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 45);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;

            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(30, 290);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(65, 45);
            this.btnPlus.TabIndex = 14;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;

            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(108, 290);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(65, 45);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;

            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(186, 290);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(65, 45);
            this.btnMultiply.TabIndex = 16;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;

            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(264, 290);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(65, 45);
            this.btnDivide.TabIndex = 17;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;

            // 
            // Add controls
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtDisplay);

            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);

            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);

            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnClear);

            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}