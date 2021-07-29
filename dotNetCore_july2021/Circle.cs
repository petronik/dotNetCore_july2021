using System;

namespace dotNetCore_july2021
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public override string Color { get; set; }
        public override double Area => Math.PI * Math.Pow(Radius, 2);
    }
}
