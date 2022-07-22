using System;
using System.Collections;  // for Simple Collection.class  and it is not type safe
using System.Collections.Generic;  //  for Generic.class and it is type safe
namespace ArrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            int n;

            Console.WriteLine("Enter the size of array:");

            n = Convert.ToInt32(Console.ReadLine());   // taking size of array

            int[] arraySort = new int[n];              // injecting size in array

            int[] arr = new int[4] { 8, 6, 4, 2};

            Console.WriteLine("Enter Array elements:");

            for(int i = 0; i < n; i++)
            {
                arraySort[i] = Convert.ToInt32(Console.ReadLine());   // taking user input as a array
            }

            Console.WriteLine("Display Array Elements:");

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(arraySort[i]);                 // displaying array  elements
            }

            */

            // ---------------------------------------------------- Array.Sort() Method -------------------------------------------------------------

            /*

            Console.WriteLine("User Input Value In Asscending order :");

            Array.Sort(arraySort);                    // here we are sorting the user input value  " Array.Sort() " Method

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine(arraySort[i]); 
            }

            Console.WriteLine("Array Literal Value In Asscending order :");

            Array.Sort(arr);                        // here we are also sorting the array literal value using " Array.Sort() " Method

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            8?

            // --------------------------------------------------- CreateInstace() Method -------------------------------------------------------------------------------

            /*

            Array array = Array.CreateInstance(typeof(int), 5);
            Console.WriteLine("Create Instance: " + array.Length);
            */

            // ---------------------------------------------------- Array.Reverse() Method----------------------------------------------------------

            /*

            Console.WriteLine("User Input Value In Reverse Order: ");

            Array.Reverse(arraySort);          // here we are displaying(array elements) user input value in reverse order using " Array.Reverse() " Method

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arraySort[i]);
            }

            Console.WriteLine("Array Literal Value In Reverse order :");

            Array.Reverse(arr);        // here we are also displaying(array elements) array literal value in reverse order using " Array.Reverse() " Method

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            */

            //------------------------------------ Array.BinarySearch(): it is used to search entire one dimensial array -----------------------------

            /*

            Console.WriteLine("Searching specific elements in user input array:");

            int searchSpecificElement;

            int count = 0;

            Console.WriteLine(arraySort + " Which number you want to search: ");

            searchSpecificElement = Convert.ToInt32(Console.ReadLine());        // this value for searching the specific value

            int found = Array.BinarySearch(arraySort, searchSpecificElement);     // found variable is storing the  index value of searching element

            Console.WriteLine("found:" + found);

            for (int i = 0; i < n; i++)
            {
                if (arraySort[i] == arraySort[found])
                {
                    Console.WriteLine("Specific element found: " + arraySort[i]);
                    count++;
                    break;
                }
            }

            if (count < 1)
            {
                Console.WriteLine("Not Found:");
            }

            */

            // -------------------------------- Array.Search() it is used to search element in specific range -----------------------------------

            /*

            Console.WriteLine("Searching specific elements in user input array:");

            int searchSpecificElement;

            int count = 0;

            Console.WriteLine(arraySort + " Which number you want to search: ");

            searchSpecificElement = Convert.ToInt32(Console.ReadLine());        // this value for searching the specific value

            int found = Array.BinarySearch(arraySort,0,arraySort.Length-1, searchSpecificElement);     // found variable is storing the  index value of searching element

            Console.WriteLine("found:" + found);

            for (int i = 0; i < n; i++)
            {
                if (arraySort[i] == arraySort[found])
                {
                    Console.WriteLine("Specific element found: " + arraySort[i]);
                    count++;
                    break;
                }
            }

            if (count < 1)
            {
                Console.WriteLine("Not Found:");
            } 

            */

            /* Array.BinarySearch(arraySort,0,arraySort.Length-1, searchSpecificElement)
             * 
             Where: 

            arraSort:                       it is Array
            0:                              it is a starting index (we can set according to need)|
            arraySort.Length-1:             it is a ending range                | 
            searchSpecificElement:          it is used to searching the elements

            Working: arraysort hmara array hai, humm jo value ko search krr rhee hai woo humm (0 to arraySort.Length-1) inke beach kr rhe hai
                     Apne according hum starting index value or ending index value ko change ke sakte hai
             */

            //------------------------------------------------------ Array.Clear() Method ----------------------------------------------------

            /*

            int[] arrayClear = new int[5] { 1, 2, 4, 5, 6 };

         // string[] stringClear = new string[5] { "aa", "ba", "ca", "da", "ea" };  

         // jab hum string array ke sath clear() ka use krte hai to default value set nai hoti hai

            Console.WriteLine("Before Clear() Method using array Elements:");

            foreach(int arrClearStore in arrayClear)
            {
                Console.WriteLine(arrClearStore);
            }

            Array.Clear(arrayClear,1,2);            

            Console.WriteLine("After using Clear() Method: ");

            foreach(int arrClearStore in arrayClear)
            {
                Console.WriteLine(arrClearStore);
            }

            */


            /* Array.Clear(arrayClear,1,2)
             
            Where:

            arrayClear :    it is a array
            1 :             it is a starting index value
            2 :             it is a Ending index value

            Working: arrayClear ye hmara array hai too humm Clear() method ke through (1,2) ke between jitni value hogi 
                     wa per uski default value set ho jayegi
             
            EX: integer ke default value = 0
             */


            //------------------------------------------------- Array.Clone() Method -----------------------------------------------------

            /*

            string[] StringClone = new string[5] { "abhishek", "vedant", "pindari", "shardul", "Nitin" };

            Console.WriteLine("Before using the Clone() Method: ");

            foreach(string cloneStore in StringClone)
            {
                Console.WriteLine(cloneStore);
            }

            string[] cloneArray = new string[5];      // here i created blank string array with same size
            Array.Copy(StringClone,cloneArray, StringClone.Length); // here we are copying the  array into the another array

            Console.WriteLine("After using the Clone() Method");

            foreach(string cloneStore in cloneArray)
            {
                Console.WriteLine(cloneStore);
            }

            */

            /* Array.Copy(StringClone,cloneArray, StringClone.Length)
             * 
             * Where:
              
               StringClone:                 it is a first string array
               cloneArray:                  it is a second array with same size of first array
               StringClone.Length:          it is the length of  first array

               Working: StringClone ye humari array hai jismai value define hai  to  jo StringClone.Length
               (jitni value chaiye utni length set kr do array ke)hai iske through humm 
               new blank array mai value copy kr rhe hai 
             
             */

            // --------------------------------------------------- Array.CreateInstance() Method -----------------------------------------------------------------------

            //Array array = Array.CreateInstance(typeof(int),5);
            //Console.WriteLine("Create Instance: " + array.Length);
            //for(int i = array.GetLowerBound(0) ; i < array.GetUpperBound(0); i++)
            //{
            //    array.SetValue(i + 1, i);
            //    Console.WriteLine();
            //}

            //****************************************************** I am not able to understand this method **********************************************************

            //------------------------------------------------------ Array.IndexOf() Method --------------------------------------------------------------------------

            /*

            int[] arrayIndexOf = new int[5] { 10, 20, 30, 40, 50 };

            int searchNumber;

            int c = 0;
            
            Console.WriteLine("Before using IndexOf() method:");

            foreach(int indexStore in arrayIndexOf)
            {
                Console.WriteLine(indexStore);
            }

            Console.WriteLine("Which number you want to search: ");

            searchNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("After using IndexOf() method:");

           int found = Array.IndexOf(arrayIndexOf, searchNumber);      // for finding index number on the basis of searchable number
            Console.WriteLine("Found: " + found);

           for(int i = 0; i < arrayIndexOf.Length; i++)
            {
                if(i == found)
                {
                    Console.WriteLine("Found:");
                    c++;
                    break;
                }
            }
            if(c < 1)
            {
                Console.WriteLine("Not found");
            }

            */

            /*  Array.IndexOf(arrayIndexOf, searchNumber):
             *  
             *  Where:  
              
              arrayIndexOf:  it is over array
              searchNumber: it is over searchable number


              Working:  arrayIndexOf ye hmari array hai or jo searchNumber hai isko hmko search krna hai kee ye value kiss index mai hai array kee
             
             
             */


            //------------------------------------------------------ Array.lastIndexOf() Method --------------------------------------------------------------------------

            /*

            int[] arrayLastIndexOf = new int[5] { 10, 20, 30, 40, 50 };

            int searchNumber;

            int c = 0;
            
            Console.WriteLine("Before using IndexOf() method:");

            foreach(int indexStore in arrayLastIndexOf)
            {
                Console.WriteLine(indexStore);
            }

            Console.WriteLine("Which number you want to search: ");

            searchNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("After using IndexOf() method:");

            int found = Array.LastIndexOf(arrayLastIndexOf, searchNumber);      // for finding index number(starting from last index) on the basis of searchable number
            Console.WriteLine("Found: " + found);

           for(int i = 0; i < arrayLastIndexOf.Length; i++)
            {
                if(i == found)
                {
                    Console.WriteLine("Found:");
                    c++;
                    break;
                }
            }
            if(c < 1)
            {
                Console.WriteLine("Not found");
            }

            */

            /*  Array.lastIndexOf(arrayIndexOf, searchNumber):
             *  
             *  Where:  
              
              arrayIndexOf:  it is over array
              searchNumber: it is over searchable number


              Working:  arrayIndexOf ye hmari array hai or jo searchNumber hai isko hmko search krna hai kee ye value kiss index mai hai array kee
             
             
             */


            // ------------------------------------------------------------- CopyTo() Method ---------------------------------------------------------------------

            /*

            int[] arrayCopyTo = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Before using CopyTo() Method: ");

            foreach(int copyToStore in arrayCopyTo)
            {
                Console.WriteLine(copyToStore);
            }

            Console.WriteLine("After using CopyTo() Method:");

            int[] secondCopyTo = new int[5];

            arrayCopyTo.CopyTo(secondCopyTo, 0);  // here we are copying value 

            foreach(int copyToStore in secondCopyTo)
            {
                Console.WriteLine(copyToStore);
            }

            */


            // --------------------------------------------------------- Clone() ---------------------------------------------------------------------------

            /*

            string first_name = "vedant";

            Console.WriteLine("Without clone method: " + first_name);

            string cloneFirst_name = (string)first_name.Clone();    // here we are cloning variable  (means creating exact copy)

            Console.WriteLine("After Clone Method: " + cloneFirst_name);

            int[] arrayClone = new int[5] { 1, 2, 3, 4, 5 };

            int[] intClone = (int[])arrayClone.Clone();                      // here we are cloning array (it's takes reference only)

            foreach(int cloneStore in intClone)
            {
                Console.WriteLine(cloneStore);
            }
            
            */

            // -------------------------------------------------------- GetLength() ---------------------------------------------------------------------------

            /*

            int[] arrayGetLength = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Get Length Function: " + arrayGetLength.GetLength(0) +"====="+arrayGetLength.GetType()+"======"+arrayGetLength.GetValue(4)+"==============="+ arrayGetLength.IsFixedSize);

            */

            // GetLength(0) we need to write (0) inside function if we give 2 or 3 or any valye instant of 0 so it's give the error at run time

            //arrayGetLength.GetValue(4): this is used to retrive the value from array;

            //arrayGetLength.GetType(): this is used for know type of array

            // arrayGetLength.IsFixedSize: for checking array has a fixed size or not if yes it's give boolean value ( True) otherwise (False);



            // ***************************************************************** ArrayList() **************************************************************************

            //------------------------------------------------------------------ Add() Method ------------------------------------------------------------------------

            /*

            ArrayList arrayList = new ArrayList();

            arrayList.Add("vedant");
            arrayList.Add("abhishek");
            arrayList.Add("pindari");
            arrayList.Add("shardul");
            arrayList.Add("ajinkya");
            arrayList.Add("nikita");
            arrayList.Add("raj");
            arrayList.Add("vaibhavi");
            arrayList.Add("rohit");

            Console.WriteLine(arrayList+ "  Add() of arrayList:" + arrayList.Count +":  Capacity check:   "+ arrayList.Capacity);

            Console.WriteLine("Iterating arrayList:\n");

            foreach(string storeList in arrayList)
            {
                Console.WriteLine(storeList);
            }

            */

            /*
             arrayList.Count:               this is used to count the number of elements contain by arrayList

             arrayList.Capacity:            this is showing default size of ArrayList so the default size Of ArrayList is = 8 
                                            if we cross the limit then automatic ArrayList doubled the size like ( 16 )
             
            Add(): this method is used to store the elements in ArrayList
             
             
             */

            //------------------------------------------------------------------- Sort() Method -------------------------------------------------------------------

            /*

            Console.WriteLine("After Using Sort() Method:\n");
            arrayList.Sort();

            foreach(string storeList in arrayList)
            {
                Console.WriteLine(storeList);
            }

            */

            /*
             Sort():  it is used to sort the data in asscending order 
             */


            // ----------------------------------------------------------------- Reverse() Method ---------------------------------------------------------------------

            /*

            Console.WriteLine("After using Reverse() Method:\n");

            arrayList.Reverse();

            foreach(string storeList in arrayList)
            {
                Console.WriteLine(storeList);
            }

            */

            /*
               Reverse():   it is used to reverse the all elements in  ArrayList
             */


            // ----------------------------------------------------------------- RemoveAt() Method -----------------------------------------------------------------------

            /*
            
            int index;
            Console.WriteLine("Which index value you want to remove");
            index = Convert.ToInt32(Console.ReadLine());

            arrayList.RemoveAt(index);
            Console.WriteLine("After using Remove() Method:\n");

            foreach (string storeList in arrayList)
            {
                Console.WriteLine(storeList);
            }
            */
            /*
             
             RemoveAt():   it is used to remove elements on the basis of index value
             
             */

            // ----------------------------------------------------------------------- IndexOf() ----------------------------------------------------------------------

            /*

            Console.WriteLine("Index Of Method:\n");

            string searchElement;
            int c = 0;
            Console.WriteLine("which element you want to search:");

            searchElement = Console.ReadLine();

            int found = arrayList.IndexOf(searchElement);   // it's searching element index
            Console.WriteLine(found);
            
            for(int i = 0; i < arrayList.Count; i++)
            {
                if(i == found)
                {
                    Console.WriteLine("Found:");
                    c++;
                    break;
                }
            }

            if(c < 1)
            {
                Console.WriteLine("Not found:");
            }

            */

            // ----------------------------------------------------------------- Contains() Method ---------------------------------------------------------------------

            /*

            Console.WriteLine("Contains() Method \n");
            if(arrayList.Contains("vedant"))
            {
                Console.WriteLine("ArrayList contain this name: ");
            }
            else
            {
                Console.WriteLine("ArrayList does not have this name:");
            }

            */

            /*
             Contains():   for checking ArrayList() is have this name or not if have it returns true
             */

            // ---------------------------------------------------------- CopyTo() Method  ------------------------------------------------------------------------------

            /*

            string[] arrayCopyTo = new string[arrayList.Count];

            arrayList.CopyTo(arrayCopyTo);

            Console.WriteLine("After using CopyTo() Method:\n");

            foreach(string storeCopyTo in arrayCopyTo)
            {
                Console.WriteLine(storeCopyTo);
            }


            */

            // ---------------------------------------------------------- TrimSize() Method ----------------------------------------------------------------------------

            /*

            Console.WriteLine("Before using TrimSize() method so then capacity of aaralist is:  " + arrayList.Capacity);

            arrayList.TrimToSize();

            Console.WriteLine("After using TrimSize() Method:\n");

            foreach(string storeTrim in arrayList)
            {
                Console.WriteLine(storeTrim);

            }

            Console.WriteLine("after using TrimSize() method so then capacity of aaralist is:  " + arrayList.Capacity);

            */



            // ------------------------------------------------------------ Repeat() Method  ------------------------------------------------------------------------

            /*

            ArrayList arrayRepeat = ArrayList.Repeat("Rahul",4);   
            foreach(string storeRepeat in arrayRepeat)
            {
                Console.WriteLine(storeRepeat);
            }

            */
            // ------------------------------------------------------------ Remove() Method  -----------------------------------------------------------------------

            /*

            ArrayList arrayRemove = new ArrayList();
            arrayRemove.Add("pindari");
            arrayRemove.Add("nitin killer");
            arrayRemove.Add("nikita mausi");
            arrayRemove.Add("speaking classes run by Rohit");

            Console.WriteLine("Before using Remove():\n");
            foreach(string storeRemove in arrayRemove)
            {
                Console.WriteLine(storeRemove);
            }

            Console.WriteLine("After using Remove():\n");
            arrayRemove.Remove("nikita mausi");                   // it is used to delete element on the basis of specific value 

            foreach(string storeRemove in arrayRemove)
            {
                Console.WriteLine(storeRemove);
            }

            */


            // ---------------------------------------------------------- HashTable ------------------------------------------------------------------------------------


            /*
            

            Hashtable arrayHashTable = new Hashtable();
            string[] keyHash = new string[3];
            string[] valueHash = new string[3];
            string searchKey;
            int c = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nEnter the key:\n");
                keyHash[i] = Console.ReadLine();
                Console.WriteLine("\nEnter the value:\n\n");
                valueHash[i] = Console.ReadLine();
                arrayHashTable.Add(keyHash[i], valueHash[i]);            //  here we are adding the value in the basis of key
            }

            Console.WriteLine("Hashtable value display:\n" + arrayHashTable.Count);   //  here we are counting how many elements in hashtable

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arrayHashTable[keyHash[i]]);
            }

            Console.WriteLine("Which key you want to search:\n");
            searchKey = Console.ReadLine();

            string containValue = (string)arrayHashTable[searchKey];

            Console.WriteLine("\nvalue found on the basis of key:\n " + arrayHashTable[searchKey]);

            Console.WriteLine("\nContain method: \n " + arrayHashTable.Contains(searchKey));      // if key found and it's contain value then it's return boolean value (True)

            Console.WriteLine("\nContains key Method:\n  " + arrayHashTable.ContainsKey(searchKey));    // if key found and it's contain value then it's return boolean value (True)

            Console.WriteLine("\nContains value method: \n  " + arrayHashTable.ContainsValue(containValue));   // if value found then it's return the true 

        //    arrayHashTable.Remove(searchKey);        // remove the element on the basis of key

            Console.WriteLine("\nafter using Remove method : \n");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arrayHashTable[keyHash[i]]);
            }

            Console.WriteLine("\nHashTable  Keys:\n");
            foreach (var key in arrayHashTable.Keys)
            {
                Console.WriteLine(key);
            }

         //   arrayHashTable.Clear();                // it's remove all elemnts

            Console.WriteLine("\nAfter using clear() method :");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("  ===  "+arrayHashTable[keyHash[i]]);
            }

            Console.WriteLine("\n index value on the basis of index:\n");

            string addNewValue;

            Console.WriteLine(searchKey + " is a  key  so i want update here so Enter the new value:\n");
            addNewValue = Console.ReadLine();


           //foreach(string key in arrayHashTable.Keys)
           // {
           //     if((string)key == searchKey)
           //     {
           //         Console.WriteLine("Found key:"+ key+"==="+ key.Length);
           //        // arrayHashTable.Remove(key);
           //        // arrayHashTable.Add(key, addNewValue);
           //         c++;
                    
           //     }
           // }

            
             
             if (arrayHashTable.ContainsKey(searchKey))
            {
                Console.WriteLine("Key Found:");

                arrayHashTable.Remove(searchKey);
                arrayHashTable.Add(searchKey, addNewValue);
                c++;
            }    
            else if(c <1)
            {
                Console.WriteLine("Not found:");
            }


            Console.WriteLine("After updating value on the basis of index:\n");

           for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(arrayHashTable[keyHash[i]]);
            }

            */

            //------------------------------------------------------  Stack(LIFO) -----------------------------------------------------------------------------------------

            /*

            Stack arrayStack = new Stack();

            arrayStack.Push(1);
            arrayStack.Push(2);
            arrayStack.Push(3);
            arrayStack.Push(1);
            arrayStack.Push(4);
            arrayStack.Push(5);                                       // insertion from bottom
            arrayStack.Push(6);
           


            Console.WriteLine("after using push() method: ");
            foreach(int storePush in arrayStack)
            {
                Console.WriteLine(storePush);
            }

            arrayStack.Pop();                                     // deletion from top
            Console.WriteLine("After using pop() Method:\n ");

            foreach (int storePush in arrayStack)
            {
                Console.WriteLine(storePush);
            }


            Console.WriteLine("After using peek() method: \n"+ arrayStack.Peek()+"\n");    // it's retrive top element of stack without removing it

            foreach (int storePush in arrayStack)
            {
                Console.WriteLine(storePush);
            }

            Console.WriteLine("After using contains() method: ");

            Console.WriteLine(arrayStack.Contains(3));     // if stack contain element then it's return the true value

            Console.WriteLine("After using clone() method:\n");

            Object stackClone = arrayStack.Clone();               // doubt in stack clone method


            */


            // ---------------------------------------------------------------------- Queue(FIFO) ----------------------------------------------------------------------------------

            /*

            Queue arrayQueue = new Queue();
            arrayQueue.Enqueue("vedant");
            arrayQueue.Enqueue("abhishek");
            arrayQueue.Enqueue("pindari");
            arrayQueue.Enqueue("baua");
            arrayQueue.Enqueue("vegeta");
            arrayQueue.Enqueue("goku");                        // inserting  value

            Console.WriteLine("After using Enqueue() method:\n");

            foreach(string storeQueue in arrayQueue)
            {
                Console.WriteLine(storeQueue);
            }

            Console.WriteLine("After using Dequeue() Method:\n");
            arrayQueue.Dequeue();                                         // deleting value from top
            arrayQueue.Enqueue("gohan");

            foreach(string storeQueue in arrayQueue)
            {
                Console.WriteLine(storeQueue);
            }

            Console.WriteLine("After using Peek() method: \n");

            Console.WriteLine(arrayQueue.Peek());                            // it's return the top value of queue

            Console.WriteLine("After using contains() method:\n" + arrayQueue.Contains("abhishek"));    // if value match in queue then it's return the true value otherwise false

            Console.WriteLine("After using clear() method:\n");

            arrayQueue.Clear();                                                      // it's remove the all element from queue

            foreach(string storeQueue in arrayQueue)
            {
                Console.WriteLine(storeQueue);
            }

            */


            // ****************************************************************** Genric Class *************************************************************************************

            // ------------------------------------------------------------------ List<T> -----------------------------------------------------------------------------------------

            /*

            List<string> arrayList = new List<string>();

            arrayList.Add("vedant");
            arrayList.Add("abhishek");
            arrayList.Add("vaibhav");
            arrayList.Add("shivam");
            arrayList.Add("sitaram");
            arrayList.Add("ankit");
            arrayList.Add("akash");
            arrayList.Add("akash");
            arrayList.Add(" ");
            arrayList.Add(" ");
            arrayList.Add("ramu");

            Console.WriteLine("After using List.Add() Method:\n" + " Count method : \n" + arrayList.Count);

            foreach (string storeList in arrayList)
            {
                Console.WriteLine(storeList);
            }

            Console.WriteLine("After using Sort() method:\n");
            arrayList.Sort();
            foreach (string storeList in arrayList)
            {
                Console.WriteLine(storeList);
            }

            Console.WriteLine("After using Reverse() method:\n");
            arrayList.Reverse();

            foreach (string storeList in arrayList)
            {
                Console.WriteLine(storeList);
            }

            Console.WriteLine("After using RemoveAt() method:\n");

            arrayList.RemoveAt(2);    // index base
            foreach (string storeList in arrayList)
            {
                Console.WriteLine(storeList);
            }



            Console.WriteLine("After using Remove() method:\n");
            arrayList.Remove("vaibhav");                                       // it's delete specific value

            foreach (var storeList in arrayList)
            {
                Console.WriteLine(storeList);
            }

            */

            // Remove(T item)----->   means specific value



            // --------------------------------------------------------------  SortedList<T>  ------------------------------------------------------------------------------

            /*

            SortedList<int, string> arraySortedList = new SortedList<int, string>();

            arraySortedList.Add(1,"vedant");
            arraySortedList.Add(2, "abhishek");
            arraySortedList.Add(3, "pindari");
            arraySortedList.Add(4, "nikhil");
            arraySortedList.Add(5, "amit");
            arraySortedList.Add(6, "anurag");
            arraySortedList.Add(7, "ankit");
            arraySortedList.Add(8, "ankit");

            Console.WriteLine("After using SortedList.Add(): \n");

            foreach(KeyValuePair<int,string> storeSorted in arraySortedList)

            {
                Console.WriteLine(storeSorted);
            }

            Console.WriteLine("After using ContainsKey() Method:\n ");

            Console.WriteLine(arraySortedList.ContainsKey(2));   // if key found then it's return the true otherwise it's return false

            Console.WriteLine("After using ContainsValue() Method:\n");

            Console.WriteLine(arraySortedList.ContainsValue("vedant"));    // if value already exist then it's return true otherwise false

            Console.WriteLine("After using IndexOfKey() Method:\n");

            Console.WriteLine(arraySortedList.IndexOfKey(6));              // if key found on the basis of key then it's return the index value of key

            Console.WriteLine("After using IndexOfValue() Method:\n");

            Console.WriteLine(arraySortedList.IndexOfValue("abhishek"));   // if value matched then it's return the index value on the basis of value


            Console.WriteLine("keys retriving:\n");

            foreach (int storeSorted in arraySortedList.Keys)          // here we are retriving keys  using Keys() method
            {
                Console.WriteLine(storeSorted);
            }

            Console.WriteLine("keys values retriving:\n");

            foreach (string storeSorted in arraySortedList.Values)          // here we are retriving keys value  using Values() method
            {
                Console.WriteLine(storeSorted);
            }

            */


            // --------------------------------------------------------------------------- List<T> -----------------------------------------------------------------------------

            /*

            List<string> arrayListgen = new List<string>();

            arrayListgen.Add("vedant");
            arrayListgen.Add("abhishek");
            arrayListgen.Add("pindari");
            arrayListgen.Add("nitin");
            arrayListgen.Add("misty");
            arrayListgen.Add("tisty");
            arrayListgen.Add("");
            arrayListgen.Add("amar");
            

            Console.WriteLine("After using List.Add() method:\n");

            foreach(string storeListgen in arrayListgen)
            {
                Console.WriteLine(storeListgen);
            }

            Console.WriteLine("After using Sort() Method:\n");

            arrayListgen.Sort();

            foreach(string storeListgen in arrayListgen)
            {
                Console.WriteLine(storeListgen);
            }


            Console.WriteLine("After using Reverse() Method:\n");

            arrayListgen.Reverse();

            foreach (string storeListgen in arrayListgen)
            {
                Console.WriteLine(storeListgen);
            }

            Console.WriteLine("After using Remove() Method:\n");

            arrayListgen.Remove("misty");     // it's remove element on the basis of matching value

            foreach (string storeListgen in arrayListgen)
            {
                Console.WriteLine(storeListgen);
            }


            Console.WriteLine("After using Remove() Method:\n");

            arrayListgen.RemoveAt(2);     // it's remove element on the basis of index value

            foreach (string storeListgen in arrayListgen)
            {
                Console.WriteLine(storeListgen);
            }


            Console.WriteLine("After using Copy() Method:\n");

            string[] copyList = new string[arrayListgen.Count];

            arrayListgen.CopyTo(copyList,0);     // it's remove element on the basis of index value

            foreach (string storeListgen in copyList)
            {
                Console.WriteLine(storeListgen);
            }



            */




        }


    }
}
