using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_C_
{
    internal class Qn9
    {
        static void Main()
        {
            int first = 0, Second = 1, third, number;
            Console.Write("Enter the number of elements : ");
            number = int.Parse(Console.ReadLine());
            if (number < 2)
            {
                Console.Write("Please Enter a number greater than two");
            }
            else
            {
                //First print first and second number
                Console.Write(first + " " + Second + " ");

                //Starts the loop from 2 because 0 and 1 are already printed
                for (int i = 2; i < number; i++)
                {
                    third = first + Second;
                    Console.Write(third + " ");
                    first = Second;
                    Second= third;
                }
            }

            Console.ReadKey();
        }
    }
}
