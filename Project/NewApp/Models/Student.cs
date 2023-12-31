
namespace NewApp.Models
{
    public class Student : Person
    {
        public int MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public string Nganh { get; set; }
        public int Point { get; set; }
        public string StudentCode { get; set; }
        public void NhapThongTin()
        {
            System.Console.Write("Ma Sinh Vien = ");
            MaSinhVien = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Ten Sinh Vien = ");
            TenSinhVien = Console.ReadLine();
            System.Console.Write("Nganh = ");
            Nganh = Console.ReadLine();
            try{

            System.Console.Write("Ma Sinh Vien = ");
            MaSinhVien = Convert.ToInt32(Console.ReadLine());

            }catch(Exception e)
            {
                System.Console.WriteLine("Co ngoai le xay ra");

            }
        }
        public Student()
        {
            MaSinhVien = "2021050715";
            TenSinhVien = "Vu Ngoc Tuyen";
            Nganh = "Cong Nghe Thong Tin";
        }
         public void EnterData()
        {
            base.EnterData();
            System.Console.WriteLine("Student Code = ");
            StudentCode = Console.ReadLine();  
        }

        public void Display()
        {
           base.Display();
           System.Console.WriteLine("Ma sinh vien: {0}", StudentCode); 
        }
        public void HienThi()
        {
            System.Console.WriteLine("{0} - {1} - {2} ",MaSinhVien, TenSinhVien, Nganh);
        }
        public void Student(int MaSinhVien, String TenSinhVien, string Nganh)
        public int TinhDiem(int Point)
        {
            int TinhDiem = TinhDiem/1;
            System.Console.WriteLine("{0} - {1} - {2} - {3} Point",MaSinhVien, TenSinhVien, Nganh, StringDictionary.TinhDiem(a));
            return TinhDiem;

        }
    }
}