using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//Vu Ngoc Tuyen 2021050715
namespace DemoMVC.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        public required string FullName { get; set; }
    }
}

//Vu Ngoc Tuyen 2021050715 