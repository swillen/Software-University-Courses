using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Please enter an integer:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please enter bit position: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(p,2).PadLeft(16,'0'));    // p 
        int mask = 1 << p;
        Console.WriteLine(Convert.ToString(mask, 2).PadLeft(16, '0')); // maskata
        int numAndMask = number & mask;
        Console.WriteLine(Convert.ToString(numAndMask, 2).PadLeft(16, '0')); // chislo +maska
        int bit = numAndMask >> p;
        Console.WriteLine(Convert.ToString(bit, 2).PadLeft(16, '0')); // bit
        Console.WriteLine("The value ot the bit at position \"p\" is : {0}",bit);
    }
}

