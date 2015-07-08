using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Please enter trapezoids sides:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter trapezoids height:");
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine("Trapezoid`s area is:{0} ",area);

    }
}

