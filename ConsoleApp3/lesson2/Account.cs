using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.lesson2
{
    public class Account : IAccount
    {
        public static int countAccount;
        private int _nAccount;
        private decimal _balance;
        private TypeAccount _typeAcc;

        public int NAccount
        {
            get
            {
                return _nAccount;
            }
            private set
            {
                _nAccount = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return _balance;
            }
            private set
            {
                _balance = value;
            }
        }
        public TypeAccount TypeAcc
        {
            get
            {
                return _typeAcc;
            }
            private set
            {
                _typeAcc = value;
            }
        }

        public Account(decimal balance) : this(balance, 0)
        {
        }

        public Account(TypeAccount type) : this(0, type)
        {

        }

        public Account(decimal balance, TypeAccount type)
        {
            NAccount = ++countAccount;
            Balance = balance;
            TypeAcc = type;
        }

        public void ChangeMoney(decimal money)
        {
            Balance = Balance + money;
        }

        public void MoneyTransfer(Account account, decimal sum)
        {
            this.Balance = this.Balance + sum;
            account.Balance = account.Balance - sum;
        }

        public static bool operator ==(Account ac1, Account ac2)
        {
            bool boolBalance = ac1.Balance == ac2.Balance;
            bool boolTypeAcc = ac1.TypeAcc == ac2.TypeAcc;
            return boolBalance && boolTypeAcc;
        }

        public static bool operator !=(Account ac1, Account ac2)
        {
            bool boolBalance = ac1.Balance != ac2.Balance;
            bool boolTypeAcc = ac1.TypeAcc != ac2.TypeAcc;
            return boolBalance && boolTypeAcc;
        }

        public override bool Equals(object obj)
        {
            return this == (Account)obj;
        }

        public override string ToString()
        {
            string nAccount = NAccount.ToString();
            string balance = Balance.ToString();
            string typeAccount = TypeAcc.ToString();
            return "Номер аккаунта: " + nAccount + Environment.NewLine + "Баланс: " + balance + Environment.NewLine + "Тип аккаунта: " + typeAccount;
        }

        public override int GetHashCode()
        {
            return NAccount;
        }




    }

    public enum TypeAccount
    {
        None = 0,
        Deposit = 1,
        Credit = 2
    }

}
