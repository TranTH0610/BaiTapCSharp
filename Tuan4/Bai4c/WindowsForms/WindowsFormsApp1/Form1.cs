using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtketqua;

        public Form1()
        {
            InitializeComponent();
            if (errorProvider1 == null)
            {
                errorProvider1 = new System.Windows.Forms.ErrorProvider();
                errorProvider1.ContainerControl = this;
            }
            if (txtA == null)
            {
                txtA = new System.Windows.Forms.TextBox();
                txtA.Name = "txtA";
                this.Controls.Add(txtA);
            }
            if (txtB == null)
            {
                txtB = new System.Windows.Forms.TextBox();
                txtB.Name = "txtB";
                this.Controls.Add(txtB);
            }
            if (txtketqua == null)
            {
                txtketqua = new System.Windows.Forms.TextBox();
                txtketqua.Name = "txtketqua";
                this.Controls.Add(txtketqua);
            }

            txtA.KeyPress += TxtSo_KeyPress;
            txtB.KeyPress += TxtSo_KeyPress;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TxtSo_KeyPress(object? sender , KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool KiemTraSoA()
        {
            if (string.IsNullOrWhiteSpace(txtA.Text))
            {
                errorProvider1.SetError(txtA,"Vui long nhap so A: ");
                return false;
            }
            errorProvider1.SetError(txtA, "");
            return true;
        }
        private bool KiemTraSoB()
        {
            if (string.IsNullOrWhiteSpace(txtB.Text))
            {
                errorProvider1.SetError(txtB,"Vui long nhap so B: ");
                return false;
            }
            errorProvider1.SetError(txtB, "");
            return true;
        }
        private bool KiemTraDuLieu( out int a, out int b)
        {
            a = 0;
            b = 0;
            bool HopLeA = KiemTraSoA();
            bool HopLeB = KiemTraSoB();
            if (!HopLeA || !HopLeB)
            {
                MessageBox.Show(" Vui long nhap day du so !", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtA.Text, out a) || !int.TryParse(txtB.Text, out b))
            {
                MessageBox.Show(" Vui long nhap dung dinh dang so !", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void BtnCong_Click(object sender, EventArgs e)
        {
            if(!KiemTraDuLieu(out int a, out int b))
            {
                return;
            }
            int ketqua = a + b;
            txtketqua.Text = ketqua.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
