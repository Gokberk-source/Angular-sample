using AngularProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace AngularProject.AngularProjectContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
