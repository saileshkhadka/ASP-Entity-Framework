using StudentInformation.Repositories;
using StudentInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentInformation.Areas.Admin.Controllers
{ 
    public class StudentController : Controller
    {
        private IstudentsRepository _repo = new StudentsRepository();
        // GET: Admin/Student
        public ActionResult Index()
        {

            return View(_repo.GetAll());
        }

        // GET: Admin/Student/Details/5
        public ActionResult Details(int id)
        {
            var getDetails = _repo.GetById(id);
            return View(getDetails);
        }

        // GET: Admin/Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Student/Create
        [HttpPost]
        public ActionResult Create(Student cvm)
        {
            if (ModelState.IsValid)
            {
                Student student = new Student()
                {
                    FirstName= cvm.FirstName,
                    LastName=cvm.LastName,
                    Address=cvm.Address,
                    ContactNumber=cvm.ContactNumber,
                    EmailAddress=cvm.EmailAddress,
                    DOB=cvm.DOB

                };
                _repo.Insert(student);
                return RedirectToAction("Index");
            }
            return View(cvm);
        }

        // GET: Admin/Student/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            Student student = _repo.GetById((int)id);
            if (student == null)
            {
                return RedirectToAction("Index");
            }
            return View(new Student()
            {
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Address=student.Address,
                ContactNumber=student.ContactNumber,
                EmailAddress=student.EmailAddress,
                DOB=student.DOB
            });

        }

        // POST: Admin/Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Student cvm)
        {
            if (id==0)
            {
                return RedirectToAction("Index");
            }
            if (ModelState.IsValid)
            {
                Student student = new Student()
                {
                    StudentId=id,
                    FirstName = cvm.FirstName,
                    LastName = cvm.LastName,
                    Address = cvm.Address,
                    ContactNumber = cvm.ContactNumber,
                    EmailAddress = cvm.EmailAddress,
                    DOB = cvm.DOB

                };
                _repo.Update(student);
                return RedirectToAction("Index");
            }
            return View(cvm);
        }

        // GET: Admin/Student/Delete/5
        public ActionResult Delete(int id)
        {
            if (id==0 )
            {
                return RedirectToAction("Index");
            }
            if (ModelState.IsValid)
            {
                _repo.Delete(id);
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        // POST: Admin/Student/Delete/5
       
    }
}
