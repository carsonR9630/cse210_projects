using System;

class Program
{
    static void Main(string[] args)
    {
        //Square s1 = new Square ("Blue", 4);
        //string color = s1.GetColor();
        //double area = s1.GetArea();
        //Console.WriteLine($"Color: {color} and Area: {area}");

        //Rectangle r1 = new Rectangle("Orange", 5, 10);
        //color = r1.GetColor();
        //area = r1.GetArea();
        //Console.WriteLine($"Color: {color} and Area: {area}");
        
        //Circle c1 = new Circle("Red", 6);
        //color = c1.GetColor();
        //area = c1.GetArea();
        //Console.WriteLine($"Color: {color} and Area: {area}");

        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("Purple", 9);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Yellow", 7, 8);
        shapes.Add(s2);

        Circle s3 = new Circle("Cyan", 14);
        shapes.Add(s3);

        foreach(Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}