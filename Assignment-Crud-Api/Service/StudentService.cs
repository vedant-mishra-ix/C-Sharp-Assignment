using Assignment_Crud_Api.Data;
using Assignment_Crud_Api.Entities;
using Assignment_Crud_Api.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Crud_Api.Service
{
    public interface IStudentService
    {
        IEnumerable<StudentModel> GetAll();
        Task<StudentModel> Add(StudentModel obj);
        StudentModel GetById(int Id);
        StudentModel Update(StudentModel obj, int Id);
        StudentModel Delete(int Id);
    }
    public class StudentService:IStudentService
    {
        private readonly IStudentDal Student;
        public StudentService(IStudentDal _Student)
        {
            Student = _Student;
        }

        public async Task<StudentModel> Add(StudentModel StudentModelObj)
        {
            var obj = new StudentEntity
            {

                FirstName = StudentModelObj.FirstName,
                LastName = StudentModelObj.LastName,
                Email = StudentModelObj.Email,
                DateOfBirth = StudentModelObj.DateOfBirth,
                Phone = StudentModelObj.Phone

            };

            var AddData = await Student.Add(obj);

            return new StudentModel { Id = AddData.Id };
        }

        public StudentModel Delete(int Id)
        {

            var DataDel = Student.Delete(Id);
            return new StudentModel { Id = DataDel.Id };

        }

        public IEnumerable<StudentModel> GetAll()
        {
            var dataAll = Student.GetAll();
            return (from studentDetails in dataAll
                    select new StudentModel
                    {
                        Id = studentDetails.Id,
                        FirstName = studentDetails.FirstName,                            // jitni value chaiye utni he value show hogi API mai
                        LastName = studentDetails.LastName,
                        Email = studentDetails.Email,
                        DateOfBirth = studentDetails.DateOfBirth,
                        Phone = studentDetails.Phone

                    }).ToList();
        }

        public StudentModel GetById(int Id)
        {
            var Idata = Student.GetById(Id);

            return (
                    new StudentModel
                    {
                        Id = Idata.Id,
                        FirstName = Idata.FirstName,
                        LastName = Idata.LastName,
                        Email = Idata.Email,
                        DateOfBirth = Idata.DateOfBirth,
                        Phone = Idata.Phone
                    });
        }

        public StudentModel Update(StudentModel obj, int Id)
        {


            var objUpdate = new StudentEntity
            {
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                Email = obj.Email,
                DateOfBirth = obj.DateOfBirth,
                Phone = obj.Phone
            };
            var DataUpdate = Student.Update(objUpdate, Id);
            return new StudentModel { Id = DataUpdate.Id };
        }
    }
}
