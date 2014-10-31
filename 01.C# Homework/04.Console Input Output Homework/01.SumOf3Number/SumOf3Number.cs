using System;

class SumOf3Number
{
    static void Main()
    {
        Console.WriteLine("Please enter 3 number: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int sum = a + b + c;
        Console.WriteLine("The sum of the numbers is: {0} ",sum);
    }
}

