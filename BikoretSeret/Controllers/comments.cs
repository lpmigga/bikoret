using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikoretSeret.Controllers
{
    public class comments : Controller
    {
        public IActionResult toComment()
        {
            return View();
        }
    }
}
