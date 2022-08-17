using Dependency_Injection_Crud.StudentModel;
using Dependency_Injection_Crud.StudentRepo;
using Dependency_Injection_Crud.StudentService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection_Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        //private readonly IStudent _Student;


        //public StudentController(IStudent Student)
        //{
        //    _Student = Student;
        //}

        StudentRepo1 _Student;
        public StudentController()
        {
            _Student = new StudentRepo1();
        }


        [HttpGet]
        [Route("View")]
        public IActionResult View()
        {
            
            var AllData = _Student.GetAll();
            

            return Ok(AllData);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Student obj)
        {
            var AddData = _Student.Add(obj);

            return Ok(AddData);
        }

        [HttpGet]
        [Route("Get/{id}")]
         public IActionResult GetById(int id)
        {
           
            var DataByID = _Student.GetById(id);

            return Ok(DataByID);

        }

        [HttpPut]
        [Route("Update/{id}")]
        public IActionResult Update(Student obj , int id)
        {
            var UpdateData = _Student.Update(obj, id);
            return Ok(UpdateData);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public bool Delete(int id)
        {
            var UserId = _Student.GetAll().Where(obj => obj.Id == id).ToList();
            int c = 0;
            foreach(var Del in UserId)
            {
                if(Del.Id == id)
                {
                    _Student.Delete(Del);
                    c++;
                    return true;
                }
            }
            if(c < 1)
            {
                return false;
            }
            
            return true;
        }
    }
}
