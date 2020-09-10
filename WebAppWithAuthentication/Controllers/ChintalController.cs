using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppWithAuthentication.Controllers
{
    public class ChintalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Specific()
        {
            return View();
        }
    }
}
