using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentInformation.ViewModel
{
    public class StudentCourseInformationViewModel
    {
        public int StudentId { get; set; }
        [Required]
        [DisplayName("FirstName")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("LastName")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Address")]
        public string Address { get; set; }
        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public int CourseId { get; set; }
        [Required]
        [DisplayName("CourseName")]
        public string CourseName { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        public decimal? TotalFee { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? DueAmount { get; set; }
        public DateTime? Duration { get; set; }
        public bool Status { get; set; }

    }
}