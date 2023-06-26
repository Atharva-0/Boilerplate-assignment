using Microsoft.EntityFrameworkCore;
using Session3.Models;

namespace Session3.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {
            
        }

        public DbSet<Employee>Employees { get; set; }
    }
}
