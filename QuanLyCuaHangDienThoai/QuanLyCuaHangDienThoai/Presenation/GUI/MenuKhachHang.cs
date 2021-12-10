using System;
using QuanLyCuaHangDienThoai.Presenation.Frm;
using QuanLyCuaHangDienThoai.Utility;

namespace QuanLyCuaHangDienThoai.Presenation.GUI
{
    public class MenuKhachHang
    {
         private void Menu()
        {
            Console.WriteLine("                            ╔═══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                            ║                        QUẢN LÝ KHÁCH HÀNG                     ║");
            Console.WriteLine("                            ║═══════════════════════════════════════════════════════════════║");
            Console.WriteLine("                            ║                        1. THÊM KHÁCH HÀNG                     ║");
            Console.WriteLine("                            ║                        2. XÓA KHÁCH HÀNG                      ║");
            Console.WriteLine("                            ║                        3. SỬA THÔNG TIN KHÁCH HÀNG            ║");
            Console.WriteLine("                            ║                        4. TÌM KIẾM KHÁCH HÀNG                 ║");
            Console.WriteLine("                            ║                        5. HIỆN THÔNG TIN KHÁCH HÀNG           ║");
            Console.WriteLine("                            ║                        0. THOÁT                               ║");
            Console.WriteLine("                            ╚═══════════════════════════════════════════════════════════════╝");
        }
        public void Run()
        {
            FrmKhachHang frmKhachHang = new FrmKhachHang();
            while (true)
            {
                Menu();
                Console.Write("Mời chọn: ");
                int chon = int.Parse(Tools.nhapString());
                Console.Clear();;
                switch (chon)
                {
                    case 1:
                        frmKhachHang.themKhachHang();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        frmKhachHang.xoaKhachHang();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        frmKhachHang.suaKhachHang();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        frmKhachHang.timKiem();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        frmKhachHang.hienDanhSachKhachHang();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default: break;
                }
                if (chon == 0) break;
            }
        }
    }
}