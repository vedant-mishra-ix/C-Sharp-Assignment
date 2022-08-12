using GenericRepo_Web_Api.ModelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepo_Web_Api.GenericRepo
{
   public interface IEmployee<T> where T:class
    {
        public IEnumerable<T> GetAllDetails();
        public Task<T> AddEmployee(T obj);
        public T GetById(int id);
        public T Delete(T id);
        public void Update(T obj);
      
    }
}
