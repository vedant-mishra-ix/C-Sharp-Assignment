using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Crud_Api.EntityModels
{
    public class CollegeModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string University { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string District { get; set; }
    }
}
