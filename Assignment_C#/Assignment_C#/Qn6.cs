using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_C_
{
    internal class Qn6
    {
        static void Main()
        {
            Console.Write("Enter the temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"Temperature in Celsius: {celsius}°C");

            Console.ReadLine(); 
        }
    }
}
