using System;
class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        double n = double.Parse(Console.ReadLine());
        double sum = 0;
        for (double i = 1; i <= n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
            
        }
        Console.WriteLine(sum);
    }
}

