namespace NewApp.Models
{
    public class Employee
    {
        
       public int MaNhanVien { get; set; }
       public string TenNhanVien { get; set; }
       public int Tuoi { get; set; }
       public double Luong { get; set; }
       
       
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
        

        
       }
       public void HienThi()
       {
        System.Console.WriteLine("{0} - {1} - {2} - {3} VND", MaNhanVien, TenNhanVien, Tuoi, Luong);
       }
    }
}