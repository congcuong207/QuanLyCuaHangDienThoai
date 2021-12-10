using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoai.Utility
{
    class Tools
    {
        public static bool IsPhoneNumber(string number)
        {
            
            return Regex.Match(number, @"(84|0[3|5|7|8|9])+([0-9]{8})\b").Success;
        }
   
        public static string nhapString()
        {
            string str = Console.ReadLine();
            while (true)
            {
                if (str != "") break;
                Console.Write("Không được để trống: ");
                str = Console.ReadLine();
            }
            return str;
        }
        public static bool IsDateTime(string txtDate)
        {
            DateTime tempDate;
            return DateTime.TryParse(txtDate, out tempDate);
        }
        public static string nhapNgay()
        {
            string str = nhapString();
            while (true)
            {
                if (IsDateTime(str)) break;
                Console.Write("Ngày nhập không chính xác: ");
                str = Console.ReadLine();
            }
            return str;
        }
        public static string nhapNgaySinhNhanVien()
        {
            string str = nhapNgay();
           
            return str;
        }
    }
}
