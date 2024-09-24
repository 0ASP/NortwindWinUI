using Microsoft.EntityFrameworkCore;
using Northwind.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrate.context
{
    public class NorthwindDBContext : DbContext
    {
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Satis> Satis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R2HDSGJ;Database=Northwind;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
