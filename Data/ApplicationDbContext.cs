// Name: Christoper Hiero Barus
// NIM: 2481036
// Course: Framework .NET Programming
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
namespace StudentInformationSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        //Students table
        public DbSet<Student> Students => Set<Student>();
        //configure NIM as unique and specify maximum lengths
        //the NIM unique index is only declared once
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.HasIndex(s => s.NIM).IsUnique();
                entity.Property(s => s.NIM).HasMaxLength(20).IsRequired();
                entity.Property(s => s.Name).HasMaxLength(120).IsRequired();
                entity.Property(s => s.Major).HasMaxLength(100).IsRequired();
            });
        }
    }
}