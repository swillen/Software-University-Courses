using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Please enter rectangle`s heigh:");
        double height = double.Parse(Console.ReadLine());
        Console.Write("Please enter rectangle`s width:");
        double width = double.Parse(Console.ReadLine());
        double area = height * width;
        double perimeter = 2 * height + 2 * width;
        Console.WriteLine("Perimeter: {0} \nArea: {1}",perimeter,area);
    }
}

