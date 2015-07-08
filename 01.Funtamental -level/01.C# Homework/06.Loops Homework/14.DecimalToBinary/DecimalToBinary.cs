using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter your decimal number: ");
        long dec = long.Parse(Console.ReadLine());

        long rest;
        string binary = string.Empty;

        while (dec > 0)
        {
            rest = dec % 2;
            dec /= 2;
            binary = rest.ToString() + binary;
        }

        Console.WriteLine(binary);
    }
}

