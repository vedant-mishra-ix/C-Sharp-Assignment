using Assignment_Crud_Api.EntityModels;
using Assignment_Crud_Api.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Crud_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService StudentService;
        public StudentController(IStudentService _StudentService)
        {
            StudentService = _StudentService;
        }

        [HttpGet]
        [Route("View")]
        public IActionResult Get()
        {
            return Ok(StudentService.GetAll());
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddData(StudentModel obj)
        {
            return Ok(StudentService.Add(obj));
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            var IdData = StudentService.GetById(Id);
            return Ok(IdData);
        }
        [HttpPut]
        [Route("Update/{Id}")]

        public IActionResult Update(StudentModel obj, int Id)
        {
            return Ok(StudentService.Update(obj, Id));
        }

        [HttpDelete]
        [Route("Delete/{Id}")]

        public IActionResult Delete(int Id)
        {
            return Ok(StudentService.Delete(Id));
        }
    }
}
