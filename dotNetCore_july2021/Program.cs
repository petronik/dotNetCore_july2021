using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace dotNetCore_july2021
{
    class Program
    {

        static void bunchOfThreeToWords(string part) // part = 185
        {
            string words = "";
            if (part.Length < 3)
            {
                words = part.Insert(1, "F");
            }

            Console.WriteLine(words);
        }
            static void Main(string[] args)
        {
            string input = "18500000000000000000000000000";
            BigInteger bi = BigInteger.Parse(input);

            string num = bi.ToString("N0");

            Console.WriteLine(" This is num:" + num);

            string[] partsByThree = num.Split(",");

            Console.WriteLine(partsByThree[0]);
            foreach (var part in partsByThree)
            {
                Console.WriteLine("PART IS " + part);
                //bunchOfThreeToWords(part);
            }





            Console.WriteLine("End of program.");
        }
    }
}
