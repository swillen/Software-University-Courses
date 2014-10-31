using System;


class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter your binary number: ");
        string binary = Console.ReadLine();

        long dec = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[binary.Length - i - 1] == '0')
            {
                continue;
            }

            dec += (long)Math.Pow(2, i);
        }

        Console.WriteLine(dec);

    }
}

