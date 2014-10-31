using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Please enter an integer:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter second integer:");
        int b = int.Parse(Console.ReadLine());
        if (a>b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a+" "+b);
        }
        else
        {
            Console.WriteLine(a+" " +b);
        }
    }
}

