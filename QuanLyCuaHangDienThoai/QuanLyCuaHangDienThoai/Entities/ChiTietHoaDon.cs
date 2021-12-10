using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoai.Entities
{
    public class ChiTietHoaDon
    {
        private string maDienThoai;
        private int soluong;
        private string macthd;
        private string mahoadon;
        public ChiTietHoaDon()
        {

        }
        public string Macthd { get => macthd; set => macthd = value; }
        public string Mahoadon { get => mahoadon; set => mahoadon = value; }
        public string MaDienThoai { get => maDienThoai; set => maDienThoai = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        override
        public string ToString()
        {
            return macthd + "#" + mahoadon + "#" + maDienThoai + "#" + soluong;
        }
    }
}
