using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.Lesson1
{
    public interface IAccount
    {
        int NAccount { get; }
        decimal Balance { get; }
        TypeAccount TypeAcc { get; }

        void ChangeMoney(decimal money);
    }
}
