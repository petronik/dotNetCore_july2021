namespace dotNetCore_july2021
{
    class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override string Color { get; set; }
        public override double Area => Width * Height;

    }
}
