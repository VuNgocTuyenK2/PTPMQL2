using Microsoft.EntityFrameworkCore;

using DemoMVC.Models;
namespace DemoMVC.Data
{
    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
       
        public DbSet<Employee> Employee { get; set; } = default!;
        public DbSet<Student> Student { get; set; } = default!;
        public DbSet<Person> Person { get; set; } 
        
        
        
       
        
        
        
        
        
        
        
        
        
        
        
        
    }
}