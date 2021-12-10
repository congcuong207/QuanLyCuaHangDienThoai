using QuanLyCuaHangDienThoai.Entities;
using QuanLyCuaHangDienThoai.BusinessLogicLayer.ServiceInterface;
using QuanLyCuaHangDienThoai.DataAccessLayer.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoai.BusinessLogicLayer
{
    class ChiTietHoaDonBLL : IChiTietHoaDonBLL
    {
        IChiTietHoaDonDAL chiTietHoaDonDAL = new ChiTietHoaDonDAL();

        public ChiTietHoaDon chiTietHoaDon(string macthd)
        {
            ChiTietHoaDon kq = new ChiTietHoaDon();
            foreach(ChiTietHoaDon chiTietHoaDon in chiTietHoaDonDAL.GetAllChiTietHoaDon())
            {
                if (chiTietHoaDon.Macthd.Equals(macthd)) kq = chiTietHoaDon;
            }
            return kq;
        }

        public List<ChiTietHoaDon> GetAllChiTietHoaDon(string maHoaDon)
        {
            List<ChiTietHoaDon> chiTietHoaDons = chiTietHoaDonDAL.GetAllChiTietHoaDon();
            return chiTietHoaDons.Where(x => x.Mahoadon.Equals(maHoaDon)).ToList();
        }

        public void themChiTietHoadon(ChiTietHoaDon chiTietHoaDon)
        {
            chiTietHoaDonDAL.Insert(chiTietHoaDon);
        }
    }
}
