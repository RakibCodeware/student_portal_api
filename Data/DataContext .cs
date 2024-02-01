
using EduPortalAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;

namespace EduPortalAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> UsersForPortal { get; set; }
        public DbSet<StudentGroupSubjectInfo> StudentGroupSubjectInfoTemp { get; set; }
        public  DbSet<StudentGroupSubjectDetails> StudentGroupSubjectDetailsTemp { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(p => new { p.UserName })
                .IsUnique(true);

            modelBuilder.Entity<StudentGroupSubjectInfo>()
            .HasIndex(s => new { s.StudentId, s.BatchID })
            .IsUnique(true);;

            modelBuilder.Entity<StudentGroupSubjectDetails>()
              .HasOne(x => x.StudentGroupSubjectInfo)
              .WithMany(x => x.Subjects)
              .HasForeignKey(x=>x.SgsId);


        }
    }
}
