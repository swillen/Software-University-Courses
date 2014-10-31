using System;
using System.Numerics;
class CalcNFacDevisebleByKFac
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //5
        int k = int.Parse(Console.ReadLine()); //2
        double nFact = 1;
        double kFat = 1;
        BigInteger sum = 0;
        if (k<0 || k>n || n>100)
        {
            Console.WriteLine("Please try again! ");
        }
        else
        {
            for (int i = 1; i <=n; i++)
            {
                nFact = i * nFact;
            }
            for (int j = 1; j <=k; j++)
            {
                kFat = j * kFat;
            }
            Console.WriteLine("{0}", nFact/kFat);
        }
    }
}

