using System;
using System.Collections.Generic;
using System.Linq;

class PrimesInRange
{
    static List<int> FindPrimesInRange(int startN, int endN)
    {
        int n;
        bool isPrime = true;
        List<int> myList = new List<int>();
        for (int i = startN; i <=endN; i++)
        {
            n = i;
            for (int devider = 2; devider <= endN; devider++)
            {
                if (n==1 ||n==0)
                {
                    isPrime = false;
                }
                else if(n%devider==0 && devider!=n)
                {
                    isPrime = false;
                    break;
                }
                else if (n%devider!=0 || devider==n)
                {
                    isPrime = true;
                    continue;
                }
            }
            if (isPrime == true)
            {
                myList.Add(n);
            }
        }
        return myList;
    }

    static void Main()
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());
        if (endNumber < startNumber)
        {
            Console.WriteLine("(Empty list)");
        }
        else
        {
            List<int> Primes = FindPrimesInRange(startNumber, endNumber);
            foreach (var item in Primes)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

