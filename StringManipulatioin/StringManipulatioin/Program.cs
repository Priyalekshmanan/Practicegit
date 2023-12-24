using System;

namespace StringManipulatioin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment -2");
          //declaring a string
                string originalString = "The quick brown fox jumps over the lazy dog";

           //Print the character at the 12th index
                char Index12 = originalString[12];
                Console.WriteLine($" Character at index 12: {Index12}");

           // Check whether the String contains the word "is"
                bool containsIs = originalString.Contains("is");
                Console.WriteLine($" Does the string contains the word 'is': {containsIs}");

           // Add the string "and killed it" to the existing string
                originalString += " and killed it";
                Console.WriteLine($"Updated string: {originalString}");

           // Check whether the String ends with the word "dogs"
                bool endsWithDogs = originalString.EndsWith("dogs");
                Console.WriteLine($" Does the string ends with 'dogs': {endsWithDogs}");

           //Check whether the String is equal to "The quick brown Fox jumps over the lazy Dog"
                bool isEqual = originalString.Equals("The quick brown Fox jumps over the lazy Dog", StringComparison.OrdinalIgnoreCase);
                Console.WriteLine($" Does the String is equal: {isEqual}");

            //Check whether the String is equal to "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG"
            bool var_name = originalString.Equals("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG");
            Console.WriteLine($"Does sthe string is equal:{var_name}");

            //Find the length of the string
            int Stringlength=originalString.Length;
            Console.WriteLine($"Length oof the string :{Stringlength}");

            //matches ie equal to case-sensitivity string as well
            //Check whether the String matches to “The quick brown Fox jumps over the lazy Dog”.
            bool StringMatch = originalString.Equals("The quick brown Fox jumps over the lazy Dog");
            Console.WriteLine($"Does the string match with the original string: {StringMatch}");

            //Replace the word “The” with the word “A”.
            string StringReplace = originalString.Replace("The", "A");
            Console.WriteLine($"The replaced string : {StringReplace}");

            //Split the above string into two such that two animal names do not come together.
            string[] splitStrings = originalString.Split(new[] { " " }, StringSplitOptions.None);
            Console.WriteLine("Split Strings: " + string.Join(", ", splitStrings));

            //Print the animal names alone separately from the above string.
            string Stringanimal = splitStrings[3] + " " + splitStrings[8];
            Console.WriteLine($"Animal alone from the string is :{Stringanimal}");

            //Print the above string in completely lower case.
            string Stringlow = originalString.ToLower();
            Console.WriteLine($"Lower case :{Stringlow}");

            //Print the above string in completely upper case.
            string Stringup=originalString.ToUpper();
            Console.WriteLine($" Upper string :{Stringup}");

            //Find the index position of the character “a”.
            int position=originalString.IndexOf('a');
            Console.WriteLine($"The position of a is :{position}");

            //Find the last index position of the character “e”.
            int lastposition=originalString.LastIndexOf("e");
            Console.WriteLine($"The last index of e is :{lastposition}");

            //Prompt the user to enter the home directory of Tomcat server. To the path that user enters, add another path to  WebApps/MyApps/Images  directory and display it in the console. Use verbatim string literals. 
            Console.WriteLine("enter the home directory of Tomcat server");
            string cathome =Console.ReadLine();
            string imagePath = $@"{cathome}\WebApps\MyApps\Images";
            Console.WriteLine($"Path with the Directory: { imagePath}");

            //poem
            const string poem = @"I WANDER'D lonely as a cloud
                                That floats on high o'er vales and hills,
                                When all at once I saw a crowd,
                                A host, of golden daffodils;Beside the lake, beneath the trees,
                                Fluttering and dancing in the breeze.";
            Console.WriteLine(poem);

        }
    }


    }

