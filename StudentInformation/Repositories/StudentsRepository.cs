using StudentInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInformation.Repositories
{
    public interface IstudentsRepository:IGenericRepository<Student>
    {

    }
    public class StudentsRepository : IstudentsRepository
    {
        private StudentDbContext db = new StudentDbContext();
        public int Delete(int Id)
        {
            Student student = GetById(Id);
            if (student != null)
            {
                db.Students.Remove(student);
                return db.SaveChanges();
            }
            return 0;
        }

        public List<Student> GetAll()
        {
            return db.Students.ToList();
        }

        public Student GetById(int Id)
        {
            return db.Students.Find(Id);
        }

        public int Insert(Student student)
        {
            db.Students.Add(student);
            return db.SaveChanges();
        }

        public List<Student> Search(string param)
        {
            var students = from catlist in db.Students
                             where catlist.FirstName.Contains(param)
                             select catlist;
            return students.ToList();

        }

        public int Update(Student student)
        {
            db.Entry(student).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}