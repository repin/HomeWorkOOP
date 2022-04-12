using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.lesson4
{
    class lesson4_2 : ILesson
    {
        public string nLesson => "4-2";

        public string discription => "Фабричный метод создания дома";

        public void Demo()
        {
            Creater.CreateBuild(1, 8);
            Creater.CreateBuild(10, 2, 10);
            Creater.CreateBuild(40, 4, 5, 15);
            Creater.GetHashTableHouse();
            Console.WriteLine("Удаляем первый дом");
            Creater.DelHouseInHashCode(1);
            Creater.GetHashTableHouse();

        }
    }
}
