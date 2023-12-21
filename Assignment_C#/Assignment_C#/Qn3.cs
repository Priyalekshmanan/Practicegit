using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_C_
{
    internal class Qn3
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "enter the first number");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num1 = int.Parse(Console.ReadLine());
            for(int i=num; i<=num1; i++) {
                Console.WriteLine(i);
            }

        }
    }
}
