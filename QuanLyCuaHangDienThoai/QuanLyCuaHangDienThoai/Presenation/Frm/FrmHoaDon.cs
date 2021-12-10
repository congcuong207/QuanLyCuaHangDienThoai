using System;
using QuanLyCuaHangDienThoai.BusinessLogicLayer;
using QuanLyCuaHangDienThoai.BusinessLogicLayer.ServiceInterface;
using QuanLyCuaHangDienThoai.Entities;
using System.Linq;
using System.Collections.Generic;
using QuanLyCuaHangDienThoai.Utility;

namespace QuanLyCuaHangDienThoai.Presenation.Frm
{
    public class FrmHoaDon
    {
        private IHoaDonBLL _hoaDonBll = new HoaDonBLL();
        private Random _random = new Random();

        public void ThemHoaDon()
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.Mahoadon = "HD" + _random.Next();
            Console.Write("Nhập ngày: ");
            hoaDon.Ngay = Tools.nhapString();
            
            FrmKhachHang frmKhachHang = new FrmKhachHang();
            frmKhachHang.hienDanhSachKhachHang();
            Console.WriteLine("Chọn khách hàng: ");
            int chonTV = int.Parse(Tools.nhapString());
            IKhachHangBLL thanhVienBll = new KhachHangBLL();
            if (chonTV > -1 && chonTV < thanhVienBll.GetAllKhachHang().Count)
            {
                KhachHang KhachHang = thanhVienBll.GetAllKhachHang()[chonTV];
                hoaDon.Makhachhang = KhachHang.Makhachhang;
                frmKhachHang.updateSoLanDen(KhachHang, chonTV);
            }

            FrmNhanVien frmNhanVien = new FrmNhanVien();
            frmNhanVien.hienDanhSachNhanVien();
            Console.WriteLine("Chọn nhân viên bán: ");
            int chonNV = int.Parse(Tools.nhapString());
            INhanVienBLL nhanVienBll = new NhanVienBLL();
            while (true)
            {
                if (chonNV > -1 && chonNV < nhanVienBll.GetAllNhanVien().Count) break;
                Console.WriteLine("Nhân viên không tồn tại");
                chonNV = int.Parse(Tools.nhapString());
            }
            NhanVien nhanVien = nhanVienBll.GetAllNhanVien()[chonNV];
            hoaDon.Manv = nhanVien.Manv;
          
            _hoaDonBll.ThemHoaDon(hoaDon);
            FrmChiTietHoaDon frmChiTietHoaDon = new FrmChiTietHoaDon();
            frmChiTietHoaDon.themChiTietHoadon(hoaDon.Mahoadon);
            Console.WriteLine("Thêm hóa đơn thành công");
            ThanhToan(hoaDon.Mahoadon);
        }

        public void HienHoaDon(HoaDon hoaDon, int stt)
        {
            IKhachHangBLL thanhVienBll = new KhachHangBLL();
            KhachHang KhachHang = thanhVienBll._KhachHang(hoaDon.Makhachhang);
            INhanVienBLL nhanVienBll = new NhanVienBLL();
            NhanVien nhanVien = nhanVienBll.nhanVien(hoaDon.Manv);

            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", stt, hoaDon.Mahoadon, hoaDon.Ngay,  KhachHang.Tenkh, nhanVien.Hoten);



        }

