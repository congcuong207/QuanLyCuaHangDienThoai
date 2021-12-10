using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoai.Entities
{
    public class HoaDon
    {
        private string mahoadon, ngay, makhachhang, manv;

        public HoaDon()
        {

        }
        public string Mahoadon { get => mahoadon; set => mahoadon = value; }
        public string Ngay { get => ngay; set => ngay = value; }

        public string Makhachhang { get => makhachhang; set => makhachhang = value; }
        public string Manv { get => manv; set => manv = value; }
        override
        public string ToString()
        {
            return mahoadon + "#" + ngay + "#" + makhachhang + "#" + manv;
        }
    }
}
