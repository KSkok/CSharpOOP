using System;

namespace CSharpOOP.Shapes
{
    public class Shape
    {
        public const double PI = Math.PI;
        public string Type { get; }
        public virtual double Perimiter { get; }

        public Shape(string type)
        {
            Type = type;
        }

        public virtual double GetArea()
        {
            return 0;
        }
    }
}
