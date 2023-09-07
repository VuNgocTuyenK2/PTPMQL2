using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

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


// chuyển đổi kiểu dữ liệu 
   //chuyển đổi kiểu dữ liệu ngầm định
   private static void Main(string[] args)
   {
    int a = 10;//biến số a kiểu int có kích thước nhỏ hơn biến số b kiểu float=> gán b=a
    float b = a;//giá trị của a được chuyển sang float và gán cho b...
    System.Console.WriteLine("b = "+ b);
   }
//ví dụ: chuyển đổi kiểu dữ liệu string(Gía trị là "123") sang kiểu số nguyên int(giá trị là 123)

private static void Main(string[] args)
{
    string str = "123";
    int a = int.Parse(str);
    System.Console.WriteLine("a = " + a);
    //Trypaurse
    string str = "123"; //giá trị đầu vào de chuyển đổi
    int ketQua; // biến lưu kết quả sau chuyển đổi
    //bien kiểm tra chuyển đổi có thành công hay không 
    bool kiemTra = false;
    //chuyển đổi kiểu dữ liệu
    kiemTra = int.TryParse(str,out(ketQua));
    System.Console.WriteLine("Ket qua = " + ketQua);


}
//sử dụng lớp Convert
private static void Main(string[] args)
{
    string str = "123";
    int a = Convert.ToInt32(str);
    System.Console.WriteLine("a = " + a);
}

//nhập 2 số từ bàn phím và thực hiện các yêu cầu sau:
//tính hiệu
internal class Program
{
    private static void Main(string[] args)
    {
       int a;//khai bao bien a kieu int
       int b;//khai báo bien b kieu int
       //thong bao cho người dùng nhập vào a
       System.Console.Write("a = ");
       //doc du lieu nhap vao tu ban phim chuyen sang kieu int va gan cho a
       a = Convert.ToInt32(Console.ReadLine());
       System.Console.Write("b = ");
       b = Convert.ToInt32(Console.ReadLine());
       //in hieu a-b ra ngoai man hinh
       System.Console.WriteLine("{0} - {1} = {2}",a,b,a-b);

//tinh tich 2 so va in ra man hinh
        System.Console.WriteLine("{0} * {1} = {2}",a,b,a*b);
//thuc hien phep chia lay phan nguyen va lay du 2 so => in ra man hinh//
        System.Console.WriteLine("{0} / {1} = {2}",a,b,a/b);
        System.Console.WriteLine("{0} % {1} = {2}", a, b, a%b);
    }
}