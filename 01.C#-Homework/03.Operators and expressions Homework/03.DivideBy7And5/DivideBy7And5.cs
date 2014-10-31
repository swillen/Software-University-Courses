using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isDevided = (number % 7 == 0) && (number % 5 == 0);
        Console.WriteLine("Is the number devided by 7 and 5:{0}",isDevided);

    }
}

