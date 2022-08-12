using GenericRepo_Web_Api.GenericRepo;
using GenericRepo_Web_Api.ModelData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepo_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee1Controller : ControllerBase
    {
        private readonly IEmployee<Employee> _Employee;

        public Employee1Controller(IEmployee<Employee> Employee)
        {
            _Employee = Employee;
        }
        [HttpGet]
        public IActionResult GettAll()
        {
            var result = _Employee.GetAllDetails();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Add(Employee emp)
        {

            var resultdata = _Employee.AddEmployee(emp);
            return Ok(resultdata);
        }
        [HttpGet]
        [Route("Id")]
        public IActionResult GetId(int id)
        {
            var ID = _Employee.GetById(id);
            return Ok(ID);
        }
        [HttpDelete]
        [Route("Delete")]
        public bool Delete(int id)
        {
            int c = 0;
             var dataDelete = _Employee.GetAllDetails().Where(obj => obj.Id == id).ToList();
            foreach(var dataDal in dataDelete)
            {
                if (dataDal.Id == id)
                {
                    _Employee.Delete(dataDal);
                    c++;
                    return true;
                }             
            }
            return true;
        }

        [HttpPut]
        [Route("Update")]
        public bool Update(Employee emp , int id)
        {
            int c = 0;
            var DataUpdate = _Employee.GetAllDetails().Where(obj => obj.Id == id).ToList();
            foreach(var UpdateData in DataUpdate)
            {
                if (UpdateData.Id == id)
                {

                    UpdateData.FullName = emp.FullName;
                    UpdateData.Address = emp.Address;
                    UpdateData.Age = emp.Age;


                    // Employee ob = (new Employee();
                    _Employee.Update(UpdateData);
                    //return true;
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
