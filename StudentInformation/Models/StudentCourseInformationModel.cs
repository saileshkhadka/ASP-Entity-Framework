using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInformationSystem.Models
{
    public class StudentCourseInformation
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? DueAmount { get; set; }
        
    }
}