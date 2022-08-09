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
            Student val1 = new Student();
            val1.Message = " done";
            string  msg = val1.Message;
            if(msg == null)
            {
                return new Student();
            }
            else
            {
                return new Student() { Id=10,Message= msg};
            }
        }
        
        [HttpGet]
        [Route("StudentRecord")]
        public Student StudentRecord()
        {
            Student val = new Student();


            if (this.StudentProfile() == null)
            {
                return new Student();
            }
            else
            {
                return this.StudentProfile();
            }
            
        }
        [HttpGet]
        [Route("View")]
        public string  View()
        {
            return "Hi";
        }

        
    }
}
