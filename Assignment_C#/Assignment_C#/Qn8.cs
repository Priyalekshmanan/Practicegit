using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_C_
{
    internal class Qn8
    {
        static void Main(string[] args)
        {
            
            int i, fact = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
            

        }
    }
}
