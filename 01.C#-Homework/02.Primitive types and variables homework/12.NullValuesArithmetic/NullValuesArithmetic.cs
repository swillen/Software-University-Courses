using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int var =Convert.ToInt32(null);
        double var2 = Convert.ToDouble(null);
        Console.WriteLine("Firs variable:{0} \nSecond variable:{1}",var,var2);
        var = var + 5;
        Console.WriteLine(var);

    }
}

