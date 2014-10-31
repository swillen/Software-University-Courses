using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("When is your birthday:");
        DateTime birthDay = DateTime.Parse(Console.ReadLine());

        int afterTenYears = (DateTime.Now.Year - birthDay.Year) + 10;
        Console.WriteLine("Your are after 10 years will be : {0}", afterTenYears);
    }
}

