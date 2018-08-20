using StudentInformation.Repositories;
using StudentInformation.ViewModel;
using StudentInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInformation.Repositories
{
    public interface IstudentInformation
    {
        List<StudentCourseInformationViewModel> GetAll();
    }
    public class StudentInformationRepository :IstudentInformation
    {
        private StudentDbContext db = new StudentDbContext();

        public List<StudentCourseInformationViewModel> GetAll()
        {
            var result = from s in db.Students
                         join b in db.StudentCourseInformation on s.StudentId equals b.StudentId
                         join c in db.Courses on b.CourseId equals c.CourseId
                         select new StudentCourseInformationViewModel
                         {
                             FirstName = s.FirstName,
                             LastName = s.LastName,
                             Address = s.Address,
                             Email = s.EmailAddress,
                             CourseName = c.CourseName,
                             TotalFee = c.CourseFee,
                             AmountPaid = b.PaidAmount,
                             DueAmount = b.DueAmount
                         };
            return result.ToList();
        }
       





    }
}