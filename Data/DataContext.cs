using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base  (options)
        {
            
        }


        public  DbSet<Employee> Employees { get; set; }
    }
}