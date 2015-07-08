using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Is the number prime?");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (number >=0 && number <=100)
        {
            if (number ==1)
            {
                isPrime = false;
            }
            else
            {
                for (int devider = 2; devider < number; devider++)
                {
                    if (number%devider==0)
                    {
                        isPrime = false;
                    }
                    
                }
            }
            Console.WriteLine(isPrime);
        }
        else
        {
            Console.WriteLine("Please enter valid input !");
        }
    }
}

