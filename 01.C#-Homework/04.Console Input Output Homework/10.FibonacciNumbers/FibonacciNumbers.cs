﻿using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        int firstNumber = 0;
        int secondNumber = 1;
        Console.Write(firstNumber + " ");
        for (int i = 1; i < n; i++)
        {

            Console.Write("{0} ", secondNumber);
            int temp = secondNumber;
            secondNumber = secondNumber + firstNumber;
            firstNumber = temp;
        }
        Console.WriteLine();
    }
}

