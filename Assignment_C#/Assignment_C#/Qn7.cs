using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_C_
{
    internal class Qn7
    {
        static void Main()
        {
            for (int i = 0; i <= 625; i++)
            {
                int square = i * i;
                Console.Write(square + " ");

                if (square == 625)
                    break;
            }

            Console.ReadLine(); // Pause to see the result
        }
    }
}
