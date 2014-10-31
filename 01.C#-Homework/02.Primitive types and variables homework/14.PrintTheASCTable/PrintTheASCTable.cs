using System;
using System.Text;

class PrintTheASCTable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.BufferHeight = 256;
        for (int i = 0; i < 256; i++)
        {

            char ch = (char)i;
            Console.WriteLine(ch);
        }
    }
}

