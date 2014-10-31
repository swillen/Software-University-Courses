using System;

class ExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Please enter unsigned integer:");
        uint number = uint.Parse(Console.ReadLine());
        uint mask = 1;
        //uint numAndMask = number & mask;                      
        //uint bit = numAndMask >> 3;
        //Console.WriteLine(bit);
        Console.WriteLine((number & mask << 3) == 0 ? "0" : "1");





    }
}

