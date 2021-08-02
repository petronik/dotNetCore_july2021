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
        public class Customer
        {
            public string Name { get; set; }
            public string CardNumber { get; set; }
            public string Password { get; set; }
        }

        static void Main(string[] args)
        {
            var listOfCustomers = new List<Customer>
            {
                new Customer {Name = "John Doe", CardNumber = "1233-4567-7890-1234", Password = "Pa$$w0rD"},
                new Customer {Name = "Peter Pan", CardNumber = "0987-7654-4321-1092", Password = "Adm1n321"}
            };

            string xmlFile = "UnsecuredData.xml";
            ToXmlFile(xmlFile, listOfCustomers);

            List<Customer> file1 = FromXmlFile<List<Customer>>("UnsecuredData.xml");

            // string sk = ProtectedClass.GenerateSecretKey();
            string sk = @"\SBO;FK`y4O_fdi8\cj=]uyKnoUC0C\<";
            for (int i = 0; i < file1.Count; i++) //encripting card number and hashing password
            {
                var encrCardNum = ProtectorClass.EncryptString(sk, file1[i].CardNumber);
                file1[i].CardNumber = encrCardNum;
                string hashed = ProtectorClass.SaltAndHash(file1[i].Password);
                file1[i].Password = hashed;
            }

            string ProtectedFile = "protectedFile.xml";
            ToXmlFile(ProtectedFile, file1);// creates file with protected data

            WriteLine("Unsecured list of data");
            foreach (Customer item in listOfCustomers)
            {
                WriteLine($"Custormer {item.Name} has card nimber {item.CardNumber} and password {item.Password}");
            }
            WriteLine("Protected list of data");

            List<Customer> resObj = FromXmlFile<List<Customer>>(ProtectedFile);
            foreach(Customer item in resObj)
            {
                WriteLine($"Custormer {item.Name} has card nimber {item.CardNumber} and password {item.Password}");
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
