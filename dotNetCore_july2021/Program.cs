using System;
using System.Collections;
using System.Numerics;
using System.Text.RegularExpressions;

namespace dotNetCore_july2021
{
    class Program
    {
        static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
            {
                Console.Write(" {0}", obj);
            }
        }
        static void ToWords(string numb)
        {
            ArrayList toWord = new ArrayList();
            for (int i = 0; i < numb.Length; i++)
            {
                char ch = numb[i];
                switch (ch)
                {
                    case (char)1: toWord.Add("one") ; break;
                    case (char)2: toWord.Add("two"); break;
                    case (char)3: toWord.Add("three"); break;
                    case (char)4: toWord.Add("four"); break;
                    case (char)5: toWord.Add("five"); break;
                    case (char)6: toWord.Add("six"); break;
                    case (char)7: toWord.Add("seven"); break;
                    case (char)8: toWord.Add("eight"); break;
                    case (char)9: toWord.Add("nine"); break;
                }
            }
            Console.Write($"{numb} is " );
            PrintValues(toWord);
        }

        static void Main(string[] args)
        {
            ToWords("123");

        }
    }
}
