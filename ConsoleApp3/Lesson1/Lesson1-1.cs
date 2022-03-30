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
            Account account = new Account(124129312.14M, TypeAccount.Credit);
            PrintData(account);
            Account account2 = new Account(4283729312.14M);
            PrintData(account2);
            Account account3 = new Account(TypeAccount.Credit);
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
