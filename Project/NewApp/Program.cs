﻿using NewApp.Models;
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