        public void HienDSHoaDon()
        {
            int stt = 0;
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", "STT", "Mã hóa đơn", "Ngày",  "Tên khách hàng", "Tên nhân viên bán hàng");
            foreach (HoaDon hoaDon in _hoaDonBll.GetAllHoaDon())
            {
                HienHoaDon(hoaDon, stt);
                stt++;
            }
            Console.Write("Chọn hóa đơn muốn xem: ");
            int chon = int.Parse(Tools.nhapString());
            if (chon > -1 && chon < _hoaDonBll.GetAllHoaDon().Count)
            {
                HoaDon hoaDon = _hoaDonBll.GetAllHoaDon()[chon];
                FrmChiTietHoaDon frmChiTietHoaDon = new FrmChiTietHoaDon();
                frmChiTietHoaDon.hienDSCTHoaDon(hoaDon.Mahoadon);
            }
        }
   
   
       
  
        public void ThanhToan(string mahd)
        {
          
          
            HoaDon hoaDon = _hoaDonBll.hoaDon(mahd);
            INhanVienBLL nhanVienBLL = new NhanVienBLL();
            NhanVien nhanVien = nhanVienBLL.nhanVien(hoaDon.Manv);
            IKhachHangBLL KhachHangBLL = new KhachHangBLL();
            KhachHang KhachHang = KhachHangBLL._KhachHang(hoaDon.Makhachhang);
            FrmChiTietHoaDon frmChiTietHoaDon = new FrmChiTietHoaDon();
            frmChiTietHoaDon.hienDSCTHoaDon(hoaDon.Mahoadon);
            Console.WriteLine("Ấn phím bất kì đển hiện hóa đơn");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                            ╔═══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                            ║                        THÔNG TIN HÓA ĐƠN                      ║");
            Console.WriteLine("                            ║═══════════════════════════════════════════════════════════════║");
            Console.WriteLine("                            ║            Mã hóa đơn      :{0,20}              ║", hoaDon.Mahoadon);
            Console.WriteLine("                            ║            Ngày            :{0,20}              ║", hoaDon.Ngay);
            Console.WriteLine("                            ║            Mã nhân viên PV :{0,20}              ║", nhanVien.Manv);
            Console.WriteLine("                            ║            Tên nhân viên PV:{0,20}              ║", nhanVien.Hoten);
            Console.WriteLine("                            ║            Khách hàng      :{0,20}              ║", KhachHang.Tenkh);
            Console.WriteLine("                            ║            Mã khách hàng   :{0,20}              ║", KhachHang.Makhachhang);
            Console.WriteLine("                            ║                                                               ║");
            Console.WriteLine("                            ╚═══════════════════════════════════════════════════════════════╝");
            Console.WriteLine("Ấn phím bất kì để tiếp tục");
            Console.ReadKey();
            Console.Clear();

        }

        //tính tổng tiền trên mỗi hóa đơn
        public int thanhTienMoiHoaDon(string mahd)
        {
            IChiTietHoaDonBLL chiTietHoaDonBLL = new ChiTietHoaDonBLL();
            List<ChiTietHoaDon> chiTietHoaDonList = chiTietHoaDonBLL.GetAllChiTietHoaDon(mahd);
            FrmChiTietHoaDon frmChiTietHoaDon = new FrmChiTietHoaDon();
            int tong = 0;
            foreach (ChiTietHoaDon chiTietHoaDon in chiTietHoaDonList)
            {
                tong += frmChiTietHoaDon.thanhTien(chiTietHoaDon.Macthd);
            }
            return tong;
        }
        public void ThongKeTheoThang()
        {
            Console.WriteLine("Nhập tháng(tháng/năm): ");
            string thang = Tools.nhapString();
            int thangHienTai = DateTime.Now.Month;
            int namHienTai = DateTime.Now.Year;
            int thangTK = int.Parse(thang.Split("/")[0]);
            int namTK = int.Parse(thang.Split("/")[1]);
            int tong = 0;
            if (namTK <= namHienTai && thangTK <= thangHienTai)
            {
                foreach (HoaDon hoaDon in _hoaDonBll.GetAllHoaDon())
                {
                    if (hoaDon.Ngay.Contains(thang))
                    {
                        tong += thanhTienMoiHoaDon(hoaDon.Mahoadon);
                    }
                }
                Console.WriteLine("Tổng tiền đơn hàng: " + tong);
                Console.WriteLine("Thu nhập tháng " + thang + " :" + tong*0.3);
               
            }
            else
            {
                Console.WriteLine("Tháng hoặc năm thống kê không hợp lệ");
            }
        }
    }
}