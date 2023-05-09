using Microsoft.EntityFrameworkCore;
using Datamesh.Models;
using System;

namespace Datamesh.Data
{
    public class DatameshContext : DbContext
    {
        public DatameshContext (DbContextOptions<DatameshContext> options) : base(options) { }

        public DbSet<DataDomain> DataDomainSet { get; set; } = null!;
        public DbSet<Dataproduct> DataproductSet { get; set; } = null!;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataDomain>().ToTable("DataDomainSet");
            modelBuilder.Entity<DataDomain>()
                .HasMany(dp => dp.Dataproducts)
                .WithOne(dd => dd.DataDomain);
        }
        modelBuilder.Entity<Dataproduct>().ToTable("DataproductSet");
            
    }

}