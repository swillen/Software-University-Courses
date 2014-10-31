using System;
using System.Numerics;

class CalculateNFactDevidedByKF
{
    static void Main()
    {
        BigInteger n = int.Parse(Console.ReadLine());
        BigInteger k = int.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger nMinusKFact = 1;
        for (int i = 1; i <=n; i++)
        {
            nFact = nFact * i;
        }
        for (int m= 1; m <=k; m++)
        {
            kFact = kFact * m;
        }
        for (int l = 1; l <=n-k; l++)
        {
            nMinusKFact = nMinusKFact * l;
        }
        BigInteger result = nFact / (kFact * nMinusKFact);
        Console.WriteLine(result);
    }
}

