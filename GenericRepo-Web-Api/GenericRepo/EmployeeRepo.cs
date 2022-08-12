using GenericRepo_Web_Api.ModelData;
using GenericRepo_Web_Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepo_Web_Api.GenericRepo
{
    public class EmployeeRepo<T> : IEmployee<T> where T : class
    {
        private readonly CoreDbContext _Dbcontext;
        private readonly DbSet<T> _Entities;

        public EmployeeRepo(CoreDbContext Context)
        {
            _Dbcontext = Context;
            _Entities = _Dbcontext.Set<T>();
        }

        public async  Task<T> AddEmployee(T obj)
        {
            var dataInsert = await _Entities.AddAsync(obj);
            _Dbcontext.SaveChanges();
             
            return  dataInsert.Entity;
        }

        public T Delete(T obj)
        {
            var DataDelete = _Entities.Remove(obj);
            _Dbcontext.SaveChanges();
            return DataDelete.Entity;
        }

        public IEnumerable<T> GetAllDetails()
        {
            return _Entities;
        }

        public T GetById(int id)
        {
            var GetId = _Entities.Find(id);
            return GetId;
        }

        public void Update(T obj)
        {
             _Entities.Update(obj);
            _Dbcontext.SaveChanges();
           // return dataUPdate.Entity;
           
        }
    }
}
