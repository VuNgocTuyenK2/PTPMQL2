using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");   
      string name = "Tuyen";
      Console.WriteLine(name); 
      int myNum = 15;
      Console.WriteLine(myNum);
      int x = 5;
      int y = 6;
      Console.WriteLine(x + y); 

    }
  }
}


int a1 = 9; //khai bao bien so a kieu int va gan gia tri = 9
 Console.WriteLine("a1 = " + a1);

//in ra man hinh: a + b = 12
 int a = 9;
 int b = 3;
 Console.WriteLine("{0} + {1} = {2}", a, b, a+b);

 //vi du cau truc lenh Console.Read();
 static void Main(string[] args)
{
     Console.WriteLine("VNT VLOGS"); // In chữ "K team" sau đó xuống dòng.
     Console.Write(" Moi ban nhap ten cua minh: "); // In không xuống dòng.
     Console.WriteLine("Ten cua ban la: " + Console.ReadLine()); // Quy tắc chung trong thực hiện lệnh là lệnh bên trong thực hiện trước rồi đến lệnh bên ngoài chứa nó. Do đó chạy đến đây chương trình sẽ thực hiện lệnh Console.ReadLine() sau đó thực hiện cộng chuỗi và cuối cùng in chuỗi ra màn hình.
     Console.Write(" Moi ban nhap ngay sinh: ");
     Console.WriteLine(" Ngay sinh cua ban la: " + Console.ReadLine()); // Tương tự như trên
     Console.Write(" Moi ban nhap que quan: ");
     Console.WriteLine(" Que quan: " + Console.ReadLine()); // Tương tự như trên.

     Console.ReadKey();
}


internal class Program
{
    private static void Main(string[] args)
    { 
      //khai bao bieu kieu string va gan gia tri = Nguyen Van A
      string hoTen = "Nguyen Van A";
      //khai bao bien kieu in va gan gia tri = 18
      int tuoi = 18;
      Console.WriteLine("Sinh vien {0} - {1} tuoi",hoTen,tuoi);

    }
}
//ví dụ khai báo và gán giá trị cho 2 hằng số kiểu string và int, sau đó in ra màn hình
internal class Program
{
    private static void Main(string[] args)
    {
       //khai bao bieu kieu string va gan gia tri = Vu Ngoc Tuyen
       const string hoTen = "Vu Ngoc Tuyen"
       //khai bao bien kieu int va gan gia tri = 18
       const int namLamviec = 8
       Console.WriteLine("Nhan vien {0} - {1} nam kinh nghiem",hoTen,namLamviec);

    }
}