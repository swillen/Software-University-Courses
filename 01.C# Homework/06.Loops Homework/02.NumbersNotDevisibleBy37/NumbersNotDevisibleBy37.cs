using System;

class NumbersNotDevisibleBy37
{
    static void Main()
    {
        Console.WriteLine("Please enter positive number :");
        int n = int.Parse(Console.ReadLine());
        if (n<0)
        {
            Console.WriteLine("Please enter positive integer!");
        }
        else
        {
            for (int i = 1; i <=n; i++)
            {
                if (i%3==0 || i%7==0)
                {
                    continue;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

