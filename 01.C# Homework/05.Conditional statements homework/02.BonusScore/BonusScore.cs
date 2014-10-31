using System;

class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Please enter a score:");
        int score = int.Parse(Console.ReadLine());
        if (score>=1 && score<=3)
        {
            score = score * 10;
            Console.WriteLine("The score is = {0}",score);
        }
        else if (score>3 && score<=6)
        {
            score = score * 100;
            Console.WriteLine("The score is = {0}", score);
        }
        else if (score>=7 && score<=9)
        {
            score = score * 1000;
            Console.WriteLine("The score is = {0}", score);
        }
        else if (score<=0 || score>=10)
        {
            Console.WriteLine("Invalid score! ");
        }

    }
}

