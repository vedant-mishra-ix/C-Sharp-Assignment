using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Case Study: I want to go karve nagar to hinjewadi via bus there are  4 bus stop  kavenagr , varze , chandni Chowk , hinjewadi and my current location is karve nagar  so use this scenario and make classes  

             and perform inheritance
 
 */


namespace Inheritance
{
    class KarveNagar
    {
        public virtual void Destination()
        {
            Console.WriteLine("Karve nagar to varze");
        }

        public static int  distance = 100;

        public int Display( int a)
        {
            Console.WriteLine("karve display" + a);
            return 0;
        }
        public double Display(double b)
        {
            Console.WriteLine("Hinjewadi display" + b);
            return 0;
        }

    }
    class Varze:KarveNagar
    {
        public override void Destination()
        {
            Console.WriteLine("varze to  chandni chowk");
        }
        public void Distance()
        {
            Console.WriteLine("covered 2 km");
        }

        public static int distance = 100 + KarveNagar.distance;
    }

    class ChandniChowk:Varze
    {
        public override void Destination()
        {
            Console.WriteLine("chandni chowk to hinjewadi");
        }
        public void View()
        {
            Console.WriteLine("Awsome");
        }

        public static int distance = 100 + Varze.distance;
    }
    class Hinjewadi:ChandniChowk
    {
        public override void Destination()
        {
            Console.WriteLine("Welcome to hinjewadi");
        }

        public int distance = 100 + ChandniChowk.distance;
    }


}
