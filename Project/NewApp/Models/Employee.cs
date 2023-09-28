namespace NewApp.Models
{
    public class Employee
    {
        
       public string MaNhanVien { get; set; }
       public string TenNhanVien { get; set; }
       public int Tuoi { get; set; }
       public double Luong { get; set; }
       public String DiaChi { get; set; }
       
       public void NhapThongTin()

       {
        System.Console.Write("Ma Nhan Vien = ");
        MaNhanVien = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Ten Nhan Vien = ");
        TenNhanVien = Console.ReadLine();
        System.Console.Write("Tuoi = ");
        Tuoi = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Luong = ");
        Luong = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("Dia Chi = ");
        DiaChi = Console.ReadLine();
        

        
       }
       public Employee()
       {
        string MaNhanVien = "PS001";
        string TenNhanVien = "Vu Ngoc Tuyen";
        string DiaChi = "Hai Duong"

       }
       public void HienThi()
       {
        System.Console.WriteLine("{0} - {1} - {2} - {3} VND", MaNhanVien, TenNhanVien, Tuoi, Luong);
       }
    }
}