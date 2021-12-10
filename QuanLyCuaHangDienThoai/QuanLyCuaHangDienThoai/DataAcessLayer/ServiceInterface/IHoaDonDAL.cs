using System.Collections.Generic;
using QuanLyCuaHangDienThoai.Entities;

namespace QuanLyCuaHangDienThoai.DataAccessLayer.ServiceInterface
{
    public interface IHoaDonDAL
    {
        List<HoaDon> GetAllHoaDon();
        List<ChiTietHoaDon> GetAllChiTietHoaDon(string mahd);
        void Insert(HoaDon hoaDon);

    }
}