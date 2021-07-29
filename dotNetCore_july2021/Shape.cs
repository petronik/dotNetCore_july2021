

using System.Xml.Serialization;

namespace dotNetCore_july2021
{
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Circle))]
    public class Shape
    {
        public virtual string Color { get; set; }
        public virtual double Area { get; }
        

    }
}
