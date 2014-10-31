using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Please enter an integer a>=0 and a<=500 \na= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter a floating point number:\nb=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter another floating point number:\nc=");
        double c = double.Parse(Console.ReadLine());
        
        if (a>=0 && a<=500)
        {
            
            Console.WriteLine("|{0,-10:X}|{1:,-10}|{2,10:0.00}|{3,10:0.000}|",a,Convert.ToString(a,2).PadLeft(10,'0'),b,c);
        }
        else
        {
            Console.WriteLine("Please enter valid input!");
        }

    }
}

