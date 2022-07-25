using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------- Polymorphism ---------------------------------------------------
            
            //  overridding example

            KarveNagar MultiLevel = new Hinjewadi();
            MultiLevel.Destination();

            // OverLoading Example
            MultiLevel.Display(8);

            // -------------------------------------------- Multilevel Inheritance -------------------------------------------

            Hinjewadi MultiLevel1 = new Hinjewadi();
            MultiLevel1.Destination();                                                   // parent
            MultiLevel1.Distance();                                                      // child 
            MultiLevel1.View();                                                          // sub-child
            Console.WriteLine("Total Distance covered:  " + MultiLevel1.distance);       // sub-sub-child


            //----------------------------------------------------------- Hierarchical --------------------------------------------------------

            NandedCityBranch owner = new NandedCityBranch();
            owner.Description();


            //------------------------------------------------ Multiple Inheritance ------------------------------------------------------------

            Users msg = new Users();
            msg.Message();
        }
    }
}
