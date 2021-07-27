using System;
using System.Text;

namespace StringBuilder2
{
    class Program
    {
        static void Main(string[] args)
        {
            string passage = @"I do not like them
                                In a house.
                                I do not like them
                                With a mouse.
                                I do not like them
                                Here or there.
                                I do not like them
                                Anywhere.
                                I do not like green eggs and ham.
                                I do not like them, Sam - I - am.";

            StringBuilder sbp = new StringBuilder(passage);

            sbp.Replace("not ", null);

            Console.WriteLine(sbp.ToString());

        }
    }
}