using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//Vu Ngoc Tuyen 2021050715
namespace DemoMVC.Models
{
    [Table("Person")]
    //Vu Ngoc Tuyen 2021050715
    public class Person
    {
        [Key]
        //Vu Ngoc Tuyen 2021050715
        public required string PersonID { get; set; }
        public required string FullName { get; set; }
        public required string Address { get; set; }//Vu Ngoc Tuyen 2021050715
    }
}

//Vu Ngoc Tuyen 2021050715 