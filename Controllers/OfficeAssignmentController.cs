using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComplexExample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComplexExample.Controllers
{
    public class OfficeAssignmentController : Controller
    {
        private ExampleContext context;

        public OfficeAssignmentController(ExampleContext context)
        {
            this.context = context;
        }


        // GET: OfficeAssignment
        public ActionResult Index()
        {
            return View(context.OfficeAssignments.ToList());
        }

        // GET: OfficeAssignment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OfficeAssignment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OfficeAssignment/Create
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

        // GET: OfficeAssignment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OfficeAssignment/Edit/5
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

        // GET: OfficeAssignment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OfficeAssignment/Delete/5
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