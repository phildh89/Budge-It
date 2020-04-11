using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgeIt.Controllers
{
    public class CheckingsController : Controller
    {
        // GET: Checkings
        public ActionResult Index()
        {
            return View();
        }

        // GET: Checkings/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Checkings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Checkings/Create
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

        // GET: Checkings/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Checkings/Edit/5
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

        // GET: Checkings/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Checkings/Delete/5
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