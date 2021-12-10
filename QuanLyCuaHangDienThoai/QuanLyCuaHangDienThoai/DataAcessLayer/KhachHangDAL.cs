using System;
using System.Collections.Generic;
using System.IO;
using QuanLyCuaHangDienThoai.DataAccessLayer.ServiceInterface;
using QuanLyCuaHangDienThoai.Entities;

namespace QuanLyCuaHangDienThoai.DataAccessLayer
{
    public class KhachHangDAL : IKhachHangDAL
    {
        string path = "KhachHang.txt";

        public List<KhachHang> GetAllKhachHang()
        {
            List<KhachHang> KhachHangs = new List<KhachHang>();
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split('#');
                    KhachHang KhachHang = new KhachHang();
                    //mathe + "#" + tenkh + "#" + sdt + "#" + solanden;
                    KhachHang.Makhachhang = arr[0];
                    KhachHang.Tenkh = arr[1];
                    KhachHang.Sdt = arr[2];
                    KhachHang.Solanden = int.Parse(arr[3]);
                    KhachHangs.Add(KhachHang);
                }

                sr.Close();
            }

            return KhachHangs;
        }

        public void Insert(KhachHang KhachHang)
        {
            List<KhachHang> KhachHangs = GetAllKhachHang();
            KhachHangs.Add(KhachHang);
            try
            {
                StreamWriter sw = new StreamWriter(path);
                foreach (KhachHang kh in KhachHangs)
                {
                    sw.WriteLine(kh.ToString());
                }

                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(int vitri)
        {
            List<KhachHang> KhachHangs = GetAllKhachHang();
            KhachHangs.RemoveAt(vitri);
            try
            {
                StreamWriter sw = new StreamWriter(path);
                foreach (KhachHang KhachHang in KhachHangs)
                {
                    sw.WriteLine(KhachHang.ToString());
                }

                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Update(int vitri, KhachHang KhachHang)
        {
            List<KhachHang> KhachHangs = GetAllKhachHang();
            KhachHangs[vitri] = KhachHang;
            try
            {
                StreamWriter sw = new StreamWriter(path);
                foreach (KhachHang kh in KhachHangs)
                {
                    sw.WriteLine(kh.ToString());
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