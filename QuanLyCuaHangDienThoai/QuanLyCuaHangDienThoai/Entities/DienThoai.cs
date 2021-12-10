using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoai.Entities
{
    public class DienThoai
    {
        private string id, ten, loai;
        private int gia, soluong;
        public DienThoai()
        {

        }
        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Loai { get => loai; set => loai = value; }
        public int Gia { get => gia; set => gia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        override
            public string ToString()
        {
            return id + "#" + ten + "#" + loai + "#" + gia + "#" + soluong;
        }
    }
}
