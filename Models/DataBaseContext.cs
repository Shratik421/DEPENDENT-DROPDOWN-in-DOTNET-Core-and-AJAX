using Microsoft.EntityFrameworkCore;

namespace DependentDropdownPract.Models
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public DbSet<Category>? Category { get; set; }
        public DbSet<SubCategory>? SubCategory { get; set; }
        public DbSet<MainProduct>? MainProduct { get; set; }    


    }
}
