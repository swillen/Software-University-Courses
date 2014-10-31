using System;
using System.Linq;

class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int enteredNumb;
        int[] numbers = new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            enteredNumb = int.Parse(Console.ReadLine());
            numbers[i] = enteredNumb;
        }
        Console.WriteLine();
        Array.Sort(numbers);
        Console.Write("The sorted number are :");
        foreach (int item in numbers)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();
    }
}

