﻿using System;

class PrintLongSequence
{
    static void Main()
    {
        Console.BufferHeight = 1001;
        for (int i = 2; i <= 1002; i++)
        {
            if (i % 2 == 0 )
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(i * -1);
            }
        }
    }
}

