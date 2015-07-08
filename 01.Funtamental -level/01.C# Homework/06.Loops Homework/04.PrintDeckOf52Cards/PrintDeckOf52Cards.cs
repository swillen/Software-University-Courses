using System;
using System.Text;

class PrintDeckOf52Cards
{
    static void Main()
    {
        Encoding OutPutEncoding = Encoding.ASCII;
        char spatia = (char)5;
        char karo = (char)4;
        char heart = (char)3;
        char pike = (char)6;
        for (int i = 2; i <=10; i++)
			{
            Console.WriteLine(" {0} {1} {2} {3}",i+" "+spatia,i+" "+karo,i+" "+heart,i+" "+pike);
			}
        for (int i = 11; i <=14; i++)
        {
            switch (i)
            {
                case 11: string j = "J"; Console.WriteLine(" {0} {1} {2} {3}", j + " " + spatia, j + " " + karo, j + " " + heart, j + " " + pike);
                    break;
                case 12: string d = "D"; Console.WriteLine(" {0} {1} {2} {3}", d + " " + spatia, d + " " + karo, d + " " + heart, d + " " + pike);
                    break;
                case 13: string k = "K"; Console.WriteLine(" {0} {1} {2} {3}", k + " " + spatia, k + " " + karo, k + " " + heart, k + " " + pike);
                    break;
                case 14: string a = "A"; Console.WriteLine(" {0} {1} {2} {3}", a + " " + spatia, a + " " + karo, a + " " + heart, a + " " + pike);
                    break;
               
            }
        }

    }
}

