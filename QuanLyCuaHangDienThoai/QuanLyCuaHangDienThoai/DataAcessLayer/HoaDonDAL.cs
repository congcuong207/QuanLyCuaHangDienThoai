using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using QuanLyCuaHangDienThoai.DataAccessLayer.ServiceInterface;
using QuanLyCuaHangDienThoai.Entities;

namespace QuanLyCuaHangDienThoai.DataAccessLayer
{
    public class HoaDonDAL : IHoaDonDAL
    {
        string path = "HoaDon.txt";

        public List<HoaDon> GetAllHoaDon()
        {
            List<HoaDon> HoaDons = new List<HoaDon>();
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split('#');
                    HoaDon HoaDon = new HoaDon();
                    //mahoadon + "#" + ngay + "#" + makhachhang + "#" + manv 
                    HoaDon.Mahoadon = arr[0];
                    HoaDon.Ngay = arr[1];

                    HoaDon.Makhachhang = arr[2];
                    HoaDon.Manv = arr[3];

                    HoaDons.Add(HoaDon);
                }
                sr.Close();
            }
            return HoaDons;
        }

        public List<ChiTietHoaDon> GetAllChiTietHoaDon(string mahd)
        {
            ChiTietHoaDonDAL chiTietHoaDonDal = new ChiTietHoaDonDAL();
            List<ChiTietHoaDon> chiTietHoaDons =
                chiTietHoaDonDal.GetAllChiTietHoaDon().Where(x => x.Mahoadon.Equals(mahd)).ToList();
            return chiTietHoaDons;
        }

        public void Insert(HoaDon hoaDon)
        {
            List<HoaDon> hoaDons = GetAllHoaDon();
            hoaDons.Add(hoaDon);
            try
            {
                StreamWriter sw = new StreamWriter(path);
                foreach (HoaDon HoaDon in hoaDons)
                {
                    sw.WriteLine(HoaDon.ToString());
                }

                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    
    }
}