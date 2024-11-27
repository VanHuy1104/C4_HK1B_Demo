using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinhCaNhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnPhepTinh_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSoA.Text);
            double b = double.Parse(txtSoB.Text);
            double ketQua = 0;
            string phepTinh = ((Button)sender).Name;
            switch(phepTinh)
            {
                case "btnCong":
                    ketQua = a + b; 
                    break;
                case "btnTru":
                    ketQua = a - b;
                    break;
                case "btnNhan":
                    ketQua = a * b;
                    break;
                case "btnChia":
                    if(b == 0)
                    {
                        MessageBox.Show("Mẫu Số Khác Không");
                        return;
                    }
                    ketQua = a / b; break;
            }
            txtKetQua.Text = ketQua.ToString();

        }

       
    }
}
