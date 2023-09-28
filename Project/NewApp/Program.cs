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
emp.NhapThongTin();
emp.HienThi();
Student std = new Student();
//khai bao 3 bien va gan gia tri
String MaSinhVien = 2021050715;
String TenSinhVien = "Vu Ngoc Tuyen";
String Nganh = "Cong Nghe Thong Tin";
std.Student(MaSinhVien,TenSinhVien,Nganh);
int a = 9;
Student std2 = new Student();
std.NhapThongTin();
std.HienThi();
std2.HienThi();

Fruit frt = new Fruit();
Fruit frt2 = new Fruit();
frt.NhapThongTin();
frt.HienThi();
frt.HienThi();
frt2.HienThi();
    }

}