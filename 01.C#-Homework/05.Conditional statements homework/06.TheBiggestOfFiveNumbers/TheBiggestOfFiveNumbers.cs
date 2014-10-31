using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter 3 numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double f = double.Parse(Console.ReadLine());
        if (a > b && a > c && a > e && a > f)
        {
            Console.WriteLine("The bigger number is:{0}", a);
        }
        else if (b > a && b > c && b > e && b > f)
        {
            Console.WriteLine("The bigger number is:{0}", b);
        }
        else if (c > b && c > b && c > e && c > f)
        {
            Console.WriteLine("The bigger number is:{0}", c);
        }
        else if (e > a && e > b && e > c && e > f)
        {
            Console.WriteLine("The bigger number is:{0}", e);
        }
        else if (f > a && f > b && f > c && f > e)
        {
            Console.WriteLine("The bigger number is:{0}", f);
        }
    }
}

