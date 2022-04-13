using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.lesson2
{
    class lesson2_1 : ILesson
    {
        public string nLesson => "2-1";

        public string discription => "Добавлен метод снятия денег с одного счета и перевод в другой";

        public void Demo()
        {
            List<IAccount> listAccount = new List<IAccount>() {
            new Account(124129312.14M, TypeAccount.Credit),
            new Account(4283729312.14M),
            new Account(TypeAccount.Credit)
            };
            PrintDataAllAccount(listAccount);

            Console.WriteLine("Переведем с 2 аккаунта на первый 100 000 000");
            TransferMoney(listAccount, 1,2, 100000000);
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

        private void TransferMoney(List<IAccount> listAccount, int nAccount, int nAccountErrase, decimal sum)
        {
            foreach (IAccount account in listAccount)
            {
                if (account.NAccount == nAccount)
                {
                    foreach(IAccount accountErrase in listAccount)
                    {
                        if (accountErrase.NAccount == nAccountErrase)
                        {
                            account.MoneyTransfer((Account)accountErrase, sum);
                        }
                    }
                }
            }
        }
    }
}
