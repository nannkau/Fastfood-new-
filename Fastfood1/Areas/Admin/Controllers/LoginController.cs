using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fastfood1.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {   
        [Area ("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}