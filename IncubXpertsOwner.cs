using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class IncubXpertsOwner
    {
        public string Co_Founder_First = "Preetam";
        public string Co_Founder_Second = "Rahul";
        public string Co_Founder_Third = "Anish";
        public string Co_Founder_Fourth= "Amit";

        public void Founder()
        {
            Console.WriteLine(Co_Founder_First + "\n" + Co_Founder_Second + "\n" + Co_Founder_Third + "\n" + Co_Founder_Fourth);
        }
    }
    class BanerBranch:IncubXpertsOwner
    {
        public void Description()
        {
            Console.WriteLine("Welcome to IncubXperts this is our first branch\n");
            Console.WriteLine("These are our co-founder:\n");
            this.Founder();
        }
    }
    class NandedCityBranch : IncubXpertsOwner
    {
        public void Description()
        {
            Console.WriteLine("\nWelcome to IncubXperts this is our second branch");
            Console.WriteLine("These are our co-founder:\n");
            this.Founder();
        }
    }
    class USABranch : IncubXpertsOwner
    {
        public void Description()
        {
            Console.WriteLine("\nWelcome to IncubXperts this is our second branch");
            Console.WriteLine("These are our co-founder:\n");
            this.Founder();
        }
    }

}
