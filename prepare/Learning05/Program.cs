using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Blue", 7);
        Rectangle rectangle = new Rectangle("Red", 5, 7);
        Circle circle = new Circle("Purple", 3);
        List<Shape> shapes = new List<Shape>();
        shapes.Add(rectangle);
        shapes.Add(circle);
        shapes.Add(square);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetArea()}");
            Console.WriteLine($"{shape.GetColor()}");
        }

    }
}