using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppServiceMigrator.Controllers
{
    public class AzTemplateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}