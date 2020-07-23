namespace CSharpOOP.Shapes
{
    class Rectangle : Shape
    {
        private double width;
        private double length;

        public override double Perimiter => 2 * (width + length);

        public Rectangle(double width, double length) : base("Rectangle")
        {
            this.width = width;
            this.length = length;
        }

        public override double GetArea()
        {
            return width * length;
        }
    }
}
