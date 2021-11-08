using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class VetContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=Veterinerlik; Trusted_Connection=true;");
        }

        public DbSet<City> cities { get; set; }
        public DbSet<District> districts { get; set; }
        public DbSet<Address> addresses { get; set; }
        public DbSet<Animal> animals { get; set; }
        public DbSet<Genus> genus { get; set; }
        public DbSet<Grade> grades { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<HospitalCategory> hospitalCategories { get; set; }
        public DbSet<HospitalizasyonBed> hospitalizasyonBeds { get; set; }
        public DbSet<Hospitalizasyon> hospitalizasyons { get; set; }
    }
}
