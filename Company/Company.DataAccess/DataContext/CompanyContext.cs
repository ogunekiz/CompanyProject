using Company.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Company.DataAccess.DataContext
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {
        }

        public DbSet<Personel> Personels { get; set; }
    }
}
