using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_C_
{
    internal class Qn10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int number =int.Parse(Console.ReadLine());
            //int number = 20;
            for(int i = 1; i<= 20; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x{i} = {result}");
            }
        }
    }
}
