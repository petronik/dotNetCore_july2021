using System.Collections.Generic;
using static System.Console;

namespace dotNetCore_july2021
{
    class Program : Shape
    {
        
        static void Main(string[] args)
        {
            var listOfShapes = new List<Shape>
            {
                new Circle { Color = "Red", Radius = 2.5 },
                new Rectangle { Color = "Blue", Height = 20.0, Width = 10.0 },
                new Circle { Color = "Green", Radius = 8 },
                new Circle { Color = "Purple", Radius = 12.3 },
                new Rectangle { Color = "Blue", Height = 45.0, Width = 18.0 }
            };

            string xmlFile = "shapes.xml";
            ToXmlFile(xmlFile, listOfShapes);
            List<Shape> loadedShapesXml = FromXmlFile<List<Shape>>("shapes.xml");
            foreach(Shape item in loadedShapesXml)
            {
                WriteLine($"{item.GetType().Name} is {item.Color} and has an area of {item.Area}");
            }

            WriteLine("Hello World");
        }
    }
}
