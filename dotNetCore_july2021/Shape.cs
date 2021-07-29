using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace dotNetCore_july2021
{
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Circle))]
     public class Shape
    {
        public virtual string Color { get; set; }
        public virtual double Area { get; }

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
