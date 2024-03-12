using Employee_Web_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Web_App.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
