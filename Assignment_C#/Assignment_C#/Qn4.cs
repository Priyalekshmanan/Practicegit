using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_C_
{
    internal class Qn4
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "enter the number");
            int num=int.Parse(Console.ReadLine());
            if(num%2==0 )
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
