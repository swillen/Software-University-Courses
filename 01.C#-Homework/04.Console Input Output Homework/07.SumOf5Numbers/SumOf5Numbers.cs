using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Please enter 5 numbers on the same line:");
        string[] userINput = Console.ReadLine().Split();
        int a = Convert.ToInt32(userINput[0]);
        int b = Convert.ToInt32(userINput[1]);
        int c = Convert.ToInt32(userINput[2]);
        int d = Convert.ToInt32(userINput[3]);
        int e = Convert.ToInt32(userINput[4]);
        int sumOfAll = a + b + c + d + e;
        Console.WriteLine("The sum of the numbers is : {0}",sumOfAll);
        
        
    }
}

