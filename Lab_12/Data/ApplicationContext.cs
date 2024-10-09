using Lab_12.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab_12.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<SupplyM> Supplies => Set<SupplyM>();
        public DbSet<PharmacyM> Pharmacies => Set<PharmacyM>();
        public DbSet<PharmacistM> Pharmacists => Set<PharmacistM>();

        public ApplicationContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=pharmacy.db");
        }
    }
}
