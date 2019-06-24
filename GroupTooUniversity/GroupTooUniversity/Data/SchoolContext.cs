using GroupTooUniversity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace GroupTooUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Instructor>(b =>
            {
                b.ToTable("Instructor");
                b.Property(i => i.FirstMidName)
                    .IsRequired()
                    .HasMaxLength(256);
                b.Property(i => i.Email)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Student>(b =>
            {
                b.ToTable("Student");
                b.HasAlternateKey(u => u.ID);
                b.Property(u => u.FirstMidName)
                    .IsRequired()
                    .HasMaxLength(256);
                b.Property(u => u.Email)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Survey>(b =>
            {
                b.ToTable("Survey");
                b.HasKey(s => s.SurveyID);
                b.HasOne(s => s.Owner)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Course>(b =>
            {
                b.ToTable("Course");
                b.HasKey(c => c.CourseID);
                b.Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(256);
                b.Property(c => c.Credits)
                .HasDefaultValue(0);
            });
        }
    }
}