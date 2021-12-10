using System.Collections.Generic;
using System.Linq;
using QuanLyCuaHangDienThoai.Entities;
using QuanLyCuaHangDienThoai.BusinessLogicLayer.ServiceInterface;
using QuanLyCuaHangDienThoai.DataAccessLayer;
using QuanLyCuaHangDienThoai.DataAccessLayer.ServiceInterface;
namespace QuanLyCuaHangDienThoai.BusinessLogicLayer
{
    class HoaDonBLL : IHoaDonBLL
    {
        IHoaDonDAL hoaDonDAL = new HoaDonDAL();
        public List<HoaDon> GetAllHoaDon()
        {
            return hoaDonDAL.GetAllHoaDon();
        }

        public HoaDon hoaDon(string mahd)
        {
            HoaDon kq = new HoaDon();
            foreach (HoaDon hoaDon in GetAllHoaDon())
            {
                if (hoaDon.Mahoadon.Equals(mahd)) kq = hoaDon;
            }
            return kq;
        }

        public void ThemHoaDon(HoaDon hoaDon)
        {
            hoaDonDAL.Insert(hoaDon);
        }

        public List<HoaDon> TimKiem(string tukhoa)
        {
            return hoaDonDAL.GetAllHoaDon().Where(
                x => x.Mahoadon.Contains(tukhoa) ||
                x.Ngay.Contains(tukhoa)).ToList();
        }
    }
}
