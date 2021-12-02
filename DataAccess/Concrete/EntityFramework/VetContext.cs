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
        public DbSet<Accouting> accoutings { get; set; }
        public DbSet<InCome> inComes { get; set; }
        public DbSet<Expense> expenses { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Pet> pets { get; set; }
        public DbSet<Gender> genders { get; set; }
        public DbSet<Appointment> appointments { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
    }
}
