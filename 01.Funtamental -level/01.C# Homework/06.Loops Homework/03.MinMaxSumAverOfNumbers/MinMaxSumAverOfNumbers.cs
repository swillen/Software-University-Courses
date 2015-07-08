using System;
using System.Linq;

class MinMaxSumAverOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] CountNumb = new int[n];
        for (int i = 0; i < CountNumb.Length; i++)
        {
            CountNumb[i] = int.Parse(Console.ReadLine());
            
        }
        Console.WriteLine("max = {0} \nmin = {1} \nsum = {2} \navg = {3:0.00}", CountNumb.Max(), CountNumb.Min(), CountNumb.Sum(), CountNumb.Average());
    }
}

