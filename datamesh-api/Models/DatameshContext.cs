using Microsoft.EntityFrameworkCore;

namespace Datamesh.Models
{

    public class DatameshContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string for sqlserver localhost database
            optionsBuilder.UseSqlServer("Server=localhost;Database=datamesh;User Id=sa;Password=P@ssw0rd;");
        }

        public DbSet<DataDomain> DataDomainSet { get; set; }
    }

}
