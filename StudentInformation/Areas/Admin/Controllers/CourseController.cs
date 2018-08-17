using StudentInformation.Repositories;
using StudentInformation.ViewModel;
using StudentInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentInformation.Areas.Admin.Controllers
{
    public class CourseController : Controller
    {
        private IcoursesRepository _repo = new CoursesRepository();
        // GET: Admin/Course
        public ActionResult Index()
        {
            return View(_repo.GetAll());
        }

        // GET: Admin/Course/Details/5
        public ActionResult Details(int id)
        {
            var getDetails = _repo.GetById(id);
            return View(getDetails);
        }

        // GET: Admin/Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Course/Create
        [HttpPost]
        public ActionResult Create(Course cvm)
        {
            if (ModelState.IsValid)
            {
                Course course = new Course()
                {
                    CourseName = cvm.CourseName,
                    CourseDescription = cvm.CourseDescription,
                    Duration= cvm.Duration,
                    CourseFee=cvm.CourseFee,
                    Status = cvm.Status,
                    
                };
                _repo.Insert(course);
                return RedirectToAction("Index");
            }
            return View(cvm);
        }

        // GET: Admin/Course/Edit/5
        public ActionResult Edit(int id)
        {

            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            Course course = _repo.GetById((int)id);
            if (course == null)
            {
                return RedirectToAction("Index");
            }
            return View(new Course()
            {
                CourseId = course.CourseId,
                CourseName = course.CourseName,
                CourseDescription = course.CourseDescription,
                Duration=course.Duration,
                CourseFee=course.CourseFee,
                Status = course.Status
            });
        }

        // POST: Admin/Course/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Course cvm)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            if (ModelState.IsValid)
            {
                Course course = new Course()
                {
                    CourseId = id,
                    CourseName = cvm.CourseName,
                    CourseDescription = cvm.CourseDescription,
                    CourseFee = cvm.CourseFee,
                    Duration = cvm.Duration,
                    Status=cvm.Status

                };
                _repo.Update(course);
                return RedirectToAction("Index");
            }
            return View(cvm);
        }

        // GET: Admin/Course/Delete/5
        public ActionResult Delete(int Id)
        {
            if (Id == 0)
            {
                return RedirectToAction("Index");
            }
            Course course = _repo.GetById((int)Id);
            if (course == null)
            {
                return RedirectToAction("Index");
            }
            return View(course);
        }

        // POST: Admin/Course/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {

            if (id == 0)
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
    }
}
