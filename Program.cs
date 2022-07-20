using System;
using System.Linq;
using Control_Statement_Assignment_Basic;

namespace control_statement_assignment_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Properties obj = new Properties();

            obj.Show();

            obj.name = "abhishek";

            Console.WriteLine("Private properties:"+ obj.name);

            int a = 10;

           // int b = a + ++a + a++;

            Console.WriteLine(a + " = " + ++a + " = " + a++);

            // Console.WriteLine("Prefix and Postfix: " + b);

            //   Console.WriteLine("Properties value: "+ ved.first_name);

            /*
                                                                            * if-else statement
             
            int age;

            Console.WriteLine("Hi Please Enter The Your Age:");

            age = Convert.ToInt32(Console.ReadLine());

            if(age > 18)
            {
                Console.WriteLine("You are eligible for voting");
            }
            else
            {
                Console.WriteLine("You are not eligible");
            }
            */

            /*                                                               nested if statement
                                                             
            string first_name;

            int roll_no;

            Console.WriteLine("Please enter you roll no:(1 to 10):");

            roll_no = Convert.ToInt32(Console.ReadLine());

            if(roll_no < 10)
            {
                Console.WriteLine("Now Please enter your name (Type: vedant)");

                first_name = Console.ReadLine();

                if(first_name == "vedant")
                {
                    Console.WriteLine("Now you can see your details");
                }
                else
                {
                    Console.WriteLine("user name is not matched");
                }
            }
            else
            {
                Console.WriteLine("please enter the valid rool no");
            }
            */

            /*
                                                                            if-else-if ladder
             
            int marks;

            int roll_no;

            Console.WriteLine("Please enter the student roll no (1 to 10):");

            roll_no = Convert.ToInt32(Console.ReadLine());

            if(roll_no < 10)
            {
                Console.WriteLine("Please enter the student marks for displaying grades:");

                marks = Convert.ToInt32(Console.ReadLine());

                if(marks >= 90 && marks <= 100)
                {
                    Console.WriteLine("Congrats you got A+ Grade");
                }
                else if(marks >= 80 && marks < 90)
                {
                    Console.WriteLine("Congrats you got A Grade");
                }
                else if(marks >= 70 && marks < 80)
                {
                    Console.WriteLine("Congrats you got B+ Grade");
                }
                else if(marks >= 65 && marks < 70)
                {
                    Console.WriteLine("Congrats you got B Grade");
                }
                else if(marks >= 50 && marks < 65)
                {
                    Console.WriteLine("Congrats you got C+ Grade");
                }
                else if(marks >= 35 && marks < 50)
                {
                    Console.WriteLine("Congrats you got C Grade");
                }
                else if(marks < 35)
                {
                    Console.WriteLine("Do work hard and change the mindset of others on you");
                }
                else
                {
                    Console.WriteLine("Please enter the valid Marks");
                }
            }
            else
            {
                Console.WriteLine("please enter the valid rool no:");
            }
            */

            /*
             *                                                                Switch case 
             
            string color;

            Console.WriteLine("Enter the first letter of color (g,b,r,w):");

            color = Console.ReadLine();

            switch(color)
            {
                case "g":
                    Console.WriteLine("You are plants lover");
                    break;
                case "b":
                    Console.WriteLine("You are sky lover");
                    break;
                case "r":
                    Console.WriteLine("Your are so aggressive");
                    break;
                case "w":
                    Console.WriteLine("You are peace lover");
                    break;
                default:
                    Console.WriteLine("You enter the invalid color :");
                    break;
            }
            */

            /*
             *                                                               For Loop 
             
            int number;

            int fact = 1;

            Console.WriteLine("Which number you want to know factorial:");

            number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial number of "+ number +" is " + fact);
            */

            /*
             *                                                                 While Loop
             
            int number;

            int fact = 1;

            int i = 1;

            Console.WriteLine("Which number you want to know factorial:");

            number = Convert.ToInt32(Console.ReadLine());

            while(i <= number)
            {
                fact = fact * i;

                i++;
            }
            Console.WriteLine("Factorial number of " + number + " is " + fact);
            */

            /*
             *                                                               Do While Loop
             
            int number;

            int fact = 1;

            int i = 1;

            Console.WriteLine("Which number you want to know factorial:");

            number = Convert.ToInt32(Console.ReadLine());

            do
            {
                i++;

                Console.WriteLine("Factorial number of " + number + " is " + fact);

                fact = fact * i;
                
            } while (i <= number);
            */


            /*
             *                                                              ForEach Loop 
             
            int number;

            int fact = 1;

            Console.WriteLine("Which number you want to know factorial:");

            number = Convert.ToInt32(Console.ReadLine());

            foreach(int i in Enumerable.Range(1,number))
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial number of " + number + " is " + fact);
            */

            int Age_store = Age(19);

            Console.WriteLine("Age Store value: " + Age_store);

            int Age(int age)
            {
                if(age > 18)
                {
                    Console.WriteLine("You are eligible for voting");
                    return age;                           // if condition ke base per value return krega
                }
                else                                                                
                {
                    Console.WriteLine("you are not eligible for voting");
                    return age;
                }
                return 0;                                  // agar hum yaa per return age likte to jo value humm pass krte  wai value return krta hmesa
            }

            //    float a;

            //    a = float.Parse(Console.ReadLine());

            //   Console.WriteLine("type cast: " + a);  // for checking type casting

            string s = "ved";

        //  string s1 = new string("ved");

            string s2 = "ved";

           // Console.WriteLine("String literal: " + s + " String by new kwyword: " + s1);

            //if(s == s1)
            //{
            //    Console.WriteLine("Value matched");     same value match ho rhi
            //}

            if(s == s2)
            {
                Console.WriteLine("Value matched");
            }
            else
            {
                Console.WriteLine("Value does not matched");
            }

        }
    }
}
