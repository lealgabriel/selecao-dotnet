using Microsoft.EntityFrameworkCore;
using System;
using TesteIndra.Models;
namespace TesteIndra.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Courses> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(p => p.Id)
                .HasMaxLength(80);

            modelBuilder.Entity<Student>()
                    .Property(p => p.Name)
                    .HasMaxLength(80);

            modelBuilder.Entity<Student>()
                    .Property(p => p.Email)
                    .HasMaxLength(50);

            modelBuilder.Entity<Student>()
                    .Property(p => p.Password)
                    .HasMaxLength(80);

            modelBuilder.Entity<CreditCard>()
                    .Property(p => p.Id)
                    .HasMaxLength(80);

            modelBuilder.Entity<CreditCard>()
                    .Property(p => p.Number)
                    .HasMaxLength(16);

            modelBuilder.Entity<CreditCard>()
                    .Property(p => p.Name)
                    .HasMaxLength(80);

            modelBuilder.Entity<CreditCard>()
                    .Property(p => p.Cvc)
                    .HasMaxLength(3);

            modelBuilder.Entity<Courses>()
                    .Property(p => p.Id)
                    .HasMaxLength(80);

            modelBuilder.Entity<Courses>()
                    .Property(p => p.NameCourse)
                    .HasMaxLength(80);
        }
    }
}
