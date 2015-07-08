using System;
class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n<1 || n>20)
        {
            Console.WriteLine("Please enter another number!");
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j <=n+i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

