using System;
using System.Linq;

class OddAndEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] myArray = input.Split(' ');
        int oddSum = 1;
        int evenSum = 1;
        for (int i = 0; i < myArray.Length; i++)
        {
            int number = int.Parse(myArray[i]);
            if (i%2 == 0 || i==0)
            {
                oddSum = oddSum * number;
            }
            else if (i%2!=0)
            {
                evenSum = evenSum * number;
            }
        }
        if (oddSum== evenSum)
        {
            Console.WriteLine("Yes \nproduct ={0}",evenSum);
        }
        else
        {
            Console.WriteLine("No  \nOdd product ={0} \nEven product ={1}", oddSum, evenSum);
        }
    }
}

