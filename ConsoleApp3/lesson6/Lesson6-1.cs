using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkOOP.lesson2;

namespace HomeWorkOOP.lesson6
{
    class Lesson6_1 : ILesson
    {
        public string nLesson => "6-1";

        public string discription => "Переопределение операторов банковского счета";

        public void Demo()
        {
            Account ac1 = new Account(10000, TypeAccount.Credit);
            Account ac2 = new Account(10000, TypeAccount.Credit);
            Account ac3 = new Account(599, TypeAccount.Deposit);
            Console.WriteLine(ac1.ToString());
            Console.WriteLine();
            Console.WriteLine(ac2.ToString());
            Console.WriteLine();
            Console.WriteLine(ac3.ToString());
            Console.WriteLine(ac3.Equals(ac2));
            Console.WriteLine(ac1.Equals(ac2));
            Console.WriteLine(ac1.GetHashCode());
        }
    }
}
