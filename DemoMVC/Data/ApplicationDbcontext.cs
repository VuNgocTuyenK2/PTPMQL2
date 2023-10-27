using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
namespace DemoMVC.Data
{
    public class ApplicationDbContext: DbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        {}
        public DbSet <Person> Person { get; set; }
    }
}