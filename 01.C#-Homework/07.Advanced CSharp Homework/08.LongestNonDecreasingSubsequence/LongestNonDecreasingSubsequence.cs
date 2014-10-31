using System;
using System.Linq;
using System.Collections.Generic;

class LongestNonDecreasingSubsequence
{
    // is not finished - to do later 
    static void Main()
    {
        string[] stringInput = Console.ReadLine().Split();
        int[] inputToInt = new int[stringInput.Length];
        List<int> finalNumber = new List<int>();
        int count = 0;
        int num;
        for (int i = 0; i < stringInput.Length; i++)
        {
            inputToInt[i] = int.Parse(stringInput[i]);
        }
        for (int i = 0 ,k=0; i < inputToInt.Length && k<inputToInt.Length; i++,k++)
        {
                if (inputToInt[k] - inputToInt[i] == 0 || inputToInt[k] - inputToInt[i] == 1)
                {
                    count++;
                    num = inputToInt[i];
                    finalNumber.Add(num);
                }
                else
                {
                    break;
                }
        }
        foreach (var item in finalNumber)
        {
            Console.WriteLine(item);
        }
    }
}

