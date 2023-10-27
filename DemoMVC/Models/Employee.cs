namespace DemoMVC.Models;
using System.ComponentModel.DataAnnotations;
public class Employee
{
    public  string FullName { get; set; }
    public int HeSoLuong { get; set; }
    public int LuongCB { get; set; }
    public int PhuCap { get; set; }
}