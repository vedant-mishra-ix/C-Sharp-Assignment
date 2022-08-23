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
    public class ProductController : ControllerBase
    {
        private readonly IProductService ProductService;
        public ProductController(IProductService _Product)
        {
            ProductService = _Product;
        }

        [HttpGet]
        [Route("View")]
        public IActionResult GetAll()
        {
            return Ok(ProductService.GetAll());
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult AddData(Product obj)
        {
            return Ok(ProductService.Add(obj));
        }
        [HttpGet]
        [Route("View/{Id}")]
        public IActionResult GetById(int Id)
        {
            var DataById = ProductService.GetAll().FirstOrDefault(obj => obj.Id == Id);
            if (DataById == null)
            {
                return BadRequest("Data not found");
            }
            else
            {
                return Ok(ProductService.GetById(Id));
            }
        }
        [HttpPut]
        [Route("Update/{Id}")]
        public IActionResult UpdateData(Product obj)
        {
            var UpdateById = ProductService.GetAll().FirstOrDefault(obj => obj.Id == obj.Id);
            if (UpdateById == null)
            {
                return BadRequest("Data not found");
            }
            else
            {
                return Ok(ProductService.UpdateData(obj));
            }
        }
        [HttpDelete]
        [Route("Delete/{Id}")]
        public IActionResult Delete(int Id)
        {
            var DeleteById = ProductService.GetAll().FirstOrDefault(obj => obj.Id == Id);
            if (DeleteById == null)
            {
                return BadRequest("Data not found");
            }
            else
            {
                return Ok(ProductService.Delete(Id));
            }
        }
    }
}
