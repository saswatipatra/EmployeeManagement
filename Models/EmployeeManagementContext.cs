using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using EmployeeManagement.Models;
namespace EmployeeManagement.Models

{
    public class EmployeeManagementContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"server=localhost;user id=root;password=epicodus;port=3306;database=employee;");

        public EmployeeManagementContext(DbContextOptions options) : base(options) { }
        
        public EmployeeManagementContext()
        {

        }
    }

}