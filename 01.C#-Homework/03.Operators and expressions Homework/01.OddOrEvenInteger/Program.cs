using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Odd?");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("False");
        }
        else
        {
            Console.WriteLine("True");
        }
    }
}
