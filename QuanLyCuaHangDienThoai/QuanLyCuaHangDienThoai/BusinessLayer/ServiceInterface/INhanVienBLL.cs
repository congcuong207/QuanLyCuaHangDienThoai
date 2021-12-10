using QuanLyCuaHangDienThoai.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoai.BusinessLogicLayer.ServiceInterface
{
     interface INhanVienBLL
    {
        List<NhanVien> GetAllNhanVien();
        void ThemNhanVien(NhanVien nhanVien);
        void CapNhatNhanVien(int index,NhanVien nhanVien);
        void XoaNhanVien(int index);
        NhanVien nhanVien(string manv);
        List<NhanVien> TimKiem(string tukhoa);
    }
}
