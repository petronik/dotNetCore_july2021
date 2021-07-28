using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace dotNetCore_july2021
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var listOfShapes = new List<Shape>
                                {
                                new Circle { Colour = "Red", Radius = 2.5 },
                                new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0 },
                                new Circle { Colour = "Green", Radius = 8 },
                                new Circle { Colour = "Purple", Radius = 12.3 },
                                new Rectangle { Colour = "Blue", Height = 45.0, Width = 18.0 }
                                };

            Console.WriteLine("End of programm.");
        }
    }
}
