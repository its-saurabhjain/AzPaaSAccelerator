using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppServiceMigrator.Controllers
{
    public class MonitorController : Controller
    {
        // GET: Monitor
        public ActionResult AppMonitor()
        {
            return View();
        }

        // GET: Monitor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Monitor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Monitor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(AppMonitor));
            }
            catch
            {
                return View();
            }
        }

        // GET: Monitor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Monitor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(AppMonitor));
            }
            catch
            {
                return View();
            }
        }

        // GET: Monitor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Monitor/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(AppMonitor));
            }
            catch
            {
                return View();
            }
        }
    }
}