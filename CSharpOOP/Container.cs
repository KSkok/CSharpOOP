using CSharpOOP.Shapes;
using System.Collections.Generic;

namespace CSharpOOP
{
    public class Container
    {
        private List<Shape> listOfShapes;

        public Container()
        {
            listOfShapes = new List<Shape>();
        }

        public void Add(Shape shape)
        {
            listOfShapes.Add(shape);
        }

        public List<Shape> GetShapes(string shapeType = null)
        {
            if (string.IsNullOrEmpty(shapeType))
                return listOfShapes;
            return listOfShapes.FindAll(shape => shape.Type.Equals(shapeType));
        }
    }
}
