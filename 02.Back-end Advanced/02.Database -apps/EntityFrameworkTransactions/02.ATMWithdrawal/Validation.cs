using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ATMWithdrawal
{
    internal static class Validation
    {

        internal static CardAccount TakeCardAccountByCardNumber(string  cardNumber,ATMdbEntities db)
        {
            var account = db.CardAccounts.Where(a => a.CardNumber == cardNumber).First();
            if (account == null)
            {
                throw  new ArgumentException("Invalid account !");
            }
            return account;
        }

        internal static void ValidatePin(CardAccount account , string pin)
        {
            if (account.CardPIN != pin)
            {
                throw new ArgumentException("Invalid PIN !");
            }
        }

        internal static void ValidateWithdrawMoney(CardAccount account, decimal moneyToWithDraw)
        {
            if (account.CardCash < moneyToWithDraw)
            {
                throw new ArgumentException("Invalid withdrow value !");
            }
        } 
    }
}
