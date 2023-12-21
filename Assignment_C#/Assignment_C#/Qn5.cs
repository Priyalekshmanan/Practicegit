using System;

namespace Assignment_C_
{
    internal class Qn5
    {
        static void Main(string[] args)
        {
            {
                int[] arr = new int[5];
                int ocount = 0, ecount = 0;

                Console.WriteLine("Enter Array Values");
                for (int i = 0; i < 5; i++)
                {
                    arr[i] = Convert.ToInt16(Console.ReadLine());
                }

                for (int i = 0; i < 5; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        ecount++;
                    }
                    else
                    {
                        ocount++;
                    }
                }
                Console.WriteLine("Total Even Numbers:" + ecount);
                Console.WriteLine("Total Odd Numbers:" + ocount);
            }    
        }
    }
}
