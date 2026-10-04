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
        public Form1()
        {
            InitializeComponent();

            textBox1.KeyPress += TxtSo_KeyPress;
            textBox2.KeyPress += TxtSo_KeyPress;

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
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Vui long nhap so A: ");
                return false;
            }
            errorProvider1.SetError(textBox1, "");  
            return true;
        }
        private bool KiemTraSoB()
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Vui long nhap so B: ");
                return false;
            }
            errorProvider1.SetError(textBox2, "");
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
            if (!int.TryParse(textBox1.Text, out a) || !int.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show(" Vui long nhap dung dinh dang so !", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            KiemTraSoB();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu(out int a, out int b))
            {
                return;
            }
            if (b == 0)
            {
                MessageBox.Show("khong the chia cho 0", "vui long nhap lai!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
        
            double ketqua = (double)a / b;
            textBox3.Text = ketqua.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu(out int a, out int b))
            {
                return;
            }
            int ketqua = a * b;
            textBox3.Text = ketqua.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu(out int a, out int b))
            {
                return;
            }
            int ketqua = a - b;
            textBox3.Text = ketqua.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu(out int a, out int b))
            {
                return;
            }
            int ketqua = a + b;
            textBox3.Text = ketqua.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            KiemTraSoA();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}