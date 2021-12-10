using QuanLyCuaHangDienThoai.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoai.BusinessLogicLayer.ServiceInterface
{
    internal interface IDienThoaiBLL
    {
        void ThemDienThoai(DienThoai DienThoai);
        void SuaDienThoai(int index,DienThoai DienThoai);
        void XoaDienThoai(int index);
        List<DienThoai> TimKiem(string tukhoa); 
        DienThoai DienThoai(string maDienThoai);
        List<DienThoai> GetAllDienThoai();
    }
}
