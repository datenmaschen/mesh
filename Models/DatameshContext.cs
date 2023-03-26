using Microsoft.EntityFrameworkCore;

namespace Datamesh.Models
{

    public class DatameshContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=datamesh;User Id=sa;Password=P@ssw0rd;TrustServerCertificate=True;");
        }

        public DbSet<DataDomain> DataDomainSet { get; set; } = null!;
    }

}
