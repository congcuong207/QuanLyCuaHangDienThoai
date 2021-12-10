using QuanLyCuaHangDienThoai.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoai.BusinessLogicLayer.ServiceInterface
{
    interface IKhachHangBLL
    {
        void ThemKhachHang(KhachHang KhachHang);
        void XoaKhachHang(int index);
        void CapNhatThanhVien(int index,KhachHang KhachHang);
        List<KhachHang> GetAllKhachHang();
        List<KhachHang> TimKiem(string tukhoa);
        KhachHang _KhachHang(string mathe);
    }
}
