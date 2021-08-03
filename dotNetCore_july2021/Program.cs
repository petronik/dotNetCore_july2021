using static System.Console;
using Protector;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace dotNetCore_july2021
{
    public class Program
    {
        [XmlInclude(typeof(Customer))]
        [XmlInclude(typeof(Top))]
        public class Customer
        {
            public string Name { get; set; }
            public string CardNumber { get; set; }
            public string Password { get; set; }
        }
        public class Customers
        {
            [XmlElement]
            public List<Customer> customer { get; set; }
        }
        public class Top
        {
            public Customers customers { get; set; }
            public void Print()
            {
                WriteLine(customers);
                foreach(var c in customers.customer)
                {
                    WriteLine($"{c.Name} \n {c.CardNumber} \n {c.Password}");
                }
            }
        }

        static void Main(string[] args)
        {

            string file = "OriginalData.xml";
            Top obj = FromXmlFile<Top>(file) ;

            WriteLine(File.ReadAllText(file));
        }

        public static T FromXmlFile<T>(string file)
        {
            XmlSerializer xmls = new XmlSerializer(typeof(T));
            var xmlContent = File.ReadAllText(file);

            using(StringReader sr = new StringReader(xmlContent))
            {
                return (T)xmls.Deserialize(sr);
            }
            
        }
        public static void ToXmlFile<T>(string file, T obj)
        {
            using (StringWriter sw = new StringWriter(new StringBuilder() ))
            {
                XmlSerializer xmls = new XmlSerializer(typeof(T));
                xmls.Serialize(sw, obj);
                File.WriteAllText(file, sw.ToString());
            }
        }
    }
}
