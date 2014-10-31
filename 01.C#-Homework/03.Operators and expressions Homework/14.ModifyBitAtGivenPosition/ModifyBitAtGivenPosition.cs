using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Please enter an integer:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter bit position:");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int numbAndMask = n ^ mask;
        Console.WriteLine(numbAndMask);


        Console.WriteLine(Convert.ToString(p, 2).PadLeft(16, '0'));
    }
}

