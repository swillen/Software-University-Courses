//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2+0+1+1 = 4).Prints on the console the number in reversed order: 
//dcba (in our example 1102).Puts the last digit in the first position: dabc (in our example 1201).Exchanges the second 
//and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0. Examples:

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter four digit number:");
        string number = Console.ReadLine();
        int theNumber = Convert.ToInt32(number);
        int firstNumber = theNumber / 1000;
        int secondNumber = (theNumber / 100)%10;
        int thirdNumber = (theNumber / 10)%10;
        int fourthNumber = theNumber % 10;
        int theSum = firstNumber + secondNumber + thirdNumber + fourthNumber;
        if (theNumber <= 9999 && firstNumber != 0)
        {
            Console.WriteLine("The sum of the numbers is : {0}",theSum);
            Console.WriteLine("{0}{1}{2}{3}",fourthNumber,thirdNumber,secondNumber,firstNumber);
            Console.WriteLine("{0}{1}{2}{3}", fourthNumber, firstNumber, secondNumber, thirdNumber);
            Console.WriteLine("{0}{1}{2}{3}", firstNumber, thirdNumber, secondNumber, fourthNumber);
        }
        else
        {
            Console.WriteLine("Please enter four digit number that doesn`t starts with 0!");
        }

    }
}

