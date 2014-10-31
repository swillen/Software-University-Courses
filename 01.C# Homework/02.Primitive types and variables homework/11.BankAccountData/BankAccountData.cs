using System;

class BankAccountData
{
    static void Main()
    {
        Console.Write("Holder`s name is:");
        string name = "Ivan Ivanov Ivanichkov";
        Console.WriteLine(name);
        decimal balance = 999999m;
        Console.WriteLine("Your balance is :{0}",balance);
        Console.Write("The bank`s name is:");
        string bankName = "DSK";
        Console.WriteLine(bankName);
        Console.Write("IBAN:");
        uint ibanNumber = 3985938539;
        Console.WriteLine(ibanNumber);
        Console.WriteLine("Three credit card numbers associate with the card:");
        long firstNumb = 12345678910;
        long secondNumb =23423343434;
        long thirdNumb = 29382948299;
        Console.WriteLine(firstNumb);
        Console.WriteLine(secondNumb);
        Console.WriteLine(thirdNumb);

    }
}

