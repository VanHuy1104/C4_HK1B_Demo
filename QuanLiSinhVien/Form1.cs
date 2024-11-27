using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiSinhVien.ettin;


namespace QuanLiSinhVien
{
    public partial class FrmQuanLySinhVien : Form
    {
        List<Khoa> danhsachKhoa = new List<Khoa>();
        public FrmQuanLySinhVien()
        {
            InitializeComponent();

            cmbKhoaVien.DisplayMember = "tenKhoa";
            cmbKhoaVien.ValueMember = "maKhoa";
        }

        private void Load_Khoa(object sender, EventArgs e)
        {

            danhsachKhoa.Add(new Khoa("CNTT", "Công nghệ thông tin"));
            danhsachKhoa.Add(new Khoa("KT", "Kinh Tế"));
            danhsachKhoa.Add(new Khoa("NN", "Ngoại Ngữ"));
             cmbKhoaVien.DataSource = danhsachKhoa;
        }
    }
}
