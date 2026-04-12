using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine();

        // Test for the Square Class
        // Console.WriteLine("SQUARE CLASS TEST");
        Square square = new Square("Blue", 2.0);
        //Console.WriteLine($"Paper Color: {square.GetColor()}");
        // Console.WriteLine($"Area: {square.GetArea()}");
        // Console.WriteLine();

        // Test for the Rectangle Class
        // Console.WriteLine("RECTANGLE CLASS TEST");
        Rectangle rectangle = new Rectangle("Brown", 2, 3);
        // Console.WriteLine($"Paper Color: {rectangle.GetColor()}");
        // Console.WriteLine($"Area: {rectangle.GetArea()}");
        // Console.WriteLine();

        // Test for the Circle Class
        // Console.WriteLine("CIRCLE CLASS TEST");
        Circle circle = new Circle("Red", 7);
        // Console.WriteLine($"Paper Color: {circle.GetColor()}");
        // Console.WriteLine($"Area: {circle.GetArea()}");
        // Console.WriteLine();

        // Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetType());
            Console.WriteLine($"Paper Color: {s.GetColor()}");
            Console.WriteLine($"Area: {s.GetArea()}");
            Console.WriteLine();
        }


    }
}