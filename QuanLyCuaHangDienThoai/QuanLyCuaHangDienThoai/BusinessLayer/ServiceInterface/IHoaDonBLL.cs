using QuanLyCuaHangDienThoai.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoai.BusinessLogicLayer.ServiceInterface
{
    interface IHoaDonBLL
    {
        List<HoaDon> GetAllHoaDon();
        void ThemHoaDon(HoaDon hoaDon);
        List<HoaDon> TimKiem(string tukhoa);
        HoaDon hoaDon(string mahd);
      
    }
}
