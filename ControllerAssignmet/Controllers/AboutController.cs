using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllerAssignment.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            //  return PartialView();   // isko  use krne  se ab out ka page same page mai render nai hoga ek new page mai render hota hai
               return View();
        }
    }
}
