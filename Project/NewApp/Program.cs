using NewApp.Models;
public class Program
{
    private static void Main(string[] args)
    {

//khoi tao 2 doi tuong
Person ps = new Person();
Person ps2 = new Person();
ps.NhapThongTin();
ps.HienThi();
ps2.HienThi();
//vu ngoc tuyen 2021050715
Employee emp = new Employee();
emp.EnterData();
emp.Display();
//khai bao 2 bien va gan gia tri
int a = 21;
System.Console.WriteLine("{0} - {1} - {2} - {3}",MaNhanVien,TenNhanVien,DiaChi,emp.TinhLuong(c));
string str = "Vu Ngoc Tuyen"
emp.Employee(a, str);
Employee emp2 = new Employee();
emp.NhapThongTin();
emp.HienThi();
emp2.HienThi();
Student std = new Student();
//khai bao 3 bien va gan gia tri
String MaSinhVien = 2021050715;
String TenSinhVien = "Vu Ngoc Tuyen";
String Nganh = "Cong Nghe Thong Tin";
std.Student(MaSinhVien,TenSinhVien,Nganh);
int a = 9;
Student std2 = new Student();
std.NhapThongTin();
std.StudentCode = "2021050715";
std.EnterData();
std.Display();
std.HienThi();
std2.HienThi();

Fruit frt = new Fruit();
Fruit frt2 = new Fruit();
frt.NhapThongTin();
frt.HienThi();
frt.HienThi();
frt2.HienThi();


//pt bac nhat
 GiaiPT pt1 = new GiaiPT();
 GiaiPT pt2 = new GiaiPT();
     System.Console.WriteLine(pt1.PhuongTrinhBacNhat(6, 9));
     System.Console.WriteLine(pt2.PhuongTrinhBacHai(2,8,3));
    }

}