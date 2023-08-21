using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace PlacecomBackend.Models
{
     public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<University> Universities { get; set; }

        // Add other DbSet properties for your entities

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entities, relationships, and constraints here

            modelBuilder.Entity<Student>().HasKey(s => s.Id);
            modelBuilder.Entity<Student>().Property(s => s.FirstName).IsRequired();
            modelBuilder.Entity<Student>().Property(s => s.LastName).IsRequired();
            modelBuilder.Entity<Student>().Property(s => s.DateOfBirth).IsRequired();
            modelBuilder.Entity<Student>().Property(s => s.Email).IsRequired();
            modelBuilder.Entity<Student>().Property(s => s.PhoneNumber);
            modelBuilder.Entity<Student>().Property(s => s.Major);
            modelBuilder.Entity<Student>().Property(s => s.WorkExperience);

            modelBuilder.Entity<Course>().HasKey(c => c.CourseId);
            modelBuilder.Entity<Course>().Property(c => c.Name).IsRequired();
            modelBuilder.Entity<Course>().Property(c => c.Description);
            modelBuilder.Entity<Course>().Property(c => c.Instructor);
            modelBuilder.Entity<Course>().Property(c => c.StartDate).IsRequired();
            modelBuilder.Entity<Course>().Property(c => c.EndDate).IsRequired();

            modelBuilder.Entity<Company>().HasKey(c => c.Id);
            modelBuilder.Entity<Company>().Property(c => c.Name).IsRequired();
            modelBuilder.Entity<Company>().Property(c => c.Industry);
            modelBuilder.Entity<Company>().Property(c => c.Location);
            modelBuilder.Entity<Company>().Property(c => c.Website);

            modelBuilder.Entity<JobApplication>().HasKey(j => j.Id);
            modelBuilder.Entity<JobApplication>().Property(j => j.StudentId).IsRequired();
            modelBuilder.Entity<JobApplication>().Property(j => j.CompanyId).IsRequired();
            modelBuilder.Entity<JobApplication>().Property(j => j.ApplicationDate).IsRequired();
            modelBuilder.Entity<JobApplication>().Property(j => j.IsApproved);
            modelBuilder.Entity<JobApplication>().Property(j => j.CoverLetter);
            modelBuilder.Entity<JobApplication>()
                .HasOne(j => j.Course)
                .WithMany()
                .HasForeignKey(j => j.CourseId);
            modelBuilder.Entity<JobApplication>()
                .Property(j => j.Position).IsRequired();
                
            modelBuilder.Entity<JobApplication>()
                .Property(j => j.RequiredWorkExperience).IsRequired();

            modelBuilder.Entity<University>().HasKey(u => u.Id);
            modelBuilder.Entity<University>().Property(u => u.Name).IsRequired();
            modelBuilder.Entity<University>().Property(u => u.Location);
            modelBuilder.Entity<University>().Property(u => u.EstablishedYear);
            modelBuilder.Entity<University>().Property(u => u.Website);

            // Define relationships here
            modelBuilder.Entity<Student>()
                .HasMany(s => s.EnrolledCourses)
                .WithMany(c => c.EnrolledStudents)
                .UsingEntity(j => j.ToTable("StudentCourses"));

            modelBuilder.Entity<Student>()
                .HasMany(s => s.JobApplications)
                .WithOne(j => j.Student)
                .HasForeignKey(j => j.StudentId);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Universities)
                .WithMany(u => u.EnrolledStudents)
                .UsingEntity(j => j.ToTable("StudentUniversities"));

            modelBuilder.Entity<JobApplication>()
                .HasOne(j => j.Company)
                .WithMany(c => c.JobApplications)
                .HasForeignKey(j => j.CompanyId);

            // ... configure other relationships

            base.OnModelCreating(modelBuilder);
        }
    }
}
