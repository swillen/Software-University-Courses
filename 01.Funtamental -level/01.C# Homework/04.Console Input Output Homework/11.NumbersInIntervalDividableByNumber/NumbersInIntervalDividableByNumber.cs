using System;

    class NumbersInIntervalDividableByNumber
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = start; i <=end; i++)
            {
                if (i%5==0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

