
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models;

    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public required string FullName { get; set; }
    }
//Vu Ngoc Tuyen 2021050715


