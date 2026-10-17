
namespace BaiTapTreeView
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList();

            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();

            //
            // treeView1
            //
            this.treeView1.Font =
                new System.Drawing.Font(
                    "Times New Roman", 13F);

            this.treeView1.Location =
                new System.Drawing.Point(14, 15);

            this.treeView1.Name = "treeView1";

            this.treeView1.Size =
                new System.Drawing.Size(245, 395);

            this.treeView1.TabIndex = 0;

            this.treeView1.HideSelection = false;

            this.treeView1.ImageList = this.imageList1;

            //
            // Tạo các node A đến Z
            //
            System.Windows.Forms.TreeNode treeNode1 =
                new System.Windows.Forms.TreeNode("A");

            System.Windows.Forms.TreeNode treeNode2 =
                new System.Windows.Forms.TreeNode("B");

            System.Windows.Forms.TreeNode treeNode3 =
                new System.Windows.Forms.TreeNode("C");

            System.Windows.Forms.TreeNode treeNode4 =
                new System.Windows.Forms.TreeNode("D");

            System.Windows.Forms.TreeNode treeNode5 =
                new System.Windows.Forms.TreeNode("E");

            System.Windows.Forms.TreeNode treeNode6 =
                new System.Windows.Forms.TreeNode("F");

            System.Windows.Forms.TreeNode treeNode7 =
                new System.Windows.Forms.TreeNode("G");

            System.Windows.Forms.TreeNode treeNode8 =
                new System.Windows.Forms.TreeNode("H");

            System.Windows.Forms.TreeNode treeNode9 =
                new System.Windows.Forms.TreeNode("I");

            System.Windows.Forms.TreeNode treeNode10 =
                new System.Windows.Forms.TreeNode("J");

            System.Windows.Forms.TreeNode treeNode11 =
                new System.Windows.Forms.TreeNode("K");

            System.Windows.Forms.TreeNode treeNode12 =
                new System.Windows.Forms.TreeNode("L");

            System.Windows.Forms.TreeNode treeNode13 =
                new System.Windows.Forms.TreeNode("M");

            System.Windows.Forms.TreeNode treeNode14 =
                new System.Windows.Forms.TreeNode("N");

            System.Windows.Forms.TreeNode treeNode15 =
                new System.Windows.Forms.TreeNode("O");

            System.Windows.Forms.TreeNode treeNode16 =
                new System.Windows.Forms.TreeNode("P");

            System.Windows.Forms.TreeNode treeNode17 =
                new System.Windows.Forms.TreeNode("Q");

            System.Windows.Forms.TreeNode treeNode18 =
                new System.Windows.Forms.TreeNode("R");

            System.Windows.Forms.TreeNode treeNode19 =
                new System.Windows.Forms.TreeNode("S");

            System.Windows.Forms.TreeNode treeNode20 =
                new System.Windows.Forms.TreeNode("T");

            System.Windows.Forms.TreeNode treeNode21 =
                new System.Windows.Forms.TreeNode("U");

            System.Windows.Forms.TreeNode treeNode22 =
                new System.Windows.Forms.TreeNode("V");

            System.Windows.Forms.TreeNode treeNode23 =
                new System.Windows.Forms.TreeNode("W");

            System.Windows.Forms.TreeNode treeNode24 =
                new System.Windows.Forms.TreeNode("X");

            System.Windows.Forms.TreeNode treeNode25 =
                new System.Windows.Forms.TreeNode("Y");

            System.Windows.Forms.TreeNode treeNode26 =
                new System.Windows.Forms.TreeNode("Z");

            //
            // Thêm các node vào TreeView
            //
            this.treeView1.Nodes.AddRange(
                new System.Windows.Forms.TreeNode[]
                {
                    treeNode1,
                    treeNode2,
                    treeNode3,
                    treeNode4,
                    treeNode5,
                    treeNode6,
                    treeNode7,
                    treeNode8,
                    treeNode9,
                    treeNode10,
                    treeNode11,
                    treeNode12,
                    treeNode13,
                    treeNode14,
                    treeNode15,
                    treeNode16,
                    treeNode17,
                    treeNode18,
                    treeNode19,
                    treeNode20,
                    treeNode21,
                    treeNode22,
                    treeNode23,
                    treeNode24,
                    treeNode25,
                    treeNode26
                });

            //
            // grpThongTin
            //
            this.grpThongTin.Controls.Add(this.lblFirstName);
            this.grpThongTin.Controls.Add(this.lblLastName);
            this.grpThongTin.Controls.Add(this.txtFirstName);
            this.grpThongTin.Controls.Add(this.txtLastName);
            this.grpThongTin.Controls.Add(this.btnAdd);

            this.grpThongTin.Location =
                new System.Drawing.Point(267, 20);

            this.grpThongTin.Name = "grpThongTin";

            this.grpThongTin.Size =
                new System.Drawing.Size(330, 155);

            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;

            //
            // lblFirstName
            //
            this.lblFirstName.AutoSize = true;

            this.lblFirstName.Font =
                new System.Drawing.Font(
                    "Times New Roman", 12F);

            this.lblFirstName.Location =
                new System.Drawing.Point(20, 25);

            this.lblFirstName.Name = "lblFirstName";

            this.lblFirstName.Text = "First Name";

            //
            // txtFirstName
            //
            this.txtFirstName.Font =
                new System.Drawing.Font(
                    "Times New Roman", 12F);

            this.txtFirstName.Location =
                new System.Drawing.Point(135, 20);

            this.txtFirstName.Name = "txtFirstName";

            this.txtFirstName.Size =
                new System.Drawing.Size(165, 26);

            this.txtFirstName.TabIndex = 0;

            //
            // lblLastName
            //
            this.lblLastName.AutoSize = true;

            this.lblLastName.Font =
                new System.Drawing.Font(
                    "Times New Roman", 12F);

            this.lblLastName.Location =
                new System.Drawing.Point(20, 75);

            this.lblLastName.Name = "lblLastName";

            this.lblLastName.Text = "Last Name";

            //
            // txtLastName
            //
            this.txtLastName.Font =
                new System.Drawing.Font(
                    "Times New Roman", 12F);

            this.txtLastName.Location =
                new System.Drawing.Point(135, 70);

            this.txtLastName.Name = "txtLastName";

            this.txtLastName.Size =
                new System.Drawing.Size(165, 26);

            this.txtLastName.TabIndex = 1;

            //
            // btnAdd
            //
            this.btnAdd.Font =
                new System.Drawing.Font(
                    "Times New Roman", 12F);

            this.btnAdd.Location =
                new System.Drawing.Point(217, 110);

            this.btnAdd.Name = "btnAdd";

            this.btnAdd.Size =
                new System.Drawing.Size(83, 32);

            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;

            //
            // btnExit
            //
            this.btnExit.Font =
                new System.Drawing.Font(
                    "Times New Roman", 12F);

            this.btnExit.Location =
                new System.Drawing.Point(517, 195);

            this.btnExit.Name = "btnExit";

            this.btnExit.Size =
                new System.Drawing.Size(80, 33);

            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;

            //
            // imageList1
            //
            this.imageList1.ColorDepth =
                System.Windows.Forms.ColorDepth.Depth32Bit;

            this.imageList1.ImageSize =
                new System.Drawing.Size(16, 16);

            this.imageList1.TransparentColor =
                System.Drawing.Color.Transparent;

            //
            // Form1
            //
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(615, 425);

            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnExit);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Name = "Form1";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "frmBTVN2";

            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox grpThongTin;

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.ImageList imageList1;
    }
}
