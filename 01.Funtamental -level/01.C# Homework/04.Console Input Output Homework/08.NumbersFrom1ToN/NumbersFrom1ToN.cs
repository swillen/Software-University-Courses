using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        int count= 1;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
        
    }
}

