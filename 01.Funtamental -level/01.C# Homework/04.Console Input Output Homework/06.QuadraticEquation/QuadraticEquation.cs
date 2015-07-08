using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Please enter 3 numbers \"a\" , \"b\" and \"c\"; ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double discriminant = (b * b) - (4 * a * c);
        double x1;
        double x2;
        if (discriminant == 0)
        {
            x1 = x2 = -b / (2 * a);
            Console.WriteLine("x1 = x2 = {0}", x1);
        }
        else if (discriminant > 0)
        {
            //When Δ>0, there are 2 real roots x1=(-b+√Δ)/(2a) and x2=(-b-√Δ)/(2a).
            x2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            x1 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("x1 ={0} x2 = {1}", x1, x2);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("There are no real roots");
        }
    }
}

