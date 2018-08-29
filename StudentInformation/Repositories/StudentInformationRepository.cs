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
            //        var lines =
            //from tl in db.TimeSheetLines
            //join j in db.Jobs on tl.JobNo equals j.JobNo into tl_j
            //where tl.ResourceNo == resourceNo

            //from j in tl_j.DefaultIfEmpty()
            //select new
            //{
            //    EntryDate = tl.EntryDate,
            //    Hours = tl.Hours,
            //    Job = j.JobName



            //        var lines =
            //from tl in db.TimeSheetLines
            //join j in db.Jobs on tl.JobNo equals j.JobNo into tl_j
            //join i in db.Indirects on tl.IndirectCode equals i.IndirectCode into tl_i
            //where tl.ResourceNo == resourceNo

            //from j in tl_j.DefaultIfEmpty()
            //from i in tl_i.DefaultIfEmpty()
            //select new
            //{
            //    EntryDate = tl.EntryDate,
            //    Hours = tl.Hours,
            //    Job = j.JobName,
            //    Indirect = i.IndirectName,
            //};
            var result = from s in db.StudentCourseInformation
                         join b in db.Students on s.StudentId equals b.StudentId into sb
                         join c in db.Courses on s.CourseId equals c.CourseId into sc

                         from a1 in sb.DefaultIfEmpty()
                         from a2 in sc.DefaultIfEmpty()


                         select new StudentCourseInformationViewModel
                         {
                             FirstName = a1.FirstName,
                             LastName = a1.LastName,
                             Address = a1.Address,
                             Email = a1.EmailAddress,
                             CourseName = a2.CourseName,
                             TotalFee = a2.CourseFee,
                             AmountPaid = s.PaidAmount,
                             DueAmount = s.DueAmount,
                             DOB = a1.DOB.ToString(),
                             Description = a2.CourseDescription
                         };
            return result.ToList();
        }
       





    }
}