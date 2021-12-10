using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoai.Entities
{
    public class NhanVien
    {
        private string manv, hoten, ngaysinh, diachi, sdt;
        private int luong;
     
      
        public NhanVien()
        {

        }
        public string Manv { get => manv; set => manv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int Luong { get => luong; set => luong = value; }
     
       
        override
            public string ToString()
        {
            return manv + "#" + hoten + "#" + ngaysinh + "#" + diachi + "#" + sdt + "#" + luong  ;
        }
    }
}
