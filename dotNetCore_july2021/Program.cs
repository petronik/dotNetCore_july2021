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
        //[XmlInclude(typeof(Customer))]
        
        public class Customer
        {
            [XmlElement("name")]
            public string Name { get; set; }
            [XmlElement("creditcard")]
            public string CardNumber { get; set; }
            [XmlElement("password")]
            public string Password { get; set; }
        }
        [XmlRoot("customers")]
        public class Customers
        {
            [XmlElement("customer")]
            public List<Customer> customer { get; set; }
            
        }
        

        static void Main(string[] args)
        {
            //var listofCustomers = new List<Customer> { };
            string file = "OriginalData.xml";
            Customers obj = FromXmlFile<Customers>(file) ;
            WriteLine("Unsecured list of data:");
            foreach (var c in obj.customer )
            {
                WriteLine($"Custormer {c.Name} has card {c.CardNumber } and password {c.Password}");
            }


            string sk = @"\SBO;FK`y4O_fdi8\cj=]uyKnoUC0C\<";
            WriteLine($"\nProtected Data:");
            foreach (var c in obj.customer)
            {
                var encrCardNum = ProtectorClass.EncryptString(sk, c.CardNumber);
                c.CardNumber = encrCardNum;
                string hashed = ProtectorClass.SaltAndHash(c.Password);
                c.Password = hashed;
                WriteLine($"Customer {c.Name} has card {c.CardNumber} with password {c.Password}");
            }
            WriteLine("\nDecripted list of data");
            foreach (var c in obj.customer)
            {
                string dString = ProtectorClass.DecryptString(sk, c.CardNumber);
                WriteLine($"Custormer {c.Name} has card {dString} and password {c.Password}");
            }

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
