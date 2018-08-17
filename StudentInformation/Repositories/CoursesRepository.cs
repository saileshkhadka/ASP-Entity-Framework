using StudentInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInformation.Repositories
{
    public interface IcoursesRepository:IGenericRepository<Course>
    {

    }
    public class CoursesRepository : IcoursesRepository
    {
        private StudentDbContext db = new StudentDbContext();
        public int Delete(int Id)
        {
            Course course = GetById(Id);
            if (course != null)
            {
                db.Courses.Remove(course);
                return db.SaveChanges();
            }
            return 0;
        }

        public List<Course> GetAll()
        {
            return db.Courses.ToList();
        }

        public Course GetById(int Id)
        {
            return db.Courses.Find(Id);
        }

        public int Insert(Course course)
        {
            db.Courses.Add(course);
            return db.SaveChanges();
        }

        public List<Course> Search(string param)
        {
            var courses = from catlist in db.Courses
                             where catlist.CourseName.Contains(param)
                             select catlist;
            return courses.ToList();
        }

        public int Update(Course course)
        {
            db.Entry(course).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}