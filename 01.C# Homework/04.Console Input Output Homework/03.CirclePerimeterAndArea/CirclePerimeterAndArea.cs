using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please enter radius of the circle:");
        double r = double.Parse(Console.ReadLine());
        double p = Math.PI * (2 * r);
        double a = Math.PI * (r * r);
        Console.WriteLine("The circle perimeter is : {0:F2} \nThe circle area is {1:F2}",p,a);

    }
}

