namespace DemoMVC.Models;
//Vu Ngoc Tuyen 2021050715
using System.ComponentModel.DataAnnotations;
public class Employee : Person
{
  //bo sung them thuoc tinh 
  public string EmployeeID { get; set; }
  //Vu Ngoc Tuyen 2021050715
  public int Age { get; set; }
  //Vu Ngoc Tuyen 2021050715
}