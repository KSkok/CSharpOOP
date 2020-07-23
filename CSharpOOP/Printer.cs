using CSharpOOP.Shapes;
using System;

namespace CSharpOOP
{
    public static class Printer
    {
        public static void Print(Shape shape)
        {
            Console.WriteLine($"Type: {shape.Type}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine($"Perimiter: {shape.Perimiter}");
            Console.WriteLine();
        }
    }
}
