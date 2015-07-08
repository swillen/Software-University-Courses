using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter a bit position :");
        int p = int.Parse(Console.ReadLine());
        bool isOne =( n & (1 << p)) > 0;
        Console.WriteLine(isOne);

    }
}

