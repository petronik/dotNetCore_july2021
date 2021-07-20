using System;
using System.Text.RegularExpressions;

namespace dotNetCore_july2021
{
    class Program
    {
        static void PrintIsValid(string input, string pattern)
        {
            Regex re = new Regex($@"{pattern}");

            Console.WriteLine($"{input} matches {pattern}: {re.IsMatch(input)}");
        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            while (true)
            {
                string customRegEx = "";
                string customVal = "";
                Console.WriteLine("Enter a regular expression (or press ENTER to use the default):");
                customRegEx = Console.ReadLine();
                if(customRegEx == "")
                {
                    customRegEx = "^[a-z]+$";   
                }
                Console.WriteLine("Enter some input: ");
                customVal = Console.ReadLine();
                PrintIsValid(customVal, customRegEx);

                Console.WriteLine("\nPress ESC to end or any key to try again.");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}
