
using QuanLyCuaHangDienThoai.Entities;
using System.Collections.Generic;


namespace QuanLyCuaHangDienThoai.DataAccessLayer.ServiceInterface
{
    public interface IKhachHangDAL
    {
        List<KhachHang> GetAllKhachHang();
        void Insert(KhachHang KhachHang);
        void Delete(int vitri);
        void Update(int vitri, KhachHang KhachHang);
    }
}