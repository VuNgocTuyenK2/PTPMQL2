using System.Collections.Specialized;
using System.Net.Sockets;

namespace NewApp.Models
{
    public class Student
    {
        public int MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public string Nganh { get; set; }
        public void NhapThongTin()
        public int Point { get; set; }
        {
            System.Console.Write("Ma Sinh Vien = ");
            MaSinhVien = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Ten Sinh Vien = ");
            TenSinhVien = Console.ReadLine();
            System.Console.Write("Nganh = ");
            Nganh = Console.ReadLine();
        }
        public Student()
        {
            MaSinhVien = "2021050715";
            TenSinhVien = "Vu Ngoc Tuyen";
            Nganh = "Cong Nghe Thong Tin";
        }
        public void HienThi()
        {
            System.Console.WriteLine("{0} - {1} - {2} ",MaSinhVien, TenSinhVien, Nganh);
        }
        public void Student(int MaSinhVien, String TenSinhVien, string Nganh)
        public int TinhDiem(int Point)
        {
            int TinhDiem = TinhDiem/1;
            return TinhDiem;
        }

        {
            System.Console.WriteLine("{0} - {1} - {2} - {3} diem",MaSinhVien, TenSinhVien, Nganh, StringDictionary.TinhDiem(a));
        }
    }
}