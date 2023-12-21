using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Assignment_C_
{
    internal class Qn12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number :");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number :");
            int num2=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int num3=int.Parse(Console.ReadLine());
            if(num1>num2 && num1 > num3)
            {
                Console.WriteLine($" Largest number is :{num1}");
            }
            else if(num2>num1 && num2 > num3) {
                Console.WriteLine($"largest number is :{num2}");
            }
            else
            {
                Console.WriteLine($"largest number is ::{num3}");
            }
        }
    }
}
