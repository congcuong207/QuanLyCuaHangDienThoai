using System.Collections.Generic;
using QuanLyCuaHangDienThoai.Entities;

namespace QuanLyCuaHangDienThoai.BusinessLogicLayer.ServiceInterface
{
    public interface IChiTietHoaDonBLL
    {

        void themChiTietHoadon(ChiTietHoaDon chiTietHoaDon);
        List<ChiTietHoaDon> GetAllChiTietHoaDon(string maHoaDon);
        ChiTietHoaDon chiTietHoaDon(string macthd);
    }
}