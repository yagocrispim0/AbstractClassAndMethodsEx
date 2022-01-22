using System.Globalization;
using AbstractClassAndMethodsEx.Entities;
using AbstractClassAndMethodsEx.Entities.Enums;
using System.Collections;


Console.Write("Enter the number of shapes: ");
int n = int.Parse(Console.ReadLine());

List<Shape> shapes = new List<Shape>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Shape #" + i + " data:");
    Console.Write("Rectangle or Circle (r/c)? ");
    char type = char.Parse(Console.ReadLine());
    Console.Write("Color (Black/Blue/Red)? ");
    Color color = Enum.Parse<Color>(Console.ReadLine());

    if (type == 'r')
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Shape shape = new Rectangle(color, width, height);
        shapes.Add(shape);
    }
    else
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Shape shape = new Circle(color, radius);
        shapes.Add(shape);

    }

}

Console.WriteLine();

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
}