using System.Collections.Generic;
using System.Linq;
using QuanLyCuaHangDienThoai.Entities;
using QuanLyCuaHangDienThoai.BusinessLogicLayer.ServiceInterface;
using QuanLyCuaHangDienThoai.DataAccessLayer;
using QuanLyCuaHangDienThoai.DataAccessLayer.ServiceInterface;

namespace QuanLyCuaHangDienThoai.BusinessLogicLayer
{
    class KhachHangBLL : IKhachHangBLL
    {
        IKhachHangDAL KhachHangDAL = new KhachHangDAL();
        public void CapNhatThanhVien(int index, KhachHang KhachHang)
        {
            KhachHangDAL.Update(index, KhachHang);
        }

        public List<KhachHang> GetAllKhachHang()
        {
            return KhachHangDAL.GetAllKhachHang();
        }

        public void ThemKhachHang(KhachHang KhachHang)
        {
            KhachHangDAL.Insert(KhachHang);
        }

        public List<KhachHang> TimKiem(string tukhoa)
        {
            List<KhachHang> KhachHangs = new List<KhachHang>();
            return KhachHangs.Where(
                x => x.Makhachhang.Contains(tukhoa) ||
                x.Tenkh.Contains(tukhoa) ||
                x.Sdt.Contains(tukhoa)).ToList();
        }

        public KhachHang _KhachHang(string mathe)
        {
            KhachHang kq = new KhachHang();
            foreach (KhachHang  KhachHang in GetAllKhachHang())
            {
                if (KhachHang.Makhachhang.Equals(mathe)) kq = KhachHang;
            }
            return kq;
        }

        public void XoaKhachHang(int index)
        {
            KhachHangDAL.Delete(index);
        }
    }
}
