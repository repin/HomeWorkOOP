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
            Account account = new Account() { NAccount = 1, Balance = 124129312.14M, TypeAcc = typeAccount.Credit };
            PrintData(account);
            Account account2 = new Account() { NAccount = 2, Balance = 4283729312.14M, TypeAcc = typeAccount.Deposit };
            PrintData(account2);
            Account account3 = new Account() { NAccount = 3, Balance = 4312.14M, TypeAcc = typeAccount.Credit };
            PrintData(account3);

        }

        public void PrintData(Account account)
        {
            Console.WriteLine($"Номер счета: {account.NAccount}");
            Console.WriteLine($"Баланс: {account.Balance}");
            Console.WriteLine($"Тип аккаунта: {account.TypeAcc}");
        }
    }

}
