using System;
using System.Collections.Generic;
using QuanLyCuaHangDienThoai.Entities;
using QuanLyCuaHangDienThoai.BusinessLogicLayer;
using QuanLyCuaHangDienThoai.BusinessLogicLayer.ServiceInterface;
using QuanLyCuaHangDienThoai.DataAccessLayer;
using QuanLyCuaHangDienThoai.DataAccessLayer.ServiceInterface;
using QuanLyCuaHangDienThoai.Utility;

namespace QuanLyCuaHangDienThoai.Presenation.Frm
{
    class FrmDienThoai
    {
        public List<DienThoai> DienThoaiList;
        private IDienThoaiBLL DienThoaiBLL;
        Random random;
        public FrmDienThoai()
        {
            DienThoaiBLL = new DienThoaiBLL();
            DienThoaiList = DienThoaiBLL.GetAllDienThoai();
            random = new Random();
        }
        private DienThoai NhapDienThoai()
        {
            DienThoai DienThoai = new DienThoai();
            DienThoai.Id = "MN" + random.Next();
            Console.WriteLine("Nhập tên điện thoại: ");
            DienThoai.Ten = Tools.nhapString();
            Console.WriteLine("Nhập loại điện thoại: ");
            DienThoai.Loai = Tools.nhapString();
            Console.WriteLine("Nhập giá: ");
            DienThoai.Gia = int.Parse(Tools.nhapString());
            Console.WriteLine("Nhập số lượng: ");
            DienThoai.Soluong = int.Parse(Tools.nhapString());
            return DienThoai;

        }
        private void HienDienThoaiAn(DienThoai DienThoai, int index)
        {
            Console.WriteLine("|{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", index, DienThoai.Id, DienThoai.Ten, DienThoai.Loai, DienThoai.Gia, DienThoai.Soluong);
        }
        public void HienDSDienThoai()
        {
            Console.WriteLine("|{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "STT", "Mã điện thoại", "Tên điện thoại", "Loại điện thoại", "Giá bán", "Số lượng");
            int dem = 0;
            foreach (DienThoai DienThoai in DienThoaiList)
            {
                HienDienThoaiAn(DienThoai, dem);
                dem++;
            }
        }

        public DienThoai DienThoai(string maDienThoai)
        {
            DienThoai kq = new DienThoai();
            foreach(DienThoai DienThoai in DienThoaiList)
            {
                kq = DienThoai;
            }
            return kq;
        }

        public void SuaDienThoai()
        {
            HienDSDienThoai();
            Console.WriteLine("Chọn điện thoại cần sửa: ");
            int chon = int.Parse(Tools.nhapString());
            if (chon > -1 && chon < DienThoaiList.Count)
            {
                DienThoai DienThoai = DienThoaiList[chon];
                Console.WriteLine("Nhập tên điện thoại: ");
                DienThoai.Ten = Tools.nhapString();
                Console.WriteLine("Nhập loại điện thoại: ");
                DienThoai.Loai = Tools.nhapString();
                Console.WriteLine("Nhập giá: ");
                DienThoai.Gia = int.Parse(Tools.nhapString());
                Console.WriteLine("Nhập số lượng: ");
                DienThoai.Soluong = int.Parse(Tools.nhapString());
                DienThoaiBLL.SuaDienThoai(chon, DienThoai);
                DienThoaiList = DienThoaiBLL.GetAllDienThoai();
            }
        }
        public void ThemDienThoai()
        {
            while (true)
            {
                DienThoai DienThoai = NhapDienThoai();
                DienThoaiBLL.ThemDienThoai(DienThoai);
                DienThoaiList = DienThoaiBLL.GetAllDienThoai();
                Console.WriteLine("Bạn muốn nhập tiếp không?C/K");
                string chon = Tools.nhapString();
                if (chon.Equals("K") || chon.Equals("k")) break;
            }
        }
        public void TimKiem()
        {
            Console.WriteLine("Nhập từ khóa cần tìm: ");
            string tukhoa = Tools.nhapString();
            Console.WriteLine("|{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "STT", "Mã điện thoại", "Tên điện thoại", "Loại điện thoại", "Giá bán", "Số lượng");
            int dem = 0;
            foreach (DienThoai DienThoai in DienThoaiList)
            {
                if (DienThoai.Id.Contains(tukhoa) ||
                    DienThoai.Ten.Contains(tukhoa) ||
                    DienThoai.Loai.Contains(tukhoa))
                {
                    HienDienThoaiAn(DienThoai, dem);
                    dem++;
                }

            }
        }
        public void XoaDienThoai()
        {
            HienDSDienThoai();
            Console.WriteLine("Chọn điện thoại cần sửa: ");
            int chon = int.Parse(Tools.nhapString());
            if (chon > -1 && chon < DienThoaiList.Count)
            {
                DienThoaiBLL.XoaDienThoai(chon);
                DienThoaiList = DienThoaiBLL.GetAllDienThoai();
            }

        }
    }
}
