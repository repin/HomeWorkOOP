using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.Lesson1
{
    public class Account
    {
        private  int _nAccount;
        private decimal _balance;
        private typeAccount _typeAcc;


        public int NAccount 
        {
            get
            {
                return _nAccount;
            }
            set
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
