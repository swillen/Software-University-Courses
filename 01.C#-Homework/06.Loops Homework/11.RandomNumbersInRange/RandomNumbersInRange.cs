using System;
using System.Linq;

class RandomNumbersInRange
{
    static void Main()
    {
        //1 masiv sys stoinosti ot min do maksimum
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        if (min <= max)
        {
            Random numb = new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(numb.Next(min, max + 1));
            }
        }
        else
        {
            Console.WriteLine("Please enter correct input! ");
        }

    }
}

