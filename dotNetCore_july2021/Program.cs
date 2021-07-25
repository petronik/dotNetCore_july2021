using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace dotNetCore_july2021
{
    class Program : BigInteger2
    {
        static void Main(string[] args)
        {
            string input = "18500000000000000123000715";
            
            BigInteger bi = BigInteger.Parse(input);

            string num = bi.ToString("N0");

            string[] partsByThree = num.Split(" ");// 

            string ourNumber = string.Empty;

            for (var i = 0; i < partsByThree.Length; ++i)
            {
                string str = ThreeToWords(partsByThree[i]);

                str = string.IsNullOrEmpty(str) ? ""
                    : str + " " + suffixesArr[partsByThree.Length - i - 1] + " ";
                ourNumber += str;
            }
            Console.WriteLine($"ourNumber is {ourNumber}");

            

            Console.WriteLine("End of program.");
        }
    }
}
