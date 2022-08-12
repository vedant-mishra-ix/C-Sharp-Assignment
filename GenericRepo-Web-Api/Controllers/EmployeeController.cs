//using GenericRepo_Web_Api.GenericRepo;
//using GenericRepo_Web_Api.ModelData;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace GenericRepo_Web_Api.Controllers
//{
//    public class EmployeeController : Controller
//    {

//        private readonly IEmployee<Employee> _Employee;
        
        
        
//        public EmployeeController(IEmployee<Employee> employee)
//        {
//            _Employee = employee;
//        }
//        [Route("Employee")]
//        [HttpPost]
//        public IActionResult Employee()
//        {
//            var Store = _Employee.GetAllDetails();
//            return View(Store);
//        }
//    }
//}
