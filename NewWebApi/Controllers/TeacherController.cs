using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebApi.Controllers
{
    [ApiController]
    [Route("Teacher")]
    public class TeacherController : Controller
    {
        [HttpGet]       // bina iske error ayegi
        [Route("Profile")]
        public Teacher Profile()
        {
            return new Teacher() { Name="Pankaj",Address="Latur"};
        }
        [HttpPost]
        [Route("Record")]
        public Teacher ProfileEdit()
        {
            return new Teacher();
        }
    }
}
