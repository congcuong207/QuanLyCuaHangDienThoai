using QuanLyCuaHangDienThoai.Presenation.Frm;
using QuanLyCuaHangDienThoai.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoai.Presenation.GUI
{
    class MenuHoaDon
    {
        public void Menu()
        {
            Console.WriteLine("                            ╔═══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                            ║                        HÓA ĐƠN                                ║");
            Console.WriteLine("                            ║═══════════════════════════════════════════════════════════════║");
            Console.WriteLine("                            ║                        1. THÊM HÓA ĐƠN                        ║");
            Console.WriteLine("                            ║                        2. XEM THÔNG TIN HÓA ĐƠN               ║");
            Console.WriteLine("                            ║                        3. THỐNG KÊ                            ║");
            Console.WriteLine("                            ║                        0. THOÁT                               ║");
            Console.WriteLine("                            ╚═══════════════════════════════════════════════════════════════╝");
        }
        public void Run()
        {
            FrmHoaDon frmHoaDon = new FrmHoaDon();
            while (true)
            {
                Menu();
                Console.Write("Mời chọn: ");
                int chon = int.Parse(Tools.nhapString());
                Console.Clear(); ;
                switch (chon)
                {
                    case 1:
                        frmHoaDon.ThemHoaDon();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                   
                    case 2:
                        frmHoaDon.HienDSHoaDon();
                        Console.WriteLine("Nhấp phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        frmHoaDon.ThongKeTheoThang();
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
