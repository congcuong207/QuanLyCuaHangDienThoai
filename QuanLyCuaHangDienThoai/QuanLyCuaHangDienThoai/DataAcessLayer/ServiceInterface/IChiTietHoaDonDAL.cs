using System.Collections.Generic;
using QuanLyCuaHangDienThoai.Entities;

namespace QuanLyCuaHangDienThoai.DataAccessLayer.ServiceInterface
{
    public interface IChiTietHoaDonDAL
    {
        List<ChiTietHoaDon> GetAllChiTietHoaDon();
        void Insert(ChiTietHoaDon chiTietHoaDon);
    }
}