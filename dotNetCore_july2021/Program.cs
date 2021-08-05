using dotNetCore_july2021.DbModels;
using static System.Console;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Text;

namespace dotNetCore_july2021
{
    class Program
    {
        private static readonly salecoContext _context = new salecoContext();

        static void Main(string[] args)
        {
            var products = _context.Products.ToList();
            foreach(var p in products)
            {
                WriteLine($"{p.PCode} {p.PDescript} {p.PInDate} {p.PPrice} ");
            }

            string xmlProducts = "products.xml";
            ToXmlFile(xmlProducts, products);

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
            using (StringWriter sw = new StringWriter(new StringBuilder()))
            {
                XmlSerializer xmls = new XmlSerializer(typeof(T));
                xmls.Serialize(sw, obj);
                File.WriteAllText(file, sw.ToString());
            }
        }
    }
}
