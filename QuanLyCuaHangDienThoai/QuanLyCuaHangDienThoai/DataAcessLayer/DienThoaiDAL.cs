using System;
using System.Collections.Generic;
using System.IO;
using QuanLyCuaHangDienThoai.DataAccessLayer.ServiceInterface;
using QuanLyCuaHangDienThoai.Entities;

namespace QuanLyCuaHangDienThoai.DataAccessLayer
{
    public class DienThoaiDAL : IDienThoaiDAL
    {
        string path = "DienThoai.txt";

        public List<DienThoai> GetAllDienThoai()
        {
            List<DienThoai> DienThoais = new List<DienThoai>();
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split('#');
                    DienThoai DienThoai = new DienThoai();
                    //return id + "#" + ten + "#" + loai + "#" + gia + "#" + soluong;
                    DienThoai.Id = arr[0];
                    DienThoai.Ten = arr[1];
                    DienThoai.Loai = arr[2];
                    DienThoai.Gia = int.Parse(arr[3]);
                    DienThoai.Soluong = int.Parse(arr[4]);
                    DienThoais.Add(DienThoai);
                }

                sr.Close();
            }

            return DienThoais;
        }

        public void Insert(DienThoai DienThoai)
        {
            List<DienThoai> DienThoais = GetAllDienThoai();
            DienThoais.Add(DienThoai);
            try
            {
                StreamWriter sw = new StreamWriter(path);
                foreach (DienThoai dv in DienThoais)
                {
                    sw.WriteLine(dv.ToString());
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
            List<DienThoai> DienThoais = GetAllDienThoai();
            DienThoais.RemoveAt(vitri);
            try
            {
                StreamWriter sw = new StreamWriter(path);
                foreach (DienThoai DienThoai in DienThoais)
                {
                    sw.WriteLine(DienThoai.ToString());
                }

                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Update(int vitri, DienThoai DienThoai)
        {
            List<DienThoai> DienThoais = GetAllDienThoai();
            DienThoais[vitri] = DienThoai;
            try
            {
                StreamWriter sw = new StreamWriter(path);
                foreach (DienThoai dv in DienThoais)
                {
                    sw.WriteLine(dv.ToString());
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