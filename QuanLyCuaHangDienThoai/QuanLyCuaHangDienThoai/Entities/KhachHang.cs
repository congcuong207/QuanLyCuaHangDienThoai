using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoai.Entities
{
    public class KhachHang
    {
        private string makhachhang, tenkh, sdt;
        private int solanden;
        public KhachHang()
        {
            tenkh = "";
        }
        public string Makhachhang { get => makhachhang; set => makhachhang = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int Solanden { get => solanden; set => solanden = value; }
        override
            public string ToString()
        {
            return makhachhang + "#" + tenkh + "#" + sdt + "#" + solanden;
        }
    }
}
