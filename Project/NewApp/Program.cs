using System.Collections;
using System.Collections.Specialized;
using NewApp.Models;
public class Program
{
    private static void Main(string[] args)
    {
        ArrayList personList = new ArrayList();
        ArrayList studentList = new ArrayList();
        ArrayList employeeList = new ArrayList();

        int n;
        do
        {
            try
            {
                System.Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
                private static void Main(string[] args)
                {
                    ArrayList studentList = new ArrayList();
                    int n;
                    do
                    {
                        try
                        {
                            System.Console.Write("n = ");
                            n = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            n = 0;
                        }
                    } while (n < 1);

                    // Them n phan tu vao list

                    for (int i = 0; i < n; i++)
                    {
                        System.Console.WriteLine($"[{i}]");
                        Student std = new Student();
                        std.EnterData();
                        studentList.Add(std);
                    }

                }
            }catch
            {
                n = 0;
            }
        } while (n < 1);
        Person[] A = new Person[n];
        Employee[] A = new Employee[n];
        Student[] A = new Student[n];
        Fruit[] A = new Fruit[n];
        for (int i = 0; i < A.Length; i++)
        {
            System.Console.WriteLine("A[{0}]:", i);
            Person ps = new Person();
            ps.EnterData();
            A[i] = ps;
            Employee emp = new Employee();
            emp.EnterData();
            A[i] = emp;
            Student std = new Student();
            std.EnterData();
            A[i] = std;
            Fruit frt = new Fruit();
            frt.NhapThongTin();
            A[i] = frt;
        }

        // HIen thi cac phan tu trong array
        for (int i = 0; i < A.Length; i++)
        {
            System.Console.WriteLine(i + " FullName:  - " + A[i].FullName + " Address: - " + A[i].Address + " Age: - " + A[i].Age);
            System.Console.WriteLine(i + " FullName:  - " + A[i].FullName + " Address: - " + A[i].Address + " EmployeeID: - " + A[i].EmployeeID);
            System.Console.WriteLine(i + " FullName:  - " + A[i].FullName + " Address: - " + A[i].Address + " StudentID: - " + A[i].StudentID);
            System.Console.WriteLine(i + " FruitName:  - " + A[i].FruitName + " Cost: - " + A[i].Cost + "VND");
        }







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
        System.Console.WriteLine("{0} - {1} - {2} - {3}", MaNhanVien, TenNhanVien, DiaChi, emp.TinhLuong(c));
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
        std.Student(MaSinhVien, TenSinhVien, Nganh);
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
        System.Console.WriteLine(pt2.PhuongTrinhBacHai(2, 8, 3));
    }

}