using System;

class PointInCircleAndOutOfRectangle
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        bool inCircle = ((a - 1) * a) + ((b - 1) * b) <= 1.5 * 2; 
        bool inRectangle = (a >= -1 && a <= 5) && (b >= -1 && b <= 1) ; 
        if (inCircle == true && inRectangle == false)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

