using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodNewsProject.Controllers
{
    public class SourceController : Controller
    {
        public IActionResult Source()
        {
            return View();
        }
    }
}
