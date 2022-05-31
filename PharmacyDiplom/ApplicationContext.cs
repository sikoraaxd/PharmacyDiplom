using Microsoft.EntityFrameworkCore;
using PharmacyDiplom.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplom
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<PharmacyItem> PharmacyItems { get; set; }
        public DbSet<User> Users { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Pharmacy;Username=postgres;Password=alexgeniuss56455285");
        }
    }
}
