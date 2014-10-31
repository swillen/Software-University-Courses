using System;

//Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
//sum S = 1 + 1!/x + 2!/x^2 + … + n!/x^n
class CalcNPlusNFactorialDevByX
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double sum = 1;
        double factorial = 1;
        double xPow = 1;
        for (int i = 1; i <=n; i++)
        {
            factorial = factorial * i;
            xPow = xPow * x;
            sum = sum + (factorial / xPow);
        }
        Console.WriteLine("{0:F5}",sum);

    }
}

