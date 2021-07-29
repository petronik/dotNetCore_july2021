using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using static System.Console;

namespace dotNetCore_july2021
{
    
    class Program
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

            foreach (Shape item in loadedShapesXml)
            {
                WriteLine($"{item.GetType().Name} is {item.Color} and has an area of { item.Area}");
            }
        }

        public static T FromXmlFile<T>(string file)
        {
            XmlSerializer xmls = new XmlSerializer(typeof(T));
            var xmlContent = File.ReadAllText(file);

            using (StringReader sr = new StringReader(xmlContent))
            {
                return (T)xmls.Deserialize(sr);
            }
        }

        public static void ToXmlFile<T>(string file, T obj)
        {
            using (StringWriter sw =
                new StringWriter(new StringBuilder()))
            {
                XmlSerializer xmls = new XmlSerializer(typeof(T));
                xmls.Serialize(sw, obj);
                File.WriteAllText(file, sw.ToString());
            }
        }

    }
}
