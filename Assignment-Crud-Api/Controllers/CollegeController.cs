using Assignment_Crud_Api.Entities;
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
    public class CollegeController : ControllerBase
    {
        private readonly ICollegeService CollegeService;
        public CollegeController(ICollegeService _CollegeService)
        {
            CollegeService = _CollegeService;
        }

        [HttpGet]
        [Route("View")]
        public IActionResult Get()
        {
             
            return Ok(CollegeService.GetAll());
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddData(CollegeModel obj)
        {
            var AddData = CollegeService.GetAll().Where(obj => obj.Id >= 1).ToList();
            int c = 0;
            foreach(var AddCheck in AddData)
            {
                if(AddCheck.Name == obj.Name)
                {
                    c++;
                    return BadRequest("Name Already Exist");
                }     
            }
            if(c < 1)
            {
                CollegeService.Add(obj);
            }
            return Ok(new Response1 { Succesfull="Data Added Succesfully"});
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            var DataDelete = CollegeService.GetAll().Where(obj => obj.Id == Id).ToList();
            foreach(var DeleteCheck in DataDelete)
            {
                if(DeleteCheck.Id != Id)
                {
                    return BadRequest("Id did not mathced");
                }
            }
            var IdData = CollegeService.GetById(Id);
            return Ok(IdData);
        }
        [HttpPut]
        [Route("Update")]

        public IActionResult Update(CollegeModel obj, int Id)
        {
            var dataGetAll = CollegeService.GetAll().FirstOrDefault(obj => obj.Id == Id);
            if(dataGetAll == null)
            {

                return BadRequest("Data not found");
            }
            else
            {
                CollegeService.Update(obj, Id);
                return Ok(new Response1 { Succesfull="Data updated succesfully"});
            }
        }
             

        [HttpDelete]
        [Route("Delete/{Id}")]

        public IActionResult Delete(int Id)
        {
            var DataDelete = CollegeService.GetAll().FirstOrDefault(obj => obj.Id == Id);
            if (DataDelete == null)
            {
                return BadRequest("Data Not Found");
            }
            else
            {
                CollegeService.Delete(Id);
                return Ok(new Response1 { Succesfull="Data Deleted succesfully"});
            }

          
        }
    }
}
