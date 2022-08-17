using Dependency_Injection_Crud.StudentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection_Crud.StudentRepo
{
   public interface IStudent
    {
        public IEnumerable<Student> GetAll();
        public Student GetById(int id);
        public Task<Student> Add(Student obj);
        public bool Update(Student obj , int id);
        public Student Delete(Student obj);

    }
}
