using QuanLyCuaHangDienThoai.Entities;
using QuanLyCuaHangDienThoai.BusinessLogicLayer.ServiceInterface;
using QuanLyCuaHangDienThoai.DataAccessLayer;
using QuanLyCuaHangDienThoai.DataAccessLayer.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoai.BusinessLogicLayer
{
    class DienThoaiBLL : IDienThoaiBLL
    {
        IDienThoaiDAL DienThoaiDAL = new DienThoaiDAL();
        public List<DienThoai> GetAllDienThoai()
        {
            return DienThoaiDAL.GetAllDienThoai();
        }

        public DienThoai DienThoai(string maDienThoai)
        {
            DienThoai kq = new DienThoai();
            foreach (DienThoai DienThoai in DienThoaiDAL.GetAllDienThoai())
            {
                if (DienThoai.Id.Equals(maDienThoai)) kq = DienThoai;
            }
            return kq;
        }

        public void SuaDienThoai(int index, DienThoai DienThoai)
        {
            DienThoaiDAL.Update(index, DienThoai);
        }

        public void ThemDienThoai(DienThoai DienThoai)
        {
            DienThoaiDAL.Insert(DienThoai);
        }

        public List<DienThoai> TimKiem(string tukhoa)
        {
            List<DienThoai> DienThoais = new List<DienThoai>();
            return DienThoais.Where(
            x => x.Id.Contains(tukhoa) ||
            x.Ten.Contains(tukhoa) ||
            x.Loai.Contains(tukhoa)
            ).ToList();
        }

        public void XoaDienThoai(int index)
        {
            DienThoaiDAL.Delete(index);
        }
    }
}
