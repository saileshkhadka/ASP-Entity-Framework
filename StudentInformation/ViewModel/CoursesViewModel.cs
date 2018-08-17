using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentInformation.ViewModel
{
    public class CoursesViewModel
    {
        public int CourseId { get; set; }
       [Required]
       [DisplayName("CourseName")]
        public string CourseName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Description")]
        public string Description { get; set; }
        public decimal CourseFee { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal DueAmount { get; set; }
        public string Duration { get; set; }
        public bool Status { get; set; }

    }
}