using System;
using System.Linq;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        string[] firstInput = Console.ReadLine().Split();
        string[] secondInput = Console.ReadLine().Split();
        List<string> names = new List<string>();


        for (int i = 0; i < firstInput.Length; i++)
        {
            names.Add(firstInput[i]);
            for (int j = 0; j < secondInput.Length; j++)
            {
                if (firstInput[i] == secondInput[j])
                {
                    names.Remove(firstInput[i]);
                }
            }
        }
        foreach (var item in names)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

