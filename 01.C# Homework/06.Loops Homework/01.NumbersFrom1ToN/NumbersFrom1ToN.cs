using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Please enter a number:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("The numbers from \"1\" to \"n\" are : ");
        for (int i = 1; i <=n; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

