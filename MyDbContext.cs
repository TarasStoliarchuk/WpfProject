using System;
using Microsoft.EntityFrameworkCore;

namespace WpfProject
{
    internal class MyDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Prescription> Recipes => Set<Prescription>();
        public MyDbContext() => Database.EnsureCreated();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"*");
        }
    }
}
