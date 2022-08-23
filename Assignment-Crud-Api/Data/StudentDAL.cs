using Assignment_Crud_Api.Entities;
using Assignment_Crud_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Crud_Api.Data
{
    public interface IStudentDal
    {
        IEnumerable<StudentEntity> GetAll();
        Task<StudentEntity> Add(StudentEntity obj);
        StudentEntity GetById(int Id);
        StudentEntity Update(StudentEntity obj, int Id);
        StudentEntity Delete(int Id);
    }
    public class StudentDAL:IStudentDal
    {

        private readonly CoreDbContext StudentDalDbContext;
        public StudentDAL(CoreDbContext _StudentDalDbContext)
        {
            StudentDalDbContext = _StudentDalDbContext;
        }


        public async Task<StudentEntity> Add(StudentEntity CollegeObj)
        {
            var AddData = await StudentDalDbContext.AddAsync(CollegeObj);
            StudentDalDbContext.SaveChanges();
            return AddData.Entity;
        }

        public StudentEntity Delete(int Id)
        {
            var DataDelete = StudentDalDbContext.StudentTable.FirstOrDefault(obj => obj.Id == Id);

            if (DataDelete != null)
            {
                var Data = StudentDalDbContext.StudentTable.Remove(DataDelete);
                StudentDalDbContext.SaveChanges();

                return Data.Entity;
            }
            else
            {
                return null;
            }


            //  return DeleteData.Entity;
        }

        public IEnumerable<StudentEntity> GetAll()
        {
            var AllData = StudentDalDbContext.StudentTable.ToList();
            return AllData;
        }

        public StudentEntity GetById(int Id)
        {
            var IdData = StudentDalDbContext.StudentTable.FirstOrDefault(obj => obj.Id == Id);
            StudentDalDbContext.SaveChanges();
            return IdData;
        }

        public StudentEntity Update(StudentEntity obj, int Id)
        {
            var DataUpdate = StudentDalDbContext.StudentTable.Where(obj => obj.Id == Id).ToList();

            foreach (var UpdateData in DataUpdate)
            {
                if (UpdateData.Id == Id)
                {
                    UpdateData.FirstName = obj.FirstName;
                    UpdateData.LastName = obj.LastName;
                    UpdateData.Email = obj.Email;
                    UpdateData.DateOfBirth = obj.DateOfBirth;
                    UpdateData.Phone = obj.Phone;
                    var Updated = StudentDalDbContext.StudentTable.Update(UpdateData);
                    StudentDalDbContext.SaveChanges();
                    return Updated.Entity;

                }
            }

            return null;
        }
    }
}
