using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.Lesson1
{
    public class Account
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
        }
        public decimal Balance
        {
            get
            {
                return _balance;
            }
        }
        public TypeAccount TypeAcc
        {
            get
            {
                return _typeAcc;
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
            _nAccount = ++countAccount;
            _balance = balance;
            _typeAcc = type;
        }


    }

    public enum TypeAccount
    {
        None = 0,
        Deposit = 1,
        Credit = 2
    }

}
