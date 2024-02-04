using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Clear();
        // Square square = new Square("Red", 5);
        // string squareColor = square.GetColor();
        // double squareArea = square.GetArea();
        // Console.WriteLine("Color of the square: " + squareColor);
        // Console.WriteLine("Area of the square: " + squareArea + " Square Metres");
        // Console.WriteLine();

        // Rectangle rectangle = new Rectangle("Blue", 10, 5);
        // string rectangleColor = rectangle.GetColor();
        // double rectangleArea = rectangle.GetArea();
        // Console.WriteLine("Color of the rectangle: " + rectangleColor);
        // Console.WriteLine("Area of the rectangle: " + rectangleArea + " Square Metres");
        // Console.WriteLine();

        // Circle circle = new Circle("Green", 9);
        // string circleColor = circle.GetColor();
        // double circleArea = circle.GetArea();
        // circleArea = Math.Round(circleArea, 2);
        // Console.WriteLine("Color of the circle: " + circleColor); 
        // Console.WriteLine("Area of the circle: " + circleArea);

        List<Shape> shapes = new List<Shape>();
        
        // Square square = new Square("Red", 5);
        // Rectangle rectangle = new Rectangle("Blue", 10, 5);
        // Circle circle = new Circle("Green", 9);

        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 10, 5));
        shapes.Add(new Circle("Green", 9));
        Console.Clear();

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} {shape} has an area of {Math.Round(area, 2)} m\u00B2");
            Console.WriteLine();
        }
    }
}
