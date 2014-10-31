using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Please enter number :");
        int number = int.Parse(Console.ReadLine());
        int thirdDigit = (number / 100)%10;
        if (thirdDigit ==7)
        {
            Console.WriteLine("Is the third number 7:{0}",true);
        }
        else
        {
            Console.WriteLine("Is the third number 7:{0}", false);
        }
    }
}

