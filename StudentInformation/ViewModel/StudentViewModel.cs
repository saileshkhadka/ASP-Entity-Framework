using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentInformation.ViewModel
{
    public class StudentViewModel
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
    }
}