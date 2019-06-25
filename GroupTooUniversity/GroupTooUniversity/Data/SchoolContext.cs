using GroupTooUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupTooUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }
        public DbSet<Person> People { get; set; }
            
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Instructor>().ToTable("Instructor");
            modelBuilder.Entity<OfficeAssignment>().ToTable("OfficeAssignment");
            modelBuilder.Entity<CourseAssignment>().ToTable("CourseAssignment");

            modelBuilder.Entity<Person>(b =>
            {
                b.ToTable("Person");
                b.HasKey(u => u.ID);
                b.Property(u => u.FirstMidName)
                    .IsRequired()
                    .HasMaxLength(50);
                b.Property(u => u.LastName)
                    .IsRequired()
                    .HasMaxLength(50);
                b.Property(u => u.Email)
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Response>(b =>
            {
                b.ToTable("Response");
                b.HasOne(x => x.Question)
                    .WithMany()
                    .IsRequired();
                b.HasKey(x => x.QuestionId);
            });

            modelBuilder.Entity<Survey>(b =>
            {
                b.ToTable("Survey");
                b.HasKey(s => s.SurveyID);
                b.HasOne(s => s.Owner)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CourseAssignment>()
                .HasKey(c => new { c.CourseID, c.InstructorID });
        }
    }
}