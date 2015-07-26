using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ATMWithdrawal
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            var db = new ATMdbEntities();

            using (var tran = db.Database.BeginTransaction(IsolationLevel.RepeatableRead))
            {
                try
                {
                    Console.WriteLine("Please enter a card number");
                    string number = "1234567890";
                    Console.WriteLine("Please enter a card pin");
                    string pin = "2222";
                    Console.WriteLine("Please enter ammount of money to withdraw");
                    decimal withdrawMoney = decimal.Parse(Console.ReadLine());

                    var account = Validation.TakeCardAccountByCardNumber(number,db);

                    Validation.ValidatePin(account, pin);

                    Validation.ValidateWithdrawMoney(account, withdrawMoney);

                    db.TransactionHistories.Add(new TransactionHistory()
                    {
                        CardNumber = account.CardNumber,
                        Amount = account.CardCash,
                        TransactionDate = DateTime.Now

                    });
                    account.CardCash-=withdrawMoney;
                    db.SaveChanges();
                    
                    Console.WriteLine(account.CardCash);
                }
                catch (Exception e )
                {
                    Console.WriteLine(e);
                    tran.Rollback();
                }
                tran.Commit();
            }
        }
    }
}
