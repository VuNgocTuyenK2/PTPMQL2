namespace NewApp.Models
{
    public class Person
    {
        //thuoc tinh
       public string PersonID { get; set; }
       public string FullName { get; set; }
       public int Age { get; set; }
       
       //phuong thuc
       public void NhapThongTin()
       {
        System.Console.Write("PersonID = ");
        PersonID = Console.ReadLine();
        System.Console.Write("Full Name = ");
        FullName = Console.ReadLine();
        System.Console.Write("Age = ");
        Age = Convert.ToInt16(Console.ReadLine());

        
       }
       public void HienThi()
       {
        System.Console.WriteLine("{0} - {1} - {2} tuoi", PersonID, FullName, Age);
       }
    }
}