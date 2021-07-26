using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace dotNetCore_july2021
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number\n" +
                "Hint: 18500000000000000123000715");
            string input = Console.ReadLine();
            
            BigInteger bi = BigInteger.Parse(input);
            bi.ToWords();
            Console.WriteLine("End of program.");
        }
    }
}
