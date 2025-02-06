using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square(5);
        Circle s2 = new Circle(2);
        Rectangle s3 = new Rectangle(4, 6);
        
        shapes.Add(s1);
        shapes.Add(s2);
        shapes.Add(s3);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} Area: {shape.GetArea():F2}");
        }
        
    }
}