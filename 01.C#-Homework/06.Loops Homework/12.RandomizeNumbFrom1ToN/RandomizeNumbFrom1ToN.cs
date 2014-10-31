using System;

class RandomizeNumbFrom1ToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int [n];
        for (int i = 0; i < n; i++)
        {
            myArray[i] = i + 1; // 
        }
        Random rnd = new Random();
        foreach (var item in myArray)
        {
            int randum = rnd.Next(0, n);  
            int temp = myArray[randum];  
            myArray[randum] = myArray[0];  
            myArray[0] = temp;
        }
        Console.WriteLine(String.Join(" ",myArray));
    }
}
