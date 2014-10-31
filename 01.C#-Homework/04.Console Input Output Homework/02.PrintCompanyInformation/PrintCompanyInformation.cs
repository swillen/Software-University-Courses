using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name:");
        string name = Console.ReadLine();
        Console.Write("Company address:");
        string adress = Console.ReadLine();
        Console.Write("Phone number:");
        int phoneNumb = int.Parse(Console.ReadLine());
        Console.Write("Fax number:");
        int faxNumb = int.Parse(Console.ReadLine());
        Console.Write("Web site: ");
        string website = Console.ReadLine();
        Console.Write("Manager first name:");
        string firstName = Console.ReadLine();
        Console.Write("Manager last  name:");
        string lastName = Console.ReadLine();
        Console.Write("Manager age:");
        int manAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone number:");
        int manPhoneNumb = int.Parse(Console.ReadLine());
        Console.WriteLine("/n{0} \n{1} \n{2} \n{3} \n{4} \n{5} \n{6} \n{7} \n{8}",name,adress,phoneNumb,faxNumb,website,firstName,lastName,manAge,manPhoneNumb);

    }
}

