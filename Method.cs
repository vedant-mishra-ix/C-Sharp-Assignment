using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayMethod
{
    class Method
    {
       
        //------------------------------------------------------ Non-Genric Class ------------------------------------------------------
        //------------------------------------------------------- ArrayList Method-------------------------------------------------------

        //public ArrayList Display(ArrayList arrStore)
        //{
        //    Console.WriteLine("\nDispaly method Through iterate\n");
        //    foreach(string storeArray in arrStore)
        //    {
        //        Console.WriteLine(storeArray);
        //    }
        //    return arrStore;
        //}

        public ArrayList DisplayData(ArrayList arrStore)
        {
            Console.WriteLine("\nDispaly Data Through  method\n");
            return arrStore;
        }
        public ArrayList SortData(ArrayList arrStore)
        {
            arrStore.Sort();

            Console.WriteLine("\nSort Data Through  method\n");
            return arrStore;
        }

        //--------------------------------------------------- Generic Class --------------------------------------------------------------
        // -------------------------------------------------- List<t>----------------------------------------------------------------------

        public List<string> DisplayList(List<string> arrStore)
        {
            Console.WriteLine("\n Display List<> data through method:\n");
            foreach(string store in arrStore)
            {
                Console.WriteLine(store);
                
            }
            return arrStore;
        }

        public List<string> SortList(List<string> arrStore)
        {
            Console.WriteLine("\n Sorted List<> data through method:\n");
            arrStore.Sort();
            foreach (string store in arrStore)
            {
                Console.WriteLine(store);

            }
            return arrStore;
        }

        // ----------------------------------------- SortedList<>--------------------------------------------------
         public SortedList<int,string> DisplaySortedList(SortedList<int,string> arrStore)
        {
            Console.WriteLine("Display SortedList<> Data:\n");
            foreach(KeyValuePair<int,string> sort in arrStore)
            {
                Console.WriteLine(sort);
            }
            return arrStore;
        }

        public SortedList<int, string> SortSortedList(SortedList<int, string> arrStore)
        {
            Console.WriteLine("Sort() SortedList<> Data:\n");
            
            foreach (string sort in arrStore.Values)
            {
                Console.WriteLine(sort);
            }
            return arrStore;
        }

        // ------------------------------------ Store class data into List<> -------------------------------------

        public int id = 1;
        public string name = "vedant";
        public string email = "vedant@gmail.com";
        public int mobile = 1234;

        SortedList<string, string> arrayStore = new SortedList<string, string>(); 
        public void AddRecord(string key , string value)
        {
            arrayStore.Add(key,value);
        }
        public void RetriveRecord()
        {
            foreach (KeyValuePair<string, string> store in arrayStore)
            {
                Console.WriteLine(store);

            }
           
        }


        //------------------------------------------- Another Way Add Class Data into List ----------------------------------
        

        public int Sr_no { get; set;}
        public string FullName { get; set; }
        public string Gender { get; set; }

        public static List<Method> GetProfileData()
        {
            List<Method> Listadd = new List<Method>();

            Method obj = new Method() {Sr_no = 100, FullName = "gogeta", Gender = "male" };
            Listadd.Add(obj);

            Method obj1 = new Method() { Sr_no = 101, FullName = "kakarot", Gender = "male" };
            Listadd.Add(obj1);

            Method obj2 = new Method() { Sr_no = 102, FullName = "bulma", Gender = "female" };
            Listadd.Add(obj2);
            GetData(Listadd);
            return Listadd;
            
        }

        public static void GetData(List<Method> store)
        {
            foreach(Method storeData in store)
            {
                Console.WriteLine(storeData.Sr_no+" : "+ storeData.FullName+" : "+ storeData.Gender);
            }
        }
    }
}
