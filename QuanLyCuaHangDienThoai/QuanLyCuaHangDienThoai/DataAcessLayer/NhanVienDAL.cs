using System;
using System.Collections.Generic;
using System.IO;
using QuanLyCuaHangDienThoai.DataAccessLayer.ServiceInterface;
using QuanLyCuaHangDienThoai.Entities;

namespace QuanLyCuaHangDienThoai.DataAccessLayer
{
    public class NhanVienDAL : INhanVienDAL
    {
        string path = "NhanVien.txt";

        public List<NhanVien> GetAllNhanVien()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split('#');
                    NhanVien nhanVien = new NhanVien();
              
                    nhanVien.Manv = arr[0];
                    nhanVien.Hoten = arr[1];
                    nhanVien.Ngaysinh = arr[2];
                    nhanVien.Diachi = arr[3];
                    nhanVien.Sdt = arr[4];
                    nhanVien.Luong = int.Parse(arr[5]);
                  
               
                    nhanViens.Add(nhanVien);
                }

                sr.Close();
            }

            return nhanViens;
        }

        public void Insert(NhanVien nhanVien)
        {
            List<NhanVien> nhanViens = GetAllNhanVien();
            nhanViens.Add(nhanVien);
            try
            {
                StreamWriter sw = new StreamWriter(path);
                foreach (NhanVien nv in nhanViens)
                {
                    sw.WriteLine(nv.ToString());
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
            List<NhanVien> nhanViens = GetAllNhanVien();
            nhanViens.RemoveAt(vitri);
            try
            {
                StreamWriter sw = new StreamWriter(path);
                foreach (NhanVien nhanvien in nhanViens)
                {
                    sw.WriteLine(nhanvien.ToString());
                }

                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Update(int vitri, NhanVien nhanVien)
        {
            List<NhanVien> nhanViens = GetAllNhanVien();
            nhanViens[vitri] = nhanVien;
            try
            {
                StreamWriter sw = new StreamWriter(path);
                foreach (NhanVien nv in nhanViens)
                {
                    sw.WriteLine(nv.ToString());
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