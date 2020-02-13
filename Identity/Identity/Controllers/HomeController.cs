using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "Manager")]
        public IActionResult Index()
        {
            return View((object)"Hello");
        }
    }
}