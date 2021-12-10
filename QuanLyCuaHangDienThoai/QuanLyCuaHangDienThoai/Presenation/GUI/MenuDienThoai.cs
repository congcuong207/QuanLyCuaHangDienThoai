using System;
using QuanLyCuaHangDienThoai.Presenation.Frm;
using QuanLyCuaHangDienThoai.Utility;

namespace QuanLyCuaHangDienThoai.Presenation.GUI
{
    public class MenuDienThoai
    {
        private void Menu()
        {
            Console.WriteLine("                            ╔═══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                            ║                        QUẢN LÝ ĐIỆN THOẠI                     ║");
            Console.WriteLine("                            ║═══════════════════════════════════════════════════════════════║");
            Console.WriteLine("                            ║                        1. THÊM ĐIỆN THOẠI                     ║");
            Console.WriteLine("                            ║                        2. XÓA ĐIỆN THOẠI                      ║");
            Console.WriteLine("                            ║                        3. SỬA THÔNG TIN ĐIỆN THOẠI            ║");
            Console.WriteLine("                            ║                        4. TÌM KIẾM ĐIỆN THOẠI                 ║");
            Console.WriteLine("                            ║                        5. HIỆN THÔNG TIN ĐIỆN THOẠI           ║");
            Console.WriteLine("                            ║                        0. THOÁT                               ║");
            Console.WriteLine("                            ╚═══════════════════════════════════════════════════════════════╝");
        }
        public void Run()
        {
            FrmDienThoai frmMenu = new FrmDienThoai();
            while (true)
            {
                Menu();
                Console.Write("Mời chọn: ");
                int chon = int.Parse(Tools.nhapString());
                Console.Clear(); ;
                switch (chon)
                {
                    case 1:
                        frmMenu.ThemDienThoai();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        frmMenu.XoaDienThoai();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        frmMenu.SuaDienThoai();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        frmMenu.TimKiem();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        frmMenu.HienDSDienThoai();
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