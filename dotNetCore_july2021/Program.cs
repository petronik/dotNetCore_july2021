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
            PrintIsValid("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", @"^a{3,}$");
            PrintIsValid("1324", @"^[0-9]{3}$");
            // mark@gmail.ca
            // PrintIsValid("...", @"^\.{3}$");
            PrintIsValid("mark.smith@gmail.gv.ca",
                @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

            /*
            ConsoleKeyInfo cki;
            string customRegEx = "";
            string customVal = ;
            Console.WriteLine("Enter a regular expression (or press ENTER to use the default):");
            cki = Console.ReadKey();
            switch (cki.Key)
            {
                case ConsoleKey.Enter: customRegEx = "^[a - z] +$"; break;
                case ConsoleKey.Escape: break;
                default: customRegEx = Console.ReadLine(); break;
            }


            Console.WriteLine("Enter some input: ");
            customVal = Console.ReadLine();
            PrintIsValid(customVal, customRegEx);
             */

            /*
            ConsoleKeyInfo cki;
            string customRegEx = string.Empty;
            string customVal = string.Empty;
            while (true)
            {

                Console.WriteLine("Enter a regular expression "+
                    " (or press ENTER to use the default):");

                customRegEx = Console.ReadLine();
                
                if (customRegEx == "")
                {
                    customRegEx = @"^[a-z]+$";
                }

                Console.WriteLine($"customRegEx = {customRegEx}");

                Console.WriteLine("Press ESC to end or any key to try again.");
                cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
            */

            /*
            string path1 = "c:\\Documents\\dot_net_core.doc";
            string path2 = @"c:\Documents\dot_net_core.doc";

            //Regex re = new Regex(@"^[a-zA-Z_]+$");
            //Console.WriteLine(re.IsMatch("ApP_l_Es"));
            PrintIsValid("Apples_123", @"^[a-zA-Z_0-9]+$");
            */

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
