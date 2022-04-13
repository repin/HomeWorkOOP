using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.Lesson1
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




    }

    public enum TypeAccount
    {
        None = 0,
        Deposit = 1,
        Credit = 2
    }

}
