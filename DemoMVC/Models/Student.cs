using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models
{


    public class Student 
    {

        [Required(ErrorMessage = "Vui long nhap Student id")]

        public string? StudentID { get; set; }
        [Required]
        public string FullName { get; set; }
       
    }

}
//Vu Ngoc Tuyen 2021050715


