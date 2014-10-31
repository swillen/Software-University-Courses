using System;

class GravitationOnMoon
{
    static void Main()
    {
        Console.Write("Please enter your weight on earth:");
        double earthWeight = double.Parse(Console.ReadLine());
        double moonWeight = earthWeight *0.17;
        Console.WriteLine("Your weight on the moon is : {0}",moonWeight);
    }
}

