using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Please enter a number:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter a second  number:");
        double b = double.Parse(Console.ReadLine());
        double greaterNumber = Math.Max(a, b);
        Console.WriteLine("The greater number is: {0}",greaterNumber);
 

    }
}

