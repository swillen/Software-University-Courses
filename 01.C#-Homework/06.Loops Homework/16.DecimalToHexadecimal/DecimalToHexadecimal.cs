using System;
using System.Globalization;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter your decimal number: ");
        long dec = long.Parse(Console.ReadLine());

        string hexaStr = dec.ToString("X");

        long hexa = long.Parse(hexaStr, NumberStyles.HexNumber);

        Console.WriteLine(hexaStr);
    }
}

