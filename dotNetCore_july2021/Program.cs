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
            string path1 = "c:\\Documents\\dot_net_core.doc";
            string path2 = @"c:\Documents\dot_net_core.doc";

            //Regex re = new Regex(@"^[a-zA-Z_]+$");
            //Console.WriteLine(re.IsMatch("ApP_l_Es"));
            PrintIsValid("Apples_123", @"^[a-zA-Z_0-9]+$");

            /*
            ConsoleKeyInfo cki;

            while (true)
            {

                Console.WriteLine("do something........");
                
                Console.WriteLine("Press ESC to end or any key to try again.");
                cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
            */
        }
    }
}
