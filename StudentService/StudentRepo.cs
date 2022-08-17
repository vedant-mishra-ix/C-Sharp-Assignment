using Dependency_Injection_Crud.Controllers;
using Dependency_Injection_Crud.Models;
using Dependency_Injection_Crud.StudentModel;
using Dependency_Injection_Crud.StudentRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection_Crud.StudentService
{
    public class StudentRepo1 : IStudent
    {
        private readonly CoreDbContext _DbContext;
        private readonly DbSet<Student> _DbSet;

        public StudentRepo1()
        {
            _DbContext = new CoreDbContext();       // without Dependency Injection
        }

        //public StudentRepo1(CoreDbContext Context)
        //{
        //  //  _DbContext = Context;                       // with Dependency Injection
        //   // _DbSet = _DbContext.Set<Student>();
        //}

        public async Task<Student> Add(Student obj)
        {
            var AddData = await _DbContext._DbSet.AddAsync(obj);
            _DbContext.SaveChanges();
            return AddData.Entity ;
        }

        public  Student Delete(Student obj)
        {
            var DataDelete = _DbContext._DbSet.Remove(obj);
            _DbContext.SaveChanges();
            return DataDelete.Entity;
        }

        public IEnumerable<Student> GetAll()
        {
            return _DbContext._DbSet;
        }

        public  Student GetById(int id)
        {
            var DataById = _DbContext._DbSet.Find(id);
            return DataById;
        }

        public bool Update(Student obj, int id)
        {
            var DataUpdate = _DbContext._DbSet.Where(obj => obj.Id == id).ToList();
            int c = 0;
            foreach(var UpdateData in DataUpdate)
            {
                if(UpdateData.Id == id)
                {
                    UpdateData.Fullname = obj.Fullname;
                    UpdateData.Email = obj.Email;
                    UpdateData.Address = obj.Address;

                    _DbContext._DbSet.Update(UpdateData);
                    _DbContext.SaveChanges();
                    
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
