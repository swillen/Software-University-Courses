using System;

class StringsAndObjects
{
    static void Main()
    {
        string firstVar = "Hello";
        string secondVar = "World";
        object theSum = firstVar +" "+ secondVar;
        string thirdVar = Convert.ToString(theSum);
        Console.WriteLine(firstVar);
        Console.WriteLine(secondVar);
        Console.WriteLine(theSum);
        Console.WriteLine(thirdVar);
    }
}

