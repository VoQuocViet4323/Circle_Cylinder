public class Program
{
    private static void Main(string[] args)
    {
        // Kiểm thử lớp Circle
        Circle circle = new Circle(3.0f, "blue");
        Console.WriteLine("Circle:");
        Console.WriteLine(circle.ToString());

        // Kiểm thử lớp Cylinder
        Cylinder cylinder = new Cylinder(3.0f, "blue", 5.0f);
        Console.WriteLine("\nCylinder:");
        Console.WriteLine(cylinder.ToString());
    }
}