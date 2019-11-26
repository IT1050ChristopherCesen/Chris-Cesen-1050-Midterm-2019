using System;

namespace Chris_Cesen_1050_Midterm_2019
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Question 1
             Selection statements. Examples of these are if and if..else statements in C#.  They will only execute if certain conditions are met.
	        
            Iteration Statements.  Examples are do, while, and for.  They will execute at least one time.
	        
            
            Jump Statements Examples are berak and goto.  When the code reaches a certain point, the computer will execute a certain line of code or go to a specific part of the statement.

            
             */
            //Question 2
            /*
            bool keepLooping = true;
            while (keepLooping == true)
            {
                Console.WriteLine(keepLooping);
            }
            */

            //Question 3
            /*
            int i = 2;
            while (i < 16)

            {

                Console.WriteLine("[" + i + "]");
                int control = 2;

                while (i < 64)
                {
                    Console.WriteLine("[" + ((i * control) * 2) + "]");
                    i = i * 2;

                }
                */

            //Question 4
            /*
            for (int i = 49; i > 0; i = i - 1)

            {
                Console.Write(i + ",");

            }
            */


            //Question 5

            /*
            {
                int i = 1;
                while (i < 22)
                {
                    if (i % 2 == 1)
                        Console.Write(i + " ");

                    i++;

                }
                */


                //Question 6
                /*
                int n = 8;
                int i = 10; // initialize
                do
                {
                    Console.Write("*");
                    i++; // update!
                } while (i < n); // test condition
                */


                /*
                int n = 8;
                int i = 10;

                while (n < i)
                {
                    Console.WriteLine("*");
                    i++;
                }
                */


                //Question 7
                


                bool icyRain = false;
        bool tornadoWarning = false;
        if (icyRain == true && (tornadoWarning == true))
        {
            Console.WriteLine("Better stay indoors.");
        }
        if (icyRain == false && (tornadoWarning == true))
        {
            Console.WriteLine("Better stay indoors.");
        }

        if (icyRain == true && (tornadoWarning == false))
        {
            Console.WriteLine("Better stay indoors.");
        }

        if (icyRain == false && (tornadoWarning == false))
        {
            Console.WriteLine("Let's go outside");
        }
        
            }
        }
    }



 
