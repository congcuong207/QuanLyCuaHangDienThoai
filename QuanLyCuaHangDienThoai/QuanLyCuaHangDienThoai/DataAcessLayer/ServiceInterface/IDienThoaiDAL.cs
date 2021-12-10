using System.Collections.Generic;
using QuanLyCuaHangDienThoai.Entities;

namespace QuanLyCuaHangDienThoai.DataAccessLayer.ServiceInterface
{
    public interface IDienThoaiDAL
    {
        List<DienThoai> GetAllDienThoai();
        void Insert(DienThoai DienThoai);
        void Delete(int vitri);
        void Update(int vitri, DienThoai DienThoai);
    }
}