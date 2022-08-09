using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllerAssignment.Controllers
{
    public class CaseStoriesController : Controller
    {
        public IActionResult CaseStories()
        {
            return View();
        }
    }
}
