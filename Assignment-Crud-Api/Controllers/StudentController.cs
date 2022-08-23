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
            var dataAdd = StudentService.GetAll().FirstOrDefault(obj => obj.Email == obj.Email);
            if(dataAdd != null)
            {
                return BadRequest("Email already exist");
            }
            else
            {
                StudentService.Add(obj);
                return Ok();
            } 
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
            var DataUpdate = StudentService.GetAll().FirstOrDefault(obj => obj.Id == Id);
            if(DataUpdate == null)
            {
                return BadRequest("Data Not Found");
            }
            else
            {
                StudentService.Update(obj, Id);
                return Ok(new Response1 { Succesfull="Data updated succesfully"});
            }
           
        }

        [HttpDelete]
        [Route("Delete/{Id}")]

        public IActionResult Delete(int Id)
        {
            var DataDelete = StudentService.GetAll().FirstOrDefault(obj => obj.Id == Id);
            if (DataDelete == null)
            {
                return BadRequest("Data Not Found");
            }
            else
            {
                StudentService.Delete(Id);
                return Ok(new Response1 { Succesfull = "Data Deleted succesfully" });
            }
            
        }
    }
}
