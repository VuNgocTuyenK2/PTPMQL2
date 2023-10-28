namespace DemoMVC.Models;
using System.ComponentModel.DataAnnotations;
public class Employee : Person
{
  //bo sung them thuoc tinh 
  public string EmployeeID { get; set; }
  public int Age { get; set; }
}