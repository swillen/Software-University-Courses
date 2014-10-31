using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger twoNFact = 1;
        BigInteger nPlusOneFact = 1;
        BigInteger nFact = 1;
        if (n < 1 || n > 100)
        {
            Console.WriteLine("Please enter another number!");
        }
        else
        {
            for (int i = 1; i <= n * 2; i++)
            {
                twoNFact = twoNFact * i;
            }
            for (int j = 1; j <=n + 1; j++)
            {
                nPlusOneFact = nPlusOneFact * j;
            }
            for (int i = 1; i <=n; i++)
            {
                nFact = nFact * i;
            }
            BigInteger result = twoNFact / (nPlusOneFact * nFact);
            Console.WriteLine(result);
        }
    }
}

