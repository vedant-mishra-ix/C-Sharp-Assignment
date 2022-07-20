using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Statement_Assignment_Basic
{
    class Properties
    {
        // public string first_name="vedant";   it is a public we can access directly in another class
        string first_name;

        public string name
        {
            set
            {
                first_name = value;
            }
            get
            {
                return first_name;
            }
        }
        public void Show()
        {
            Console.WriteLine("Proprtie class");
        }
        
    }
}
