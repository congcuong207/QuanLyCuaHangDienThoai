using System;
using System.Collections.Generic;
using System.IO;
using QuanLyCuaHangDienThoai.Entities;

namespace QuanLyCuaHangDienThoai.DataAccessLayer.ServiceInterface
{
    public class ChiTietHoaDonDAL:IChiTietHoaDonDAL
    {
        string path = "ChiTietHoaDon.txt";
        public List<ChiTietHoaDon> GetAllChiTietHoaDon()
        {
            List<ChiTietHoaDon> ChiTietHoaDons = new List<ChiTietHoaDon>();
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split('#');
                    ChiTietHoaDon ChiTietHoaDon = new ChiTietHoaDon();
                    //return macthd + "#" + mahoadon + "#" + maDienThoai + "#" + soluong;
                    ChiTietHoaDon.Macthd = arr[0];
                    ChiTietHoaDon.Mahoadon = arr[1];
                    ChiTietHoaDon.MaDienThoai = arr[2];
                    ChiTietHoaDon.Soluong = int.Parse(arr[3]);
                    ChiTietHoaDons.Add(ChiTietHoaDon);
                }
                sr.Close();
            }
            return ChiTietHoaDons;
        }

        public void Insert(ChiTietHoaDon chiTietHoaDon)
        {
            List<ChiTietHoaDon> chiTietHoaDons = GetAllChiTietHoaDon();
            chiTietHoaDons.Add(chiTietHoaDon);
            try
            {
                StreamWriter sw = new StreamWriter(path);
                foreach (ChiTietHoaDon ChiTietHoaDon in chiTietHoaDons)
                {
                    sw.WriteLine(ChiTietHoaDon.ToString());
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