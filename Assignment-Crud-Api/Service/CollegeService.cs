using Assignment_Crud_Api.Data_Access_Layer;
using Assignment_Crud_Api.Entities;
using Assignment_Crud_Api.EntityModels;
using Assignment_Crud_Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Crud_Api.Service
{
    public interface ICollegeService
    {
         IEnumerable<CollegeModel> GetAll();
        Task<CollegeModel> Add(CollegeModel obj);
        CollegeModel GetById(int Id);
        CollegeModel Update(CollegeModel obj, int Id);
        CollegeModel Delete( int Id);
    }
    public class CollegeService : ICollegeService
    {
      
        private readonly ICollegeDal College;
        public CollegeService(ICollegeDal _College)
        {
            College = _College;

        }

        public async Task<CollegeModel> Add(CollegeModel CollegeModelObj)
        {
            var obj = new CollegeEntity
            {
                
                Name = CollegeModelObj.Name,
                University = CollegeModelObj.University,
                Address = CollegeModelObj.Address,
                District = CollegeModelObj.District

            };

            var AddData = await College.Add(obj);  
            
            return new CollegeModel { Id= AddData.Id };
        }

        public CollegeModel Delete(int Id)
        {
           // var dataDelete = College.GetAll().FirstOrDefault(obj => obj.Id == Id);
            var DataDel = College.Delete(Id);  
            return new CollegeModel { Id = DataDel.Id};
            
        }

        public IEnumerable<CollegeModel> GetAll()
        {
            var dataAll = College.GetAll();
            return (from collegeDetails in dataAll
                    select new CollegeModel
                    {
                        Id = collegeDetails.Id,
                       Name = collegeDetails.Name,                            // jitni value chaiye utni he value show hogi API mai
                       University = collegeDetails.University,
                       Address = collegeDetails.Address

                    }).ToList();
        }

        public CollegeModel GetById(int Id)
        {
            var Idata = College.GetById(Id) ;

            return (
                    new CollegeModel
                    {
                        Id = Idata.Id,
                        Name = Idata.Name,
                        University = Idata.University,
                        Address = Idata.Address,
                        District = Idata.District
                    });
        }

        public CollegeModel Update(CollegeModel obj, int Id)
        {
            

            var objUpdate = new CollegeEntity
            {
                Name = obj.Name,
                University = obj.University,
                Address = obj.Address,
                District = obj.District
            };
            var DataUpdate = College.Update(objUpdate,Id);
            return new CollegeModel { Id = DataUpdate.Id};
        }
    }
}
