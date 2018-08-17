using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInformationSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long  ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DOB { get; set; }
    }
}