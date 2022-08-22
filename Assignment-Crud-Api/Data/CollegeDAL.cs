using Assignment_Crud_Api.Entities;
using Assignment_Crud_Api.Models;
using Assignment_Crud_Api.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Crud_Api.Data_Access_Layer
{
    public interface ICollegeDal
    {
        IEnumerable<CollegeEntity> GetAll();
        Task<CollegeEntity> Add(CollegeEntity obj);
        CollegeEntity GetById(int Id);
        CollegeEntity Update(CollegeEntity obj , int Id);
        CollegeEntity Delete(int Id);

    }
    public class CollegeDAL : ICollegeDal
    {
        private readonly CoreDbContext CollegeDalDbContext;
        public CollegeDAL(CoreDbContext _CollegeDalDbContext)
        {
            CollegeDalDbContext = _CollegeDalDbContext;
        }


        public async Task<CollegeEntity> Add(CollegeEntity CollegeObj)
        {
            var AddData = await CollegeDalDbContext.AddAsync(CollegeObj);
            CollegeDalDbContext.SaveChanges();
            return AddData.Entity;
        }

        public CollegeEntity Delete(int Id)
        {
            var DataDelete = CollegeDalDbContext.CollegeTable.FirstOrDefault(obj => obj.Id == Id);
            
                if(DataDelete != null)
                {
                    var Data = CollegeDalDbContext.CollegeTable.Remove(DataDelete);
                    CollegeDalDbContext.SaveChanges();
                  
                    return Data.Entity;
                }
                else
            {
                return null;
            }
           
           
          //  return DeleteData.Entity;
        }

        public IEnumerable<CollegeEntity> GetAll()
        {
            var AllData = CollegeDalDbContext.CollegeTable.ToList();
            return AllData;
        }

        public CollegeEntity GetById(int Id)
        {
            var IdData = CollegeDalDbContext.CollegeTable.FirstOrDefault(obj => obj.Id == Id);
            CollegeDalDbContext.SaveChanges();
            return IdData;
        }

        public  CollegeEntity Update(CollegeEntity obj , int Id)
        {
            var DataUpdate = CollegeDalDbContext.CollegeTable.Where(obj => obj.Id == Id).ToList();
            
            foreach(var UpdateData in DataUpdate)
            {
                if(UpdateData.Id == Id)
                {
                    UpdateData.Name = obj.Name;
                    UpdateData.University = obj.University;
                    UpdateData.Address = obj.Address;
                    UpdateData.District = obj.District;
                    var Updated  = CollegeDalDbContext.CollegeTable.Update(UpdateData);
                    CollegeDalDbContext.SaveChanges();
                    return Updated.Entity;
                     
                }
            }

            return obj;
        }

        
    }
}
