using System;
using Microsoft.EntityFrameworkCore;

namespace ComplexExample.Models
{
    public class ExampleContext : DbContext
    {
        public ExampleContext(DbContextOptions<ExampleContext> dbContextOptions):base(dbContextOptions)
        {}

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<OfficeAssignment> OfficeAssignments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                        .HasMany(c => c.Instructors).WithMany(i => i.Courses);
            //.ToTable("CourseInstructor");

            
        }
    }

    
}
