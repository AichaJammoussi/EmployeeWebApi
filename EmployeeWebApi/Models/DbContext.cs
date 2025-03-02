using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace EmployeeWebApi.Models
{
   
        public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }
            public DbSet<Employee> Employees { get; set; }
            public DbSet<Department> Departments { get; set; }
        
    }
}
