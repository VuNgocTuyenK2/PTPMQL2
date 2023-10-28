using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models;

//Vu Ngoc Tuyen 2021050715
public class Person
{
    
    public int PersonID { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
}
//Vu Ngoc Tuyen 2021050715 