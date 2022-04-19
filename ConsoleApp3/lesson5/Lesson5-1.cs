using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.lesson5
{
    class Lesson5_1 : ILesson
    {
        public string nLesson => "5-1";

        public string discription => "Перегрузка операторов";

        public void Demo()
        {
            RacNumber r1 = new RacNumber(1, 2);
            RacNumber r2 = new RacNumber(2, 3);
            RacNumber r4 = new RacNumber(1, 2);
            RacNumber r3 = r1 + r2;
            Console.WriteLine(r3.ToString());
            Console.WriteLine(r1.Equals(r2));
            Console.WriteLine(r1.Equals(r4));
            Console.WriteLine((float)r3);
            Console.WriteLine((int)r3);
        }
    }
}
