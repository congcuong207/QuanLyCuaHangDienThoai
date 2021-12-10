using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyCuaHangDienThoai.BusinessLogicLayer;
using QuanLyCuaHangDienThoai.BusinessLogicLayer.ServiceInterface;
using QuanLyCuaHangDienThoai.Entities;
using QuanLyCuaHangDienThoai.Utility;

namespace QuanLyCuaHangDienThoai.Presenation.Frm
{
    public class FrmKhachHang
    {
        IKhachHangBLL KhachHangBLL = new KhachHangBLL();

        public void hienKhachHang(KhachHang KhachHang, int index)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", index, KhachHang.Makhachhang,
                KhachHang.Tenkh, KhachHang.Sdt, KhachHang.Solanden);
        }
        public void hienDanhSachKhachHang()
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", "STT", "Mã khách hàng", "Họ tên KH", "SĐT",
                "Số lần đến");
            int index = 0;
            foreach (KhachHang KhachHang in KhachHangBLL.GetAllKhachHang())
            {
                hienKhachHang(KhachHang, index);
                index++;
            }
        }

        public KhachHang nhapKhachHang()
        {
            KhachHang KhachHang = new KhachHang();
            Console.Write("Nhập mã Khách hàng: ");
            KhachHang.Makhachhang = Tools.nhapString();
            while (checkUnique(KhachHang.Makhachhang))
            {
                Console.Write("Mã Khách hàng đã tồn tại: ");
                KhachHang.Makhachhang = Tools.nhapString();
            }

            Console.Write("Nhập họ tên: ");
            KhachHang.Tenkh = Tools.nhapString();
            Console.Write("Nhập số điện thoại: ");
            KhachHang.Sdt = Tools.nhapString();
            while (true)
            {
                if (Tools.IsPhoneNumber(KhachHang.Sdt)) break;
                Console.Write("SĐT không hợp lệ: ");
                KhachHang.Sdt = Tools.nhapString();
            }
            KhachHang.Solanden = 0;
            return KhachHang;
        }

        public void themKhachHang()
        {
            while (true)
            {
                KhachHang KhachHang = nhapKhachHang();
                KhachHangBLL.ThemKhachHang(KhachHang);
                Console.WriteLine("Bạn muốn nhập tiếp không?C/K");
                string check = Tools.nhapString();
                if (check.Equals("K") || check.Equals("k")) break;
            }
        }

        public void xoaKhachHang()
        {
            hienDanhSachKhachHang();
            Console.Write("Chọn Khách hàng: ");
            int chon = int.Parse(Tools.nhapString());
            if (chon > -1 && chon < KhachHangBLL.GetAllKhachHang().Count())
            {
                KhachHangBLL.XoaKhachHang(chon);
                Console.WriteLine("Xóa Khách hàng thành công");
            }
            else
            {
                Console.WriteLine("Khách hàng không tồn tại");
            }
        }

        public void suaKhachHang()
        {
            hienDanhSachKhachHang();
            Console.Write("Chọn Khách hàng: ");
            int chon = int.Parse(Tools.nhapString());
            if (chon > -1 && chon < KhachHangBLL.GetAllKhachHang().Count())
            {
                KhachHang KhachHang = KhachHangBLL.GetAllKhachHang()[chon];
                Console.Write("Nhập họ tên: ");
                KhachHang.Tenkh = Tools.nhapString();
                Console.Write("Nhập số điện thoại: ");
                KhachHang.Sdt = Tools.nhapString();
                KhachHangBLL.CapNhatThanhVien(chon,KhachHang);
                Console.WriteLine("Cập nhật Khách hàng thành công");
            }
            else
            {
                Console.WriteLine("Khách hàng không tồn tại");
            }
        }

        public void timKiem()
        {
            Console.Write("Nhập từ khóa: ");
            string tukhoa = Tools.nhapString();
            List<KhachHang> KhachHangs = KhachHangBLL.TimKiem(tukhoa);
            if (KhachHangs.Count == 0)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", "STT", "Mã KH", "Họ tên KH", "SĐT",
                    "Số lần đến");
                int index = 0;
                foreach (KhachHang KhachHang in KhachHangs)
                {
                    hienKhachHang(KhachHang, index);
                    index++;
                }
            }
        }

        public void updateSoLanDen(KhachHang KhachHang,int vitri)
        {
            KhachHang.Solanden = KhachHang.Solanden + 1;
            KhachHangBLL.CapNhatThanhVien(vitri,KhachHang);
        }
        private bool checkUnique(string mathe)
        {
            bool result = false;
            foreach (KhachHang KhachHang in KhachHangBLL.GetAllKhachHang())
            {
                if (mathe.Equals(KhachHang.Makhachhang)) result = true;
            }

            return result;
        }
    }
}