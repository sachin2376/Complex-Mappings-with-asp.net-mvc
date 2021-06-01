using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComplexExample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComplexExample.Controllers
{
    public class EnrollmentController : Controller
    {
        private ExampleContext context;

        public EnrollmentController(ExampleContext context)
        {
            this.context = context;
        }

        // GET: Enrollment
        public ActionResult Index()
        {
            return View(context.Enrollments.ToList());
        }

        // GET: Enrollment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Enrollment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Enrollment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Enrollment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Enrollment/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Enrollment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Enrollment/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}