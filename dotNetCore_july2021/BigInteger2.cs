using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dotNetCore_july2021
{
    class BigInteger2
    {
        private static readonly String[] unitsMap = new[] {
            "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
            "seventeen", "eighteen", "nineteen"
        };

        private static readonly String[] tensArr = new string[] {
            "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };

        public static readonly string[] suffixesArr = new string[] { "", "thousand", "million", "billion",
            "trillion", "quadrillion", "quintillion", "sextillion", "septillion", "octillion",
            "nonillion", "decillion", "undecillion", "duodecillion", "tredecillion",
            "Quattuordecillion", "Quindecillion", "Sexdecillion", "Septdecillion",
            "Octodecillion", "Novemdecillion", "Vigintillion" };
         public static string ThreeToWords(string part) // part = 185
        {
            part = part.PadLeft(3, '0');
            string res = string.Empty;
            if (part[0] != '0')
            {
                res += unitsMap[Convert.ToInt32(part[0].ToString())]
                    + " hundred";
            }
            if (part[1] == '1')
            {
                int ind = Convert.ToInt32(part[1].ToString() + part[2].ToString());
                string teen = unitsMap[ind];

                res += string.IsNullOrEmpty(res) ? teen : " and " + teen;
            }
            else
            {
                int ind = Convert.ToInt32(part[1].ToString());
                int ind2 = Convert.ToInt32(part[2].ToString());
                string tens = tensArr[ind];
                string single = unitsMap[ind2];

                res += string.IsNullOrEmpty(res) ?
                    string.IsNullOrEmpty(tens) ? single : tens + " " + single
                    : string.IsNullOrEmpty(tens) && string.IsNullOrEmpty(single) ? ""
                    : " and " + tens + " " + single;
            }
            return res;
        }


    }
}
