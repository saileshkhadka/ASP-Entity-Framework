using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInformationSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public decimal CourseFee { get; set; }
        public string Duration { get; set; }
        public bool Status { get; set; }
    }
}