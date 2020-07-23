namespace CSharpOOP.Shapes
{
    class Circle : Shape
    {
        private double radius;

        public override double Perimiter => PI * 2 * radius;

        public Circle(double radius) : base("Circle")
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return PI * radius * radius;
        }
    }
}
