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
            //string words = "";
            //if (part.length < 3)
            //{
            //    words = part.insert(1, "f");
            //}

            //Console.WriteLine(words);
        }
            static void Main(string[] args)
        {
            string input = "18500000000000000000000000000";
            Console.WriteLine(input);
            BigInteger bi = BigInteger.Parse(input);

            string num = bi.ToString("N0");

            Console.WriteLine(" This is num:" + num);

            string[] partsByThree = num.Split(" ");// 


            Console.WriteLine("This is first index " + partsByThree[0]);
            foreach (var part in partsByThree)
            {
                Console.Write("PART IS " + part);
                //bunchOfThreeToWords(part);
            }
            char ch = ' ';
            Console.WriteLine( "Character" + ch);


            //string[] numbersArr = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            //string[] tensArr = new string[] { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };
            //string[] suffixesArr = new string[] { "thousand", "million", "billion", "trillion", "quadrillion", "quintillion", "sextillion", "septillion", "octillion", "nonillion", "decillion", "undecillion", "duodecillion", "tredecillion", "Quattuordecillion", "Quindecillion", "Sexdecillion", "Septdecillion", "Octodecillion", "Novemdecillion", "Vigintillion" };

            //switch (counter)
            //{
            //    case 1: words += NumWords(decPart) + " tenths"; break;
            //    case 2: words += NumWords(decPart) + " hundredths"; break;
            //    case 3: words += NumWords(decPart) + " thousandths"; break;
            //    case 4: words += NumWords(decPart) + " ten-thousandths"; break;
            //    case 5: words += NumWords(decPart) + " hundred-thousandths"; break;
            //    case 6: words += NumWords(decPart) + " millionths"; break;
            //    case 7: words += NumWords(decPart) + " ten-millionths"; break;
            //}

            Console.WriteLine("End of program.");
        }
    }
}
