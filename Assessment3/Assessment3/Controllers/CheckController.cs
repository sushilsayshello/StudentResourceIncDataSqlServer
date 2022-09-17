using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assessment3.Controllers
{
    public class CheckController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}