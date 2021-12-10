using System.Collections.Generic;
using QuanLyCuaHangDienThoai.Entities;

namespace QuanLyCuaHangDienThoai.DataAccessLayer.ServiceInterface
{
    public interface INhanVienDAL
    {
        List<NhanVien> GetAllNhanVien();
        void Insert(NhanVien nhanVien);
        void Delete(int vitri);
        void Update(int vitri, NhanVien nhanVien);
    }
}