using System;
using System.Collections.Generic;
using System.Text;


namespace HomeWorkOOP.lesson2
{
    public interface IAccount
    {
        int NAccount { get; }
        decimal Balance { get; }
        TypeAccount TypeAcc { get; }

        void ChangeMoney(decimal money);

        void MoneyTransfer(Account account, decimal sum);
    }
}
