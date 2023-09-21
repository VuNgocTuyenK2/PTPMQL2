namespace NewApp.Models
{
    public class Fruit
    {
        public string TenQua { get; set; }
        public int GiaBan { get; set; }
        public int KhoiLuong { get; set; }
        public void NhapThongTin()
        {
            
           System.Console.Write("Ten Qua = ");
           TenQua = Console.ReadLine();
           System.Console.Write("GiaBan = ");
           GiaBan = Convert.ToInt32(Console.ReadLine());
           System.Console.Write("Khoi Luong = ");
           KhoiLuong = Convert.ToInt32(Console.ReadLine());
        }
        public void HienThi()
        {
            System.Console.WriteLine("{0} - {1} - {2} kg", TenQua, GiaBan, KhoiLuong);
        }
    }
}