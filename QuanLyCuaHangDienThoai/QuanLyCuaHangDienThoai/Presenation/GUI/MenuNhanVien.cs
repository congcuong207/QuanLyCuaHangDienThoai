using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangDienThoai.Presenation.Frm;
using QuanLyCuaHangDienThoai.Utility;

namespace QuanLyCuaHangDienThoai.Presenation.GUI
{
    class MenuNhanVien
    {
        private void Menu()
        {
            Console.WriteLine("                            ╔═══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                            ║                        QUẢN LÝ NHÂN VIÊN                      ║");
            Console.WriteLine("                            ║═══════════════════════════════════════════════════════════════║");
            Console.WriteLine("                            ║                        1. THÊM NHÂN VIÊN                      ║");
            Console.WriteLine("                            ║                        2. XÓA NHÂN VIÊN                       ║");
            Console.WriteLine("                            ║                        3. SỬA THÔNG TIN NHÂN VIÊN             ║");
            Console.WriteLine("                            ║                        4. TÌM KIẾM NHÂN VIÊN                  ║");
            Console.WriteLine("                            ║                        5. HIỆN THÔNG TIN NHÂN VIÊN            ║");
            Console.WriteLine("                            ║                        0. THOÁT                               ║");
            Console.WriteLine("                            ╚═══════════════════════════════════════════════════════════════╝");
        }
        public void Run()
        {
            FrmNhanVien frmNhanVien = new FrmNhanVien();
            while (true)
            {
                Menu();
                Console.Write("Mời chọn: ");
                int chon = int.Parse(Tools.nhapString());
                Console.Clear();;
                switch (chon)
                {
                    case 1:
                        frmNhanVien.themNhanVien();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        frmNhanVien.xoaNhanVien();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        frmNhanVien.suaNhanVien();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        frmNhanVien.timKiem();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        frmNhanVien.hienDanhSachNhanVien();
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
