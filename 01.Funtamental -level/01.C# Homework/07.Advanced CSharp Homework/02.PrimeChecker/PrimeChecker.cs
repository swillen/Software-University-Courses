using System;

class PrimeChecker
{
    static void PrimeCheckerr (long n )
    {
        bool isPrime = true;
        long maxDevider = (long)Math.Sqrt(n);
        if (n ==0 || n==1)
        {
            isPrime = false;
        }
        else
        {
            for (long devider = 2; devider <= maxDevider; devider++)
            {
                if (n % devider == 0 && devider != n)
                {
                    isPrime = false;
                    break;
                }
                else
                {
                    isPrime = true;
                    continue;
                }
            }
        }
        Console.WriteLine(isPrime);

    }
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        PrimeCheckerr(n);
    }
}

