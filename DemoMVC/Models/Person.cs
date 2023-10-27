using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models;

[Table("Persons")]
public class Person
{
    [Key]
    public int PersonID { get; set; }
    public string FullName { get; set; }
}