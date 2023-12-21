using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Xml.Linq;

namespace Assignment_C_
{
    internal class Qn18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the word");
            string word=Console.ReadLine();
            string reverse = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }

            if (word == reverse)
            {
                Console.WriteLine($"{word} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"{word} is not Palindrome");
            }
        }
    }
}
