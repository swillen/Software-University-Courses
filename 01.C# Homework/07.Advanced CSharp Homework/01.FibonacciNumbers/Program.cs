using System;

class Program
{
    static void FibonacciMethod (int n , int fibFirst=0, int fibSecond = 1, int temp =0)
    {
        for (int i = 0; i <n; i++)
        {
            temp = fibSecond;
            fibSecond = fibFirst + fibSecond;
            fibFirst = temp;
        }
        Console.WriteLine(fibSecond);
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        FibonacciMethod(n);
    }
}

