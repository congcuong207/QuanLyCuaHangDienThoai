using System.Collections.Generic;
using System.Linq;
using QuanLyCuaHangDienThoai.Entities;
using QuanLyCuaHangDienThoai.BusinessLogicLayer.ServiceInterface;
using QuanLyCuaHangDienThoai.DataAccessLayer;
using QuanLyCuaHangDienThoai.DataAccessLayer.ServiceInterface;
namespace QuanLyCuaHangDienThoai.BusinessLogicLayer
{
    class NhanVienBLL : INhanVienBLL
    {
        INhanVienDAL nhanVienDAL = new NhanVienDAL();
        public void CapNhatNhanVien(int index, NhanVien nhanVien)
        {
            nhanVienDAL.Update(index, nhanVien);
        }

        public List<NhanVien> GetAllNhanVien()
        {
            return nhanVienDAL.GetAllNhanVien();
        }

        public NhanVien nhanVien(string manv)
        {
            NhanVien nv = new NhanVien();
            foreach (NhanVien nhanVien in GetAllNhanVien())
            {
                if (nhanVien.Manv.Equals(manv)) nv = nhanVien;
            }
            return nv;
        }

        public void ThemNhanVien(NhanVien nhanVien)
        {
            nhanVienDAL.Insert(nhanVien);
        }

        public List<NhanVien> TimKiem(string tukhoa)
        {
            List<NhanVien> nhanViens = GetAllNhanVien();
            return nhanViens.Where(
                x => x.Manv.Contains(tukhoa) ||
                x.Hoten.Contains(tukhoa) ||
                x.Diachi.Contains(tukhoa)).ToList();
        }

        public void XoaNhanVien(int index)
        {
            nhanVienDAL.Delete(index);
        }
    }
}
