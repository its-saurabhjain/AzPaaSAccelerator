using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppServiceMigrator.Controllers
{
    public class TemplateController : Controller
    {
        public IActionResult Tier1Configuration()
        {
            return View();
        }
        public IActionResult Tier2Configuration()
        {
            return View();
        }
        public IActionResult Tier3Configuration()
        {
            return View();
        }
        public IActionResult Tier4Configuration()
        {
            return View();
        }
        public IActionResult Tier5Configuration()
        {
            return View();
        }
        public IActionResult TemplateReview()
        {
            return View();
        }
    }
}