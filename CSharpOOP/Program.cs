using CSharpOOP.Shapes;
using System;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {
                new Rectangle(2, 4),
                new Circle(5),
                new Rectangle(7, 3),
                new Shape("Shape")
            };

            foreach (var shape in shapes)
            {
                Printer.Print(shape);
            }

            Console.WriteLine("Container:\n");
            var contaier = new Container();
            contaier.Add(shapes[0]);
            contaier.Add(shapes[1]);
            contaier.Add(new Shape("Shape"));
            contaier.Add(shapes[2]);

            var result = contaier.GetShapes("Rectangle");
            foreach (var shape in result)
            {
                Printer.Print(shape);
            }
        }
    }
}
