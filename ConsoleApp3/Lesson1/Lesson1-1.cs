using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.Lesson1
{
    public class Lesson1_1 : ILesson
    {

        public string nLesson => "1-1";

        public string discription => "Банковский счет";

        public void Demo()
        {
            List<IAccount> listAccount = new List<IAccount>() {
            new Account(124129312.14M, TypeAccount.Credit),
            new Account(4283729312.14M),
            new Account(TypeAccount.Credit)
            };
            PrintDataAllAccount(listAccount);
            Console.WriteLine("Увеличим сумму на 1 счете на 1000 000 и на 3 счете уменьшим на 1000 000.");
            ChangeBalance(listAccount, 1, 1000000);
            ChangeBalance(listAccount, 3, -1000000);
            PrintDataAllAccount(listAccount);
        }

        private void PrintDataAllAccount(List<IAccount> listAccount)
        {
            foreach (IAccount account in listAccount)
            {
                Console.WriteLine($"Номер счета: {account.NAccount}");
                Console.WriteLine($"Баланс: {account.Balance}");
                Console.WriteLine($"Тип аккаунта: {account.TypeAcc}");
            }
        }

        private void ChangeBalance(List<IAccount> listAccount, int nAccount,decimal money)
        {
            foreach (IAccount account in listAccount)
            {
                if (account.NAccount == nAccount)
                {
                    account.ChangeMoney(money);
                }
            }
        }
    }

}
