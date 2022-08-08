using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebApi.Controllers
{
    [ApiController]                 // bina islke swageer open nai hoga
    [Route("Category")]             // it represent this schema
    public class CategoryController : ControllerBase
    {
        [Route("StudentProfile")]

        [HttpPost] // agar ye nai lgaynge to hmko error ayegi swagger mai
        //[Route("StudentProfile")]
        public Student StudentProfile()
        {
            return new Student();
        }
        
        [HttpGet]
        [Route("StudentRecord")]
        public Student StudentRecord()
        {
            return new Student();
        }
    }
}
