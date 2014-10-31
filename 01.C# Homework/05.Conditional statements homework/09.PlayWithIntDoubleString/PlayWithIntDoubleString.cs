using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type between 1,2 or 3:");
        int a =int.Parse(Console.ReadLine());
        switch (a)
        {
            case 1: Console.Write("Please enter a number:"); int number = int.Parse(Console.ReadLine()); Console.WriteLine(number+1);
                break;
            case 2: Console.Write("Please enter floating point number:"); double numberTwo = double.Parse(Console.ReadLine()); Console.WriteLine(numberTwo+1);
                break;
            case 3: Console.Write("Please enter a string:"); string word = Console.ReadLine(); Console.WriteLine(word+"*");
                break;
            default: Console.Write("Invalid input.Please try again!");
                break;
        }
    }
}

