using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_C_
{
    internal class Qn14
    {
        static void Main(string[] args)
        {
            int numberOfMarks = 10;
            int[] marks = new int[numberOfMarks];

            // Accept 10 marks from the user
            for (int i = 0; i < numberOfMarks; i++)
            {
                Console.Write($"Enter mark #{i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }
            //total
            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }

            // Calculate average
            double average = (double)total / numberOfMarks;

            // Display results using switch
            Console.WriteLine("Results:");
            Console.WriteLine("1. Display Total");
            Console.WriteLine("2. Display Average");
            Console.WriteLine("3. Display Minimum and Maximum Marks");
            Console.WriteLine("4. Display Marks in Ascending Order");
            Console.WriteLine("5. Display Marks in Descending Order");
            Console.Write("Choose an option (1 to 5): ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Total: {total}");
                    break;

                case 2:
                    Console.WriteLine($"Average: {average}");
                    break;

                case 3:
                    int minMark = marks[0];
                    int maxMark = marks[0];

                    foreach (int mark in marks)
                    {
                        minMark = Math.Min(minMark, mark);
                        maxMark = Math.Max(maxMark, mark);
                    }

                    Console.WriteLine($"Minimum Mark: {minMark}");
                    Console.WriteLine($"Maximum Mark: {maxMark}");
                    break;

                case 4:
                    Array.Sort(marks);
                    Console.WriteLine("Marks in Ascending Order:");
                    foreach (int mark in marks)
                    {
                        Console.Write($"{mark} ");
                    }
                    break;

                case 5:
                    Array.Sort(marks);
                    Array.Reverse(marks);
                    Console.WriteLine("Marks in Descending Order:");
                    foreach (int mark in marks)
                    {
                        Console.Write($"{mark} ");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            


        }
    }
}
