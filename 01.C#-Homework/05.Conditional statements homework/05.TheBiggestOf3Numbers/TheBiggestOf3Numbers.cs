using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Please enter 3 numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a > b && a > c)
        {
            Console.WriteLine("The bigger number is:{0}",a);
        }
        else if (b>a && b>c)
        {
            Console.WriteLine("The bigger number is:{0}", b);
        }
        else if (c>b && c>b)
        {
            Console.WriteLine("The bigger number is:{0}", c);
        }
    }
}

