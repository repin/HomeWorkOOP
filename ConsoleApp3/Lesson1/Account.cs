using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.Lesson1
{
    public class Account
    {
        public static int countAccount;
        private  int _nAccount;
        private decimal _balance;
        private typeAccount _typeAcc;

        public Account()
        {
                _nAccount = ++countAccount;
        }
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
            set
            {
                _balance = value;
            }
        }

        public typeAccount TypeAcc
        {
            get
            {
                return _typeAcc;
            }
            set
            {
                _typeAcc = value;
            }
        }
    }

    public enum typeAccount
    {
        Deposit = 1,
        Credit = 2
    }

}
