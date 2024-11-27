using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.ettin
{
    internal class Khoa
    {
        public string MaKhoa {  get; set; }
        public string TenKhoa { get; set; }

        public Khoa()
        {

        }
        public Khoa(string maKhoa,string tenkhoa)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenkhoa;
        }
    }
}
