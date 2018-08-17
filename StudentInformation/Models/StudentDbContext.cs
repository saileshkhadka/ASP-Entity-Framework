using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentInformationSystem.Models
{
    public class StudentDbContext:DbContext
    {
        public DbSet<Course>Courses { get; set; }
        public DbSet<Student>Students { get; set; }
        public DbSet<StudentCourseInformation>CoursesInformation { get; set; }
    }
}