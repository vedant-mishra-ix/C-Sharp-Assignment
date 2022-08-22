using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Linq_Assignment_First
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { Id = 10, Name = "vedant", Email = "ved@gmail.com", City = "kanpur" };
            Student student1 = new Student() { Id = 30, Name = "abhishek", Email = "abhi@gmail.com", City = "ranchi" };
            Student student2 = new Student() { Id = 20, Name = "tuti", Email = "tuti@gmail.com", City = "latur" };
            Student student3 = new Student() { Id = 40, Name = "pindari", Email = "pin@gmail.com", City = "pune" };
            Student student4 = new Student() { Id = 40, Name = "pindari", Email = "pin@gmail.com", City = "pune" };

            List<Student> studentList = new List<Student>();
            studentList.Add(student);
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
            studentList.Add(student4);

            var StoreId = Student.GetID(studentList);

            List<Student> SecondList = new List<Student>();

            Console.WriteLine("------------------------------ Normal List Data ----------------------------------------");

            //for(int i = 0; i < studentList.Count; i++)
            //{
            //    //if (studentList[i].Id >= 10)
            //    //{
            //    //    Console.WriteLine(studentList[i].Id+"  "+ studentList[i].Name+"  "+ studentList[i].Email+"  "+ studentList[i].City);
            //    //    SecondList.Add(studentList[i]);
            //    //}
            //  //  char[] character = studentList[i].Name.ToCharArray();

            //    Console.WriteLine("--------------------------------- ID Data sort ----------------------------------------");

            //    for(int j = i+1 ; j < studentList.Count; j++)
            //    {
            //        int temp = 0;
            //        if(studentList[i].Id > studentList[j].Id)
            //        {
            //            temp = studentList[i].Id ;
            //            studentList[i].Id = studentList[j].Id;
            //            studentList[j].Id = temp; 
            //         //   Console.WriteLine("Sorted Data:  "+ studentList[i].Id);
            //        }

            //        if(studentList[i].Name.CompareTo(studentList[j].Name)>0)
            //        {
            //            string temp1 = studentList[i].Name;
            //            studentList[i].Name = studentList[j].Name;
            //            studentList[j].Name = temp1;

            //        }
            //    }

            //    //for(int k = 0; k < character.Length; k++)
            //    //{
            //    //    char temp;
            //    //    if(character[i] > character[k])
            //    //    {
            //    //        temp = character[i];
            //    //        character[i] = character[k];
            //    //        character[k] = temp;
            //    //    }
            //    //}

            //    //for (int l = 0; l < character.Length; l++)
            //    //{
            //    //    Console.WriteLine(studentList[l].Id + "   " + studentList[l].Name + "  " + studentList[l].Email + "   " + studentList[l].City);
            //    //}

            //}

            //Console.WriteLine("------------------------------------------ Sort ID , Name Data through complex object------------------------------------");

            //for (int i = 0; i < studentList.Count; i++)
            //{
            //    Console.WriteLine(studentList[i].Id+"   "+ studentList[i].Name+"  "+studentList[i].Email+"   "+studentList[i].City);
            //}

            //Console.WriteLine("--------------------------------------- Copy value ----------------------------------------");

            //for(int i = 0; i < SecondList.Count; i++)
            //{
            //    Console.WriteLine(SecondList[i].Id+"   "+ SecondList[i].Name+"   "+ SecondList[i].Email+"   "+SecondList[i].City);
            //}


            //---------------------------------------------------- Through Linq Query ---------------------------------------------------------------

            Console.WriteLine("------------------------------------ Linq Query ---------------------------------------------------");

            var Store = from obj in studentList
                        where obj.Id >= 10
                        //  where obj.Id <30                       // multiple condition
                        //   orderby obj.Id descending             // sort all data on the basis of ID
                        //   orderby obj.City descending
                        select obj;

            foreach (var data in Store)
            {
                Console.WriteLine(data.Id + "  " + data.Name + "   " + data.Email + "   " + data.City);
            }

            Console.WriteLine("------------------------------------ Method -------------------------------------------------------");

            var StoreFun = studentList.Where(obj => obj.Id > 20);

            foreach (var data in StoreFun)
            {
                Console.WriteLine(data.Id + "  " + data.Name + "   " + data.Email + "   " + data.City);
            }

            //------------------------------------------------- Joins ---------------------------------------------------------------

            Console.WriteLine("-------------------------------------Simple Join---------------------------------------------------");

            Marks student10 = new Marks() { Id = 10, Physics = 88, Chemistry = 93, Math = 62 };
            Marks student11 = new Marks() { Id = 30, Physics = 78, Chemistry = 83, Math = 52 };
            Marks student12 = new Marks() { Id = 20, Physics = 68, Chemistry = 73, Math = 72 };
            Marks student13 = new Marks() { Id = 40, Physics = 58, Chemistry = 63, Math = 82 };
            Marks student14 = new Marks() { Id = 50, Physics = 75, Chemistry = 53, Math = 79 };
            Marks student15 = new Marks() { Id = 60, Physics = 80, Chemistry = 88, Math = 85 };
            Marks student16 = new Marks() { Id = 60, Physics = 80, Chemistry = 88, Math = 85 };

            List<Marks> studentData = new List<Marks>();
            studentData.Add(student10);
            studentData.Add(student11);
            studentData.Add(student12);
            studentData.Add(student13);
            studentData.Add(student14);
            studentData.Add(student15);
            studentData.Add(student16);




            var SimpleJoin = from obj in studentList
                             join obj1 in studentData
                             on obj.Id equals obj1.Id
                             //  where obj.City == "pune"                           // it's retrive pune city row
                             //    orderby obj.Name,obj1.Name                      // order data in Asscending order
                             select new
                             {
                                 Student_Id = obj.Id,
                                 Student_Name = obj.Name,
                                 Student_Physics = obj1.Physics,
                                 Student_Chemistry = obj1.Chemistry,
                                 Student_Math = obj1.Math,
                             };

            Console.WriteLine("-------------------------------- Student Details without Order by but using Take() -----------------------------");

            foreach (var data in SimpleJoin.Take(7))
            {
                Console.WriteLine(data.Student_Id + "    " + data.Student_Name + "  " + data.Student_Physics + "  " + data.Student_Chemistry + "  " + data.Student_Math);
            }

            Console.WriteLine("----------------------------------  Student Details with order by ------------------------------");

            foreach (var data in SimpleJoin.OrderBy(ob => ob.Student_Name))
            {
                Console.WriteLine(data.Student_Id + "    " + data.Student_Name + "  " + data.Student_Physics + "  " + data.Student_Chemistry + "  " + data.Student_Math);
            }

            Console.WriteLine("-------------------------------- Using First() ------------------------------------------------------------------");

            foreach (var data in SimpleJoin)
            {
                Console.WriteLine(data.Student_Name.First());
            }

            Console.WriteLine("------------------------------------------------- ElementAt() -------------------------------------------------------");
            int index;
            Console.WriteLine("which index value you want to search:\n");
            index = Convert.ToInt32(Console.ReadLine());

            var IndexData = from obj in studentList
                            select obj;
            var IndexData1 = studentList.Where(obj => obj.Id >= 10).ElementAt(index);
            //IndexData.ElementAt(2);

            Console.WriteLine(IndexData1.Id + "   " + IndexData1.Name + "   " + IndexData1.Email + "   " + IndexData1.City);

            //----------------------------------- function through ------------------------------------------------------------

            Console.WriteLine("------------------------------------- function through ------------------------------------------");

            var JoinFun = studentList.Join(studentData,
                          obj => obj.Id,
                          obj1 => obj1.Id,
                          (first, second) => new
                          {
                              Student_Id = first.Id,
                              Student_Name = first.Name,
                              Student_Physics = second.Physics,
                              Student_Chemistry = second.Chemistry,
                              Student_Math = second.Math,
                          }).OrderBy(obj1 => obj1.Student_Name).Where(obj => obj.Student_Name.StartsWith("v"));

            foreach (var data in JoinFun)
            {
                Console.WriteLine(data.Student_Id + "    " + data.Student_Name + "  " + data.Student_Physics + "  " + data.Student_Chemistry + "  " + data.Student_Math);
            }


            //---------------------------------------------------------- Class Method Through ------------------------------------------------------------------------------------

            Console.WriteLine("--------------------------------------------------- Class Method Through --------------------------------------------------------------");

            Student dataMethod = new Student();
            var methodData = dataMethod.SetData(studentList);

            foreach (Student ob in methodData)
            {
                Console.WriteLine(ob.Id + "   " + ob.Name + "   " + ob.Email + "   " + ob.City);
            }

            dataMethod.GetData(methodData);


            Console.WriteLine("-----------------------------------------------------------------Search name ---------------------------------------------------\n");

            string SearchName;
            int c = 0;
            int c1 = 0;
            Console.WriteLine("----Enter the name ----\n");
            SearchName = Console.ReadLine();


            foreach (var da in studentList)
            {
                if (da.Name == SearchName)
                {
                    Console.WriteLine("Name Found: ");
                    c1++;
                    break;
                }
            }
            if (c1 < 1)
            {
                Console.WriteLine("Name not found");
            }

            Console.WriteLine("-----------------------------------------------------------------Search name through for loop ---------------------------------------------------\n");

            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].Name == SearchName)
                {
                    Console.WriteLine("Name Found: " + studentList[i].Name);
                    c++;
                    break;
                }
            }
            if (c < 1)
            {
                Console.WriteLine("Name not found:");
            }

            Console.WriteLine("----------------------------------------------------------- Search name through query --------------------------------------------------------------\n");

            var search = from obj in studentList
                         where obj.Name == SearchName
                         select obj;

            foreach (var searchDat in search)
            {
                Console.WriteLine(searchDat.Id + " - " + searchDat.Name + " - " + searchDat.Email + " - " + searchDat.City);
            }

            Console.WriteLine("----------------------------------------------------------- Search name through method -----------------------------------------------------------\n");

            var searchMethod = studentList.Where(obj => obj.Name == SearchName);

            foreach (var searchData1 in searchMethod)
            {
                Console.WriteLine(searchData1.Id + " - " + searchData1.Name + " - " + searchData1.Email + " - " + searchData1.City);
            }

            Console.WriteLine("----------------------------------------------------------- contains method through -------------------------------------------------------------\n");

            var searchContains = from obj in studentList
                                 where obj.Name.Contains(SearchName)
                                 select obj;

            foreach (var searchData12 in searchContains)
            {
                Console.WriteLine(searchData12.Id + " - " + searchData12.Name + " - " + searchData12.Email + " - " + searchData12.City);
            }

            //------------------------------------------------------------ Non-Generic-Class------------------------------------------------

            Console.WriteLine("--------------------------------------- int[] value------------------------------------------------------");

            int[] value = { 1, 2, 3, 4, 5 };

            IEnumerable<int> getValue = from obj in value
                                        where obj > 1
                                        select obj;

            foreach (int data in getValue)
            {
                Console.WriteLine(data);
            }


            //------------------------------------------------------------- ThenBy() Clause -------------------------------------------------------------------------------

            Console.WriteLine("----------------------------------------------------- ThenBy() Clause Through Method --------------------------------------------------------------\n");
            Console.WriteLine("Id  Physics  Chemistry  Math\n");

            IEnumerable<Marks> Thenby = studentData.Where(obj => obj.Id >= 10).OrderBy(obj => obj.Physics).ThenBy(obj => obj.Chemistry);
            foreach (Marks ThenData in Thenby)
            {
                Console.WriteLine(ThenData.Id + " -   " + ThenData.Physics + " -    " + ThenData.Chemistry + " -    " + ThenData.Math);
            }


            //------------------------------------------------------------- First Element Operator -------------------------------------------------------------------------------

            //Console.WriteLine("----------------------------------------------------- First()  Method  when value exist--------------------------------------------------------------\n");
            //Console.WriteLine("Id  Physics  Chemistry  Math\n");

            //var Thenby1 = studentData.First(obj => obj.Physics > 90 || obj.Chemistry < 55);

            //Console.WriteLine(Thenby1.Id + " -   " + Thenby1.Physics + " -    " + Thenby1.Chemistry + " -    " + Thenby1.Math);

            //Console.WriteLine("----------------------------------------------------- First()  Through Method  when value does not exist--------------------------------------------------------------\n");
            //Console.WriteLine("Id  Physics  Chemistry  Math\n");

            //var Thenby2 = studentData.First(obj => obj.Physics == 20);              // we have got Exception like  System.InvalidOperationException: 'Sequence contains no matching element'

            //Console.WriteLine(Thenby2.Id + " -   " + Thenby2.Physics + " -    " + Thenby2.Chemistry + " -    " + Thenby2.Math);


            Console.WriteLine("------------------------------------------------------ FirstDefault() when value exit ----------------------------------------------------------------\n");
            Console.WriteLine("Id  Physics  Chemistry  Math\n");

            var Thenby3 = studentData.FirstOrDefault(obj => obj.Id < 10);
            //   Console.WriteLine(Thenby3?.Physics);

            Console.WriteLine(Thenby3?.Id + " -   " + Thenby3?.Physics + " -    " + Thenby3?.Chemistry + " -    " + Thenby3?.Math);



            //---------------------------------------------------------------------- Last element operator ----------------------------------------------------------------------------
            Console.WriteLine("------------------------------------------------------ Last() Method ----------------------------------------------------------------------------------");

            Console.WriteLine("Id  Physics  Chemistry  Math\n");
            var LastBy = studentData.Last();
            Console.WriteLine(LastBy.Id + " -   " + LastBy.Physics + " -    " + LastBy.Chemistry + " -    " + LastBy.Math);

            Console.WriteLine("------------------------------------------------------ Last() Method with lambda expression--------------------------------------------------------------");

            Console.WriteLine("Id  Physics  Chemistry  Math\n");
            var LastBy1 = studentData.Last(obj => obj.Physics < 80);
            Console.WriteLine(LastBy1.Id + " -   " + LastBy1.Physics + " -    " + LastBy1.Chemistry + " -    " + LastBy1.Math);


            Console.WriteLine("------------------------------------------------------ Last() Method when value does not exist--------------------------------------------------------------");

            //Console.WriteLine("Id  Physics  Chemistry  Math\n");
            //var LastBy2 = studentData.Last(obj => obj.Physics == 20);
            //Console.WriteLine(LastBy2.Id + " -   " + LastBy2.Physics + " -    " + LastBy2.Chemistry + " -    " + LastBy2.Math);   // it's give exception

            Console.WriteLine("------------------------------------------------------ LastDefault() Method when value exist ---------------------------------------------------------------");

            Console.WriteLine("Id  Physics  Chemistry  Math\n");
            var LastBy3 = studentData.LastOrDefault(obj => obj.Physics < 80);
            Console.WriteLine(LastBy3.Id + " -   " + LastBy3.Physics + " -    " + LastBy3.Chemistry + " -    " + LastBy3.Math);

            Console.WriteLine("------------------------------------------------------ LastDefault() Method when value does not exist ---------------------------------------------------------------");

            Console.WriteLine("Id  Physics  Chemistry  Math\n");
            var LastBy4 = studentData.LastOrDefault(obj => obj.Id < 10);
            Marks lastBy4 = LastBy4;
            Console.WriteLine(LastBy4?.Id + " -   " + LastBy4?.Physics + " -    " + lastBy4?.Chemistry + " -    " + LastBy4?.Math);

            //-------------------------------------------------------------------------------------- DefaultEmpty() Method --------------------------------------------------------------------------------------------

            Console.WriteLine("---------------------------------------------------------------------- DefaultMethod() with values ----------------------------------------------------------------------------");

            int[] a = { 12, 3, 4, 5, 6 };
            int[] b = { };

            IEnumerable<int> ValueList = a.DefaultIfEmpty();

            foreach (int store in ValueList)
            {
                Console.WriteLine(store);
            }


            //---------------------------------------------------------------------------------------- Group By () --------------------------------------------------------------------------------------------

            Console.WriteLine("------------------------------------------------------------------------ GroupBy() -------------------------------------------------------------------------------------------");

            var groupByList = studentList.GroupBy(obj => obj.Name);
            Console.WriteLine("Id  Name  Email  \n");
            foreach (var ListGroup in groupByList)
            {
                //Console.WriteLine(ListGroup.Key + " - count - "+ ListGroup.Count());
                foreach (var ListIterate in ListGroup)
                {
                    Console.WriteLine(ListIterate.Id + " -   " + ListIterate.Name + " -    " + ListIterate.Email + " -    " + ListIterate.City);
                }
            }


            Console.WriteLine("------------------------------------------------------------------------- GroupBy() By object -------------------------------------------------------------------");

            IEnumerable<IGrouping<Marksheet, Student>> groupByList1 = studentList.GroupBy(obj => new Marksheet { ID = obj.Id, Student_name = obj.Name });
            IEnumerable<IGrouping<Marksheet, Marks>> GroupByList2 = studentData.GroupBy(obj => new Marksheet
            {
                Physics = obj.Physics,
                Chemistry = obj.Chemistry,
                Math = obj.Math,
                Total = obj.Physics + obj.Chemistry + obj.Math
            }).OrderBy(obj => obj.Key.Physics);

            foreach (var GroupData in GroupByList2)
            {
                Console.WriteLine(GroupData.Key.ID + " - " + GroupData.Key.Student_name + " - " + GroupData.Key.Physics + " - " + GroupData.Key.Chemistry + " - " + GroupData.Key.Math + " - " + GroupData.Key.Total);
            }

            // ParallelQuery<IGrouping<Marksheet,Marks>> comb = groupByList1.Concat(GroupByList2);

            //---------------------------------------------------------------------------------------- Aggregate() function --------------------------------------------------------------------

            Console.WriteLine("------------------------------------------------------------------ Aggregate() function ---------------------------------------------------------------------");

            var ghj = studentData.Select(obj => obj.Physics).Aggregate((obj, obj1) => obj + obj1);
            Console.WriteLine("---------------------------------ccccccccccccccccccccccccccccccccccccccc---------------------------");
            Console.WriteLine("0000000000:  " + ghj);

            var PhysicsSum = studentData.Sum(obj => obj.Physics);
            var ChemistrySum = studentData.Sum(obj => obj.Chemistry);
            var MathSum = studentData.Sum(obj => obj.Math);

            var AggregateList = studentData.Where(obj => obj.Id >= 10).OrderByDescending(obj => obj.Math);

            Console.WriteLine("Id       Physics       Chemistry       Math\n");
            foreach (var StoreAggre in AggregateList)
            {
                Console.WriteLine(StoreAggre.Id + "   -      " + StoreAggre.Physics + "   -        " + StoreAggre.Chemistry + "   -      " + StoreAggre.Math);
            }

            Console.WriteLine("Sum         " + PhysicsSum + "           " + ChemistrySum + "          " + MathSum);



            //------------------------------------------------------------------------------------Set Operations() --------------------------------------------------------------------------

            Console.WriteLine("------------------------------------------------------------------- Union() --------------------------------------------------------------------------------");

            string[] country = { "Ind", "Rus", "Aus", "Nep" };
            string[] country1 = { "can", "China", "Pak", "Ind", "Rus" };

            var unique = country.Union(country1);

            foreach (var StoreUniq in unique)
            {
                Console.WriteLine(StoreUniq);
            }

            Console.WriteLine("------------------------------------------------------------------- Intersection() ---------------------------------------------------------------------------");
            var Intersection = country.Intersect(country1);

            foreach (var StoreInter in Intersection)
            {
                Console.WriteLine(StoreInter);
            }


            Console.WriteLine("------------------------------------------------------------------ Except() ------------------------------------------------------------------------------------");

            var Except = country.Except(country1);

            var studentProfile = studentList.Where(obj => obj.Id >= 10).Select(obj => obj.Id);
            var studentMarks = studentData.Where(obj => obj.Id >= 10).Select(obj => obj.Id);
            var combineList = studentProfile.Union(studentMarks);


            foreach (var ds in combineList)
            {

                Console.WriteLine(ds);

            }


            //foreach (var StoreExcept in Except)
            //{
            //    Console.WriteLine(StoreExcept);
            //}

            //foreach (var ThenData in Thenby1)
            //{
            //    Console.WriteLine(ThenData.Id + " -   " + ThenData.Physics + " -    " + ThenData.Chemistry + " -    " + ThenData.Math);
            //}


            //**********************************************************************************8*  Linq Standard Query Operators *****************************************************************************************


            //----------------------------------------------------------------------------------- For Filtering Data --------------------------------------------------------------------------------------------------

            Console.WriteLine("---------------------------------------------------------------- Where() operator ----------------------------------------------------------------------------------------");

            // where() ke through hum pora object return krte hai on the basis of condition

            var WhereOperator = studentList.Where(obj => obj.Id > 20);
            foreach (var WhereData in WhereOperator)
            {
                Console.WriteLine(WhereData.Id + "  :   " + WhereData.Name + "   :   " + WhereData.Email + "   :   " + WhereData.City);
            }

            Console.WriteLine("---------------------------------------------------------------- OfType() operator ----------------------------------------------------------------------------------------");

            //OfType() ke through hum specific type ke value return krte hai or class ke object ko be return kr sakte hai
            //OfType mai hum lambda expression use nai kr sakte hai


            var StringOfTypeOperator = studentList.Where(obj => obj.Id > 20).OfType<Student>();

            foreach (var StringOfType in StringOfTypeOperator)
            {
                Console.WriteLine(StringOfType.Id);
            }


            //---------------------------------------------------------------------------------------- For Sorting -------------------------------------------------------------------------------------------------------

            Console.WriteLine("---------------------------------------------------------------------------------- OrderBy() ------------------------------------------------------------------------------");

            // OrderBy() ke through hum kiss ek property ko order kr sakte hai (Asscending order)

            var OrderByOperator = studentList.OrderBy(obj => obj.Name);
            foreach (var DataOrderBy in OrderByOperator)
            {
                Console.WriteLine(DataOrderBy.Id + "  :  " + DataOrderBy.Name + "  :  " + DataOrderBy.Email + "  :  " + DataOrderBy.City);
            }


            Console.WriteLine("---------------------------------------------------------------------------------- OrderByDescending() --------------------------------------------------------------------------");

            var OrderByDescendingOperator = studentList.OrderByDescending(obj => obj.Id);

            foreach (var DataOrderByDescending in OrderByDescendingOperator)
            {
                Console.WriteLine(DataOrderByDescending.Id + "  :  " + DataOrderByDescending.Name + "  :  " + DataOrderByDescending.Email + "  :  " + DataOrderByDescending.City);
            }


            Console.WriteLine("----------------------------------------------------------------------------------- ThenBy() -------------------------------------------------------------------------------------------");

            var ThenByOperator = studentList.OrderBy(obj => obj.Name).ThenBy(obj => obj.City);
            foreach (var DataThenBy in ThenByOperator)
            {
                Console.WriteLine(DataThenBy.Id + "  :  " + DataThenBy.Name + "  :  " + DataThenBy.Email + "  :  " + DataThenBy.City);
            }

            Console.WriteLine("----------------------------------------------------------------------------------- ThenByDescending() ------------------------------------------------------------------------------------");

            var ThenByDescendingOperator = studentList.OrderByDescending(obj => obj.Name).ThenByDescending(obj => obj.City);

            foreach (var DataThenByDescending in ThenByDescendingOperator)
            {
                Console.WriteLine(DataThenByDescending.Id + "  :  " + DataThenByDescending.Name + "  :  " + DataThenByDescending.Email + "  :  " + DataThenByDescending.City);
            }


            Console.WriteLine("---------------------------------------------------------------------------------------- Reverse() --------------------------------------------------------------------------------------- ");

            //Reverse() method reverse the entire list
            // we can not apply lambda expression

            var ReverseOperator = studentList.Where(obj => obj.Id >= 10).Reverse();
            foreach (var DataReverse in ReverseOperator)
            {
                Console.WriteLine(DataReverse.Id + "  :  " + DataReverse.Name + "  :  " + DataReverse.Email + "  :  " + DataReverse.City);
            }


            //--------------------------------------------------------------------------------------------------- For Grouping -------------------------------------------------------------------------------------------

            Console.WriteLine("------------------------------------------------------------------------------------------ GroupBy() --------------------------------------------------------------------------------------");

            // it's return the diferred value means ke ye sequence ke according value return krega

            var GroupingOperator = studentList.GroupBy(obj => obj.Id);
            Console.WriteLine(GroupingOperator);
            foreach (var DataGroupBy in GroupingOperator)
            {
                Console.WriteLine(DataGroupBy.Key);
                foreach (var DataKeyValue in DataGroupBy)
                {
                    Console.WriteLine(DataKeyValue.Name + "   :   " + DataKeyValue.Email + "   :   " + DataKeyValue.City);
                }
            }

            Console.WriteLine("------------------------------------------------------------------------------------------ GroupBy() object through --------------------------------------------------------------------------------------");

            IEnumerable<IGrouping<Marksheet, Student>> GroupingObject = studentList.GroupBy(obj => new Marksheet { ID = obj.Id, Student_name = obj.Name });
            Console.WriteLine(GroupingObject);

            foreach (var DataKeyValue in GroupingObject)
            {
                Console.WriteLine(DataKeyValue.Key.ID + "   :    " + DataKeyValue.Key.Student_name);
            }

            Console.WriteLine("------------------------------------------------------------------------------------------ ToLookUp() ---------------------------------------------------------------------------------------");

            // or ye immediate value return krega


            var LookUpOperator = studentList.ToLookup(obj => obj.Id);
            Console.WriteLine(LookUpOperator);
            foreach (var DataLookUp in LookUpOperator)
            {
                Console.WriteLine(DataLookUp.Key);
                foreach (var DataKeyValue in DataLookUp)
                {
                    Console.WriteLine(DataKeyValue.Name + "   :   " + DataKeyValue.Email + "   :   " + DataKeyValue.City);
                }
            }


            //------------------------------------------------------------------------------------------------- For Joining -------------------------------------------------------------------------------------------------

            Console.WriteLine("------------------------------------------------------------------------------------ Simple join -----------------------------------------------------------------------------------------");

            var SimpleJoinOperator = studentList.Join(
                                      studentData,
                                      student => student.Id,
                                      Marksheet => Marksheet.Id,
                                      (student, Marksheet) => new
                                      {
                                          Students = student,
                                          StudentId = student.Id,
                                          MarksheetId = Marksheet.Id,
                                          StudentName = student.Name,
                                          Math = Marksheet.Math,
                                          Physis = Marksheet.Physics

                                      });//.Where(obj => obj.StudentName.StartsWith("p"));

            foreach (var DataSimpleJoin in SimpleJoinOperator)
            {
                Console.WriteLine(DataSimpleJoin.Students.Name + "   :    " + DataSimpleJoin.StudentId + "    :    " + DataSimpleJoin.MarksheetId + "   :   " + DataSimpleJoin.StudentName + "   :   " + DataSimpleJoin.Math + "   :   " + DataSimpleJoin.Physis);
            }


            Console.WriteLine("------------------------------------------------------------------------------------ Group join -----------------------------------------------------------------------------------------");

            var GroupJoinOperator = studentList.Join(
                                      studentData,
                                      student => student.Id,
                                      Marksheet => Marksheet.Id,
                                      (student, Marksheet) => new
                                      {
                                          Students = student,
                                          StudentId = student.Id,
                                          MarksheetId = Marksheet.Id,
                                          StudentName = student.Name,
                                          Math = Marksheet.Math,
                                          Physis = Marksheet.Physics

                                      });//.Where(obj => obj.StudentName.StartsWith("p"));

            foreach (var DataGroupJoin in GroupJoinOperator)
            {
                Console.WriteLine(DataGroupJoin.Students.Id + "   :    " + DataGroupJoin.StudentId + "    :    " + DataGroupJoin.MarksheetId + "   :   " + DataGroupJoin.StudentName + "   :   " + DataGroupJoin.Math + "   :   " + DataGroupJoin.Physis);
            }


            //------------------------------------------------------------------------------------------- Select -------------------------------------------------------------------------------------------------

            Console.WriteLine("----------------------------------------------------------------------------------------------Select ------------------------------------------------------------------------------------");

            var SelectOperator = studentList.Select(obj => obj.Name);


            foreach (var DataSelect in SelectOperator)
            {
                Console.WriteLine(DataSelect);
            }

            var SelectOperatorObj = studentList.Select(obj => new { FullName = obj.Name, Email = obj.Email });
            Console.WriteLine("");

            foreach (var DataSelectObj in SelectOperatorObj)
            {
                Console.WriteLine(DataSelectObj.FullName + "   :    " + DataSelectObj.Email);
            }


            Console.WriteLine("----------------------------------------------------------------------------------------- Select Many --------------------------------------------------------------------------------------");


            // it's return every single character of list in the new line

            var SelectManyOperator = studentList.SelectMany(obj => obj.Email);
            foreach (var DataSelectMany in SelectManyOperator)
            {
                Console.WriteLine(DataSelectMany);
            }

            //--------------------------------------------------------------------------------------------- Aggregate --------------------------------------------------------------------------------------------

            Console.WriteLine("--------------------------------------------------------------------------------- Aggregate -----------------------------------------------------------------------------------------");

            var AggregateOperator = studentData.Select(obj => obj.Math).Aggregate((obj, obj1) => obj + obj1);
            Console.WriteLine("Total Math Number :     " + AggregateOperator);

            Console.WriteLine("--------------------------------------------------------------------------------- Average ------------------------------------------------------------------------------------------");

            var AverageOperator = studentData.Select(obj => obj.Math).Average();
            Console.WriteLine("Avergae Of Math:   " + AverageOperator);

            Console.WriteLine("---------------------------------------------------------------------------------- Count -------------------------------------------------------------------------------------------");

            // it is used for 32 bit

            var CountOperator = studentData.Count();
            Console.WriteLine("Count:   " + CountOperator);

            Console.WriteLine("---------------------------------------------------------------------------------- Long Count ------------------------------------------------------------------------------------------");

            // it is used for 64 bit

            var LongCountOperator = studentData.LongCount();
            Console.WriteLine("LongCount:    " + LongCountOperator);

            Console.WriteLine("---------------------------------------------------------------------------------- Max -------------------------------------------------------------------------------------------------");

            var MaxOperator = studentData.Select(obj => obj.Math).Max();
            Console.WriteLine("Max number in math:   " + MaxOperator);

            Console.WriteLine("---------------------------------------------------------------------------------------- Min ---------------------------------------------------------------------------------------------");

            var MinOperator = studentData.Select(obj => obj.Math).Min();
            Console.WriteLine("Min number in math:    " + MinOperator);

            Console.WriteLine("---------------------------------------------------------------------------------------------- Sum --------------------------------------------------------------------------------------");

            var SumOperator = studentData.Select(obj => obj.Math).Sum();
            Console.WriteLine("Sum of math number:    " + SumOperator);


            //------------------------------------------------------------------------------------------------------------- Quantifiers ----------------------------------------------------------------------------------

            Console.WriteLine("----------------------------------------------------------------------------------------- All() ------------------------------------------------------------------------------------------");

            // it's return boolean value if condition satisfied
            // if all value satisfied the condition then it's give the true value otherwise false

            var AllOperator = studentList.All(obj => obj.Id >= 10 && obj.Id <= 40);
            Console.WriteLine(AllOperator);

            Console.WriteLine("------------------------------------------------------------------------------------------- Any() --------------------------------------------------------------------------------------");

            // if value satisfied or not it's give always give true value

            var AnyOperator = studentList.Any(obj => obj.Id > 10 && obj.Id < 40);
            Console.WriteLine(AnyOperator);

            Console.WriteLine("------------------------------------------------------------------------------------------- Contains() ------------------------------------------------------------------------------------");

            // if given value exist in list then it's return true value otherwise false

            var ContainsOperator = studentList.Select(obj => obj.Name).Contains("vedant");
            Console.WriteLine(ContainsOperator);

            //----------------------------------------------------------------------------------------------------------- Elements -------------------------------------------------------------------------------------------

            Console.WriteLine("----------------------------------------------------------------------------------- ElementsAt() ------------------------------------------------------------------------------------------");

            // it's return the value on the basis of index value if index exist then it's  return the value

            // other wise we got the exception  System.ArgumentOutOfRangeException: 'Specified argument was out of the range of valid values. (Parameter 'index')'
            var ElementsAtOperator = studentList.Where(obj => obj.Id >= 10).ElementAt(2);

            // var ElementsAtOperator = studentList.Where(obj => obj.Id >= 10).ElementAt(7);
            // var ElementsAtOperator = studentList.Select(obj => obj.Id).ElementAt(2);
            // Console.WriteLine(ElementsAtOperator);

            Console.WriteLine(ElementsAtOperator.Id+"  :  "+ElementsAtOperator.Name+"  :  "+ElementsAtOperator.Email+"  :  "+ElementsAtOperator.City);

            Console.WriteLine("------------------------------------------------------------------------------------ElementAtDefault()--------------------------------------------------------------------------------------");

            // if index value does not matched then we got this exception System.NullReferenceException: 'Object reference not set to an instance of an object.' (jab hum poora object return kr rhe honge tab ye ayega) 

            //var ElementAtDefaultOperator = studentList.Where(obj => obj.Id >= 10).ElementAtOrDefault(7);

            // jab hum specific value search krnge index ke through to agar value exist hogi to value return hogi nai to to uski default value

             var ElementsAtOperator1 = studentList.Select(obj => obj.Id).ElementAtOrDefault(7);
             Console.WriteLine(ElementsAtOperator1);

            // Console.WriteLine(ElementAtDefaultOperator.Id + "  :  " + ElementAtDefaultOperator.Name + "  :  " + ElementAtDefaultOperator.Email + "  :  " + ElementAtDefaultOperator.City);


            Console.WriteLine("---------------------------------------------------------------------------------- First() --------------------------------------------------------------------------------------------");

            // agra given value match na ho to ye exception Ayegi  System.InvalidOperationException: 'Sequence contains no matching element'

            //var FirstOperator = studentList.First(obj => obj.Id == 90);
             var FirstOperator = studentList.First(obj => obj.Id == 30);


            Console.WriteLine(FirstOperator.Id + "  :  " + FirstOperator.Name + "  :  " + FirstOperator.Email + "  :  " + FirstOperator.City);

            Console.WriteLine("----------------------------------------------------------------------------------- FirstOrDefault() ------------------------------------------------------------------------------------");

            // var FirstOrDefaultOperator = studentList.FirstOrDefault(obj => obj.Id == 80);
            var FirstOrDefaultOperator = studentList.Where(obj => obj.Id >=10).FirstOrDefault();



            Console.WriteLine(FirstOrDefaultOperator.Id + "  :  " + FirstOrDefaultOperator.Name + "  :  " + FirstOrDefaultOperator.Email + "  :  " + FirstOrDefaultOperator.City);

            Console.WriteLine("---------------------------------------------------------------------------------- Single() or SingleOrDefault() --------------------------------------------------------------------------------------------");

            List<int> SingleList = new List<int>();

            SingleList.Add(10);
            SingleList.Add(20);
            SingleList.Add(30);
            SingleList.Add(40);
            SingleList.Add(50);
            SingleList.Add(60);
            SingleList.Add(50);

            List<int> ExceptList = new List<int>();
            ExceptList.Add(10);
            ExceptList.Add(20);
            ExceptList.Add(30);
            ExceptList.Add(70);
            ExceptList.Add(80);
            ExceptList.Add(90);
            ExceptList.Add(100);

            List<string> UnionList = new List<string>();
            UnionList.Add("vedant");
            UnionList.Add("vaibhav");
            // if list contains more than one elements then it's give the error like  System.InvalidOperationException: 'Sequence contains more than one element'
            // if list does not contain any value in the list then it's give this System.InvalidOperationException: 'Sequence contains no elements'
            //   var SingleOperator = SingleList.Single();
            // Console.WriteLine(SingleOperator);

            // if value does not exist in the list then it's give the default value of list
            //var SingleOrDefault = SingleList.SingleOrDefault();

            //Console.WriteLine(SingleOrDefault);
            //foreach(var DataSingle in SingleOperator)
            //{
            //    Console.WriteLine();
            //}

            //--------------------------------------------------------------------------------------------- Set() ------------------------------------------------------------------------------------------------
            Console.WriteLine("-------------------------------------------------------------------------- Distinct() -------------------------------------------------------------------------------------------");

            // it's give the unique elements only
            var DistinctOperator = SingleList.Distinct().ToList();
            Console.WriteLine(DistinctOperator.Count);
            foreach(var DataDistinct in DistinctOperator )
            {
                Console.WriteLine(DataDistinct);
            }

            Console.WriteLine("------------------------------------------------------------------------------ Except() ------------------------------------------------------------------------------------------------");

            // agar left list ke elements right wali list ke elements se match nai hoti hai to ye left wali list ke unmatched elements ko return krega

            var ExceptOperator = SingleList.Except(ExceptList);

            foreach (var DataExcept in ExceptOperator)
            {
                Console.WriteLine(DataExcept);
            }

            Console.WriteLine("------------------------------------------------------------------------------- Uninon() ---------------------------------------------------------------------------------------------");

            // it's contain all value from two list except duplicate value

            var UninonOperator = SingleList.Union(ExceptList);

            foreach(var DataUnion in UninonOperator)
            {
                Console.WriteLine(DataUnion);
            }

            Console.WriteLine("------------------------------------------------------------------------------ InterSection() ---------------------------------------------------------------------------------------");

            // it's retrive only unique elements only

            var InterSectionOperator = SingleList.Intersect(ExceptList);
            foreach(var DataInterSection in InterSectionOperator)
            {
                Console.WriteLine(DataInterSection);
            }

            //--------------------------------------------------------------------------------------------- Partioning -------------------------------------------------------------------------------------------

            Console.WriteLine("---------------------------------------------------------------------------- Skip() ----------------------------------------------------------------------------------------");

            //Skip(): Agar muze kuch value nai chaiye top se to hum uske according uski index value daldege to hum uss range ke value nai milegi

            var SkipOperator = SingleList.Skip(2);
            foreach(var DataSkip in SkipOperator)
            {
                Console.WriteLine(DataSkip);
            }

            Console.WriteLine("---------------------------------------------------------------------------- SkipWhile() -------------------------------------------------------------------------------");

            // condition ke base pe skip krega value

            var SkipWhileOperator = studentList.SkipWhile(obj => obj.Id < 20);

            foreach(var DataSkipWhile in SkipWhileOperator)
            {
                Console.WriteLine(DataSkipWhile.Id+"   :   "+DataSkipWhile.Name+"   :   "+DataSkipWhile.Email+"   :   "+DataSkipWhile.City);
            }

            Console.WriteLine("------------------------------------------------------------------------ Take() --------------------------------------------------------------------------------------------");

            // it's retrive top value on the basis of index value

            var TakeOperator = studentList.Take(2);   // here we are retriving two top value from list

            foreach(var DataTake in TakeOperator)
            {
                Console.WriteLine(DataTake.Id+"   :   "+DataTake.Name+"   :   "+DataTake.Email+"   :   "+DataTake.City);
            }


            Console.WriteLine("----------------------------------------------------------------------------- TakeWhile() ---------------------------------------------------------------------------------------");

            //here we are retriving top value on the basis of condition

            var TakeWhileOperator = studentList.TakeWhile(obj => obj.Id < 30);
            foreach(var DataTakeWhile in TakeWhileOperator)
            {
                Console.WriteLine(DataTakeWhile.Id+"  :  "+DataTakeWhile.Name+"  :  "+DataTakeWhile.Email+"  :  "+DataTakeWhile.City);
            }

            //--------------------------------------------------------------------------------------------- Concatnation --------------------------------------------------------------------------------------------

            Console.WriteLine("--------------------------------------------------------------------------------- Concatnation -----------------------------------------------------------------------------------");

            // it is used to concate two list 

            var ConcateOperator = SingleList.Concat(ExceptList);
            foreach(var DataConcate in ConcateOperator)
            {
                Console.WriteLine(DataConcate);
            }

            //------------------------------------------------------------------------------------------------- Equality ------------------------------------------------------------------------------------------

            // if Sequance of both list is same then it's retrun true value

            Console.WriteLine("---------------------------------------------------------------------------------- Equality() --------------------------------------------------------------------------------------");

            List<int> EqualList = new List<int>();

            EqualList.Add(10);
            EqualList.Add(20);
            EqualList.Add(30);
            EqualList.Add(40);
            EqualList.Add(50);
            EqualList.Add(60);

            List<int> EqualList1 = new List<int>();

            EqualList1.Add(10);
            EqualList1.Add(20);
            EqualList1.Add(30);
            EqualList1.Add(40);
            EqualList1.Add(50);
            EqualList1.Add(60);
           // EqualList1.Add(70);

            var EqualOperator = EqualList.SequenceEqual(EqualList1);
            Console.WriteLine(EqualOperator);


            //---------------------------------------------------------------------------------------------------- Range() -----------------------------------------------------------------------------------------

            Console.WriteLine("----------------------------------------------------------------------------------- Range() ----------------------------------------------------------------------------------------");

            var RangeOperator = Enumerable.Range(100,10);
            foreach(var DataRange in RangeOperator)
            {
                Console.WriteLine(DataRange);
            }


            Console.WriteLine("--------------------------------------------------------------------------------------- Repeat() -------------------------------------------------------------------------------------------");

            var RepeatOperator = Enumerable.Repeat(100,10);
            foreach(var DataRepeat in RepeatOperator)
            {
                Console.WriteLine(DataRepeat);
            }

            Console.WriteLine("----------------------------------------------------------------------------------------- Empty() --------------------------------------------------------------------------------------");

            List<int> EmptyList = new List<int>();
            var EmptyOperator = EmptyList.DefaultIfEmpty();
            Console.WriteLine(EmptyOperator.Count());
            

        }
    }
}
