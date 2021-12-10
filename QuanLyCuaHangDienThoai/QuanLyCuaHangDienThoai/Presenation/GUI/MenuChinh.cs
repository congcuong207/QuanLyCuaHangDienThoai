using QuanLyCuaHangDienThoai.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoai.Presenation.GUI
{
     class MenuChinh
    {

        private void Menu()
        {
            Console.WriteLine("                            ╔═══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                            ║                     QUẢN LÝ CỬA HÀNG ĐIỆN THOẠI               ║");
            Console.WriteLine("                            ║═══════════════════════════════════════════════════════════════║");
            Console.WriteLine("                            ║                        1. QUẢN LÝ HÓA ĐƠN                     ║");
            Console.WriteLine("                            ║                        2. QUẢN LÝ ĐIỆN THOẠI                  ║");
            Console.WriteLine("                            ║                        3. QUẢN LÝ KHÁCH HÀNG                  ║");
            Console.WriteLine("                            ║                        4. QUẢN LÝ NHÂN VIÊN                   ║");
            Console.WriteLine("                            ║                        0. THOÁT                               ║");
            Console.WriteLine("                            ╚═══════════════════════════════════════════════════════════════╝");
        }
        public void Run()
        {
            while (true)
            {
                Menu();
                Console.Write("Mời chọn: ");
                int chon = int.Parse(Tools.nhapString());
                Console.Clear(); ;
                switch (chon)
                {
                    case 1:
                        new MenuHoaDon().Run();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        new MenuDienThoai().Run();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                   
                    case 3:
                        new MenuKhachHang().Run();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        new MenuNhanVien().Run();
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
