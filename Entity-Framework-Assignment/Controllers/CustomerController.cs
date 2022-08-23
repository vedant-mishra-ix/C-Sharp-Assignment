using Entity_Framework_Assignment.Entity;
using Entity_Framework_Assignment.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Framework_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService Customer;
        public CustomerController(ICustomerService _Customer)
        {
            Customer = _Customer;
        }

        [HttpGet]
        [Route("View")]
        public IActionResult GetAll()
        {
            return Ok(Customer.GetAll());
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult AddData(Customer obj)
        {
            return Ok(Customer.Add(obj));
        }
        [HttpGet]
        [Route("View/{Id}")]
        public IActionResult GetById(int Id)
        {
            var DataById = Customer.GetAll().FirstOrDefault(obj => obj.Id == Id);
            if(DataById == null)
            {
                return BadRequest("Data not found");
            }
            else
            {
                return Ok(Customer.GetById(Id));
            }
        }
        [HttpPut]
        [Route("Update/{Id}")]
        public IActionResult UpdateData(Customer obj)
        {
            var UpdateById = Customer.GetAll().FirstOrDefault(obj => obj.Id == obj.Id);
            if (UpdateById == null)
            {
                return BadRequest("Data not found");
            }
            else
            {
                return Ok(Customer.UpdateData(obj));
            }
        }
        [HttpDelete]
        [Route("Delete/{Id}")]
        public IActionResult Delete(int Id)
        {
            var DeleteById = Customer.GetAll().FirstOrDefault(obj => obj.Id == Id);
            if (DeleteById == null)
            {
                return BadRequest("Data not found");
            }
            else
            {
                return Ok(Customer.Delete(Id)) ;
            }
        }

    }
}
