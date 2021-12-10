using System;
using QuanLyCuaHangDienThoai.BusinessLogicLayer.ServiceInterface;
using QuanLyCuaHangDienThoai.DataAccessLayer.ServiceInterface;
using QuanLyCuaHangDienThoai.Entities;
using QuanLyCuaHangDienThoai.BusinessLogicLayer;
using QuanLyCuaHangDienThoai.Utility;

namespace QuanLyCuaHangDienThoai.Presenation.Frm
{
    public class FrmChiTietHoaDon
    {
        IChiTietHoaDonBLL chiTietHoaDonBLL = new ChiTietHoaDonBLL();
        private ChiTietHoaDon nhapChiTietHoaDon(string maHoaDon)
        {
            Random random = new Random();
            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
            chiTietHoaDon.Macthd = "CTHD" + random.Next();
            chiTietHoaDon.Mahoadon = maHoaDon;
            FrmDienThoai frmDienThoai = new FrmDienThoai();
            frmDienThoai.HienDSDienThoai();
            Console.WriteLine("Chọn sản phẩm: ");
            int chonDienThoai = int.Parse(Tools.nhapString());
            DienThoai DienThoai=new DienThoai();
            if (chonDienThoai > -1 && chonDienThoai < frmDienThoai.DienThoaiList.Count)
            {
                DienThoai = frmDienThoai.DienThoaiList[chonDienThoai];
                chiTietHoaDon.MaDienThoai = DienThoai.Id;
            }
            Console.WriteLine("Nhập số lượng: ");
            chiTietHoaDon.Soluong = int.Parse(Tools.nhapString());
            while (true)
            {
                if (chiTietHoaDon.Soluong <= DienThoai.Soluong) break;
                Console.WriteLine("Số lượng vượt mức tối đa: ");
                chiTietHoaDon.Soluong = int.Parse(Tools.nhapString());
            }
            DienThoai.Soluong = DienThoai.Soluong - chiTietHoaDon.Soluong;
            IDienThoaiBLL DienThoaiBLL = new DienThoaiBLL();
            DienThoaiBLL.SuaDienThoai(chonDienThoai, DienThoai);
            return chiTietHoaDon;
        }
        public int thanhTien(string macthdn)
        {
            FrmDienThoai DienThoaiBLL = new FrmDienThoai();
            ChiTietHoaDon chiTietHoaDon = chiTietHoaDonBLL.chiTietHoaDon(macthdn);
            DienThoai DienThoai = DienThoaiBLL.DienThoai(chiTietHoaDon.MaDienThoai);
            int thanhTien = chiTietHoaDon.Soluong * DienThoai.Gia;
            return thanhTien;
        }
        private void hienCTHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            FrmDienThoai DienThoaiBLL = new FrmDienThoai();
            DienThoai DienThoai = DienThoaiBLL.DienThoai(chiTietHoaDon.MaDienThoai);
            int thanhTien = chiTietHoaDon.Soluong * DienThoai.Gia;
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", chiTietHoaDon.MaDienThoai, DienThoai.Ten, DienThoai.Gia, chiTietHoaDon.Soluong, thanhTien);
        }
        public void hienDSCTHoaDon(string maHoaDon)
        {
            int tong = 0;
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", "Mã sản phẩm", "Tên sản phẩm", "Giá bán", "Số lượng", "Thành tiền");
            foreach (ChiTietHoaDon chiTietHoaDon in chiTietHoaDonBLL.GetAllChiTietHoaDon(maHoaDon))
            {
                hienCTHoaDon(chiTietHoaDon);
                tong += thanhTien(chiTietHoaDon.Macthd);
            }
            Console.WriteLine("Tổng tiền thanh toán là: " + tong);
        }
        public void themChiTietHoadon(string maHoaDon)
        {
            while (true)
            {
                ChiTietHoaDon chiTietHoaDon = nhapChiTietHoaDon(maHoaDon);
                chiTietHoaDonBLL.themChiTietHoadon(chiTietHoaDon);
                Console.WriteLine("Bạn muốn mua thêm không? C/K");
                string chon = Tools.nhapString();
                if (chon.Equals("K") || chon.Equals("k")) break;
            }

        }
        
    }
}