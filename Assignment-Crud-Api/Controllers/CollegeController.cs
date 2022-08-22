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
            return Ok(CollegeService.Add(obj));
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            var IdData = CollegeService.GetById(Id);
            return Ok(IdData);
        }
        [HttpPut]
        [Route("Update/{Id}")]

        public IActionResult Update(CollegeModel obj, int Id)
        {
            return Ok(CollegeService.Update(obj,Id));
        }

        [HttpDelete]
        [Route("Delete/{Id}")]

        public IActionResult Delete(int Id)
        {
            return Ok(CollegeService.Delete(Id));
        }
    }
}
