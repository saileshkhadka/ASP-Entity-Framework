using StudentInformation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentInformation.Areas.Admin.Controllers
{
    public class StudentInformationController : Controller
    {
        private IstudentInformation _repo = new StudentInformationRepository();
        // GET: Admin/StudentInformation
        public ActionResult Index()
        {
            return View(_repo.GetAll());
        }

        // GET: Admin/StudentInformation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/StudentInformation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/StudentInformation/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/StudentInformation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/StudentInformation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/StudentInformation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/StudentInformation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
