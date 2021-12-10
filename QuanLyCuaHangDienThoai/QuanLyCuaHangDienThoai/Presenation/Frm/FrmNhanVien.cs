using QuanLyCuaHangDienThoai.Entities;
using QuanLyCuaHangDienThoai.BusinessLogicLayer;
using QuanLyCuaHangDienThoai.BusinessLogicLayer.ServiceInterface;
using QuanLyCuaHangDienThoai.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoai.Presenation.Frm
{
    class FrmNhanVien
    {
        INhanVienBLL nhanVienBLL = new NhanVienBLL();

        public void hienNhanVien(NhanVien nhanVien, int index)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", index, nhanVien.Manv, nhanVien.Hoten, nhanVien.Ngaysinh, nhanVien.Diachi, nhanVien.Sdt, nhanVien.Luong);
        }
        public void hienDanhSachNhanVien()
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", "STT", "Mã nhân viên", "Họ tên", "Ngày sinh", "Địa chỉ", "SĐT", "Lương");
            int index = 0;
            foreach (NhanVien nhanVien in nhanVienBLL.GetAllNhanVien())
            {
                hienNhanVien(nhanVien, index);
                index++;
            }
        }

        public NhanVien nhapNhanVien()
        {
            NhanVien nhanVien = new NhanVien();
            Console.Write("Nhập mã nhân viên: ");
            nhanVien.Manv = Tools.nhapString();
            while (checkUnique(nhanVien.Manv))
            {
                Console.Write("Mã nhân viên đã tồn tại: ");
                nhanVien.Manv = Tools.nhapString();
            }
         
            Console.Write("Nhập họ tên: ");
            nhanVien.Hoten = Tools.nhapString();
            Console.Write("Nhập ngày sinh: ");
            nhanVien.Ngaysinh = Tools.nhapNgaySinhNhanVien();
            Console.Write("Nhập địa chỉ: ");
            nhanVien.Diachi = Tools.nhapString();
            Console.Write("Nhập số điện thoại: ");
            nhanVien.Sdt = Tools.nhapString();
            while (true)
            {
                if (Tools.IsPhoneNumber(nhanVien.Sdt)) break;
                Console.Write("SĐT không hợp lệ: ");
                nhanVien.Sdt = Tools.nhapString();
            }

            Console.Write("Nhập lương: ");
            nhanVien.Luong = int.Parse(Tools.nhapString());
          
          
            return nhanVien;
        }

        public void themNhanVien()
        {
            while (true)
            {
                NhanVien nhanVien = nhapNhanVien();
                nhanVienBLL.ThemNhanVien(nhanVien);
                Console.WriteLine("Bạn muốn nhập tiếp không?C/K");
                string check = Tools.nhapString();
                if (check.Equals("K") || check.Equals("k")) break;
            }
        }
        public void xoaNhanVien()
        {
            hienDanhSachNhanVien();
            Console.Write("Chọn nhân viên: ");
            int chon = int.Parse(Tools.nhapString());
            if (chon > -1 && chon < nhanVienBLL.GetAllNhanVien().Count())
            {
                nhanVienBLL.XoaNhanVien(chon);
                Console.WriteLine("Xóa nhân viên thành công");
            }
            else
            {
                Console.WriteLine("Nhân viên không tồn tại");
            }
        }
        public void suaNhanVien()
        {
            hienDanhSachNhanVien();
            Console.Write("Chọn nhân viên: ");
            int chon = int.Parse(Tools.nhapString());
            if (chon > -1 && chon < nhanVienBLL.GetAllNhanVien().Count())
            {
                NhanVien nhanVien = nhanVienBLL.GetAllNhanVien()[chon];
                Console.Write("Nhập họ tên: ");
                nhanVien.Hoten = Tools.nhapString();
             

                Console.Write("Nhập ngày sinh: ");
                nhanVien.Ngaysinh = Tools.nhapString();
             

                Console.Write("Nhập địa chỉ: ");
                nhanVien.Diachi = Tools.nhapString();
              

                Console.Write("Nhập số điện thoại(ấn enter để qua): ");
                nhanVien.Sdt = Tools.nhapString();
               
                Console.Write("Nhập lương: ");
                nhanVien.Luong = int.Parse(Tools.nhapString());
               
               
                nhanVienBLL.CapNhatNhanVien(chon, nhanVien);
                Console.WriteLine("Cập nhật nhân viên thành công");
            }
            else
            {
                Console.WriteLine("Nhân viên không tồn tại");
            }
        }
   
        public void timKiem()
        {
            Console.Write("Nhập từ khóa: ");
            string tukhoa = Tools.nhapString();
            List<NhanVien> nhanViens = nhanVienBLL.TimKiem(tukhoa);
            if (nhanViens.Count == 0)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", "STT", "Mã nhân viên", "Họ tên", "Ngày sinh", "Địa chỉ", "SĐT", "Lương");
                int index = 0;
                foreach (NhanVien nhanVien in nhanViens)
                {
                    hienNhanVien(nhanVien, index);
                    index++;
                }
            }

        }


        private bool checkUnique(string manv)
        {
            bool result = false;
            foreach (NhanVien nhanVien in nhanVienBLL.GetAllNhanVien())
            {
                if (manv.Equals(nhanVien.Manv)) result = true;
            }
            return result;
        }
    }
}
