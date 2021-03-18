using System.Diagnostics;
using System.Reflection.PortableExecutable;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Infrastructure
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options): 
            base(options)
        {
            
        }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Owner>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<PortfolioItem>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

            modelBuilder.Entity<Owner>().HasData(
                new Owner()
                {
                    Id = Guid.NewGuid(),
                    Avatar = "avatar1.jpg",
                    FullName = "Youssef TAYEK",
                    Profil = "Web Developper"
                }
                );
        }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<PortfolioItem> PortfolioItems { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}