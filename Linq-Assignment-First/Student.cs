using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment_First
{
    class Student
    {
        public int Id;
        public string Name;
        public string Email;
        public string City;

        public List<Student> SetData(List<Student> DataList)
        {
            return DataList.Where(obj => obj.Name.StartsWith("v")).ToList();   
        }
        public void GetData(List<Student> value)
        {
            Console.WriteLine("------------------------------------------- GetData() Method -------------------------------------------");
            foreach(Student ob in  this.SetData(value))
            {
                Console.WriteLine(ob.Id+"   "+ob.Name+"   "+ob.Email+"   "+ob.City);
            }
        }
        public static List<Student>  GetID(List<Student> IdList)
        {
            return IdList.Where(obj => obj.Id >= 10).ToList();
        }
        
    }
    class Marks
    {
        public int Id;
      //  public string Student_Name;
        public int Physics;
        public int Chemistry;
        public int Math;
    }

    class Marksheet
    {
        public int ID;
        public string Student_name;
        public int Physics;
        public int Chemistry;
        public int Math;
        public int Total;
    }
}
