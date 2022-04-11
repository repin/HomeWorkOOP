using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.lesson4
{
    class lesson4_1 : ILesson
    {
        public string nLesson => "4-1";

        public string discription => "Класс описания здания";

        public void Demo()
        {

            var house = new House();
            var house1 = new House();
            house.CountAppartament = 200;
            house.CountEntrance = 3;
            house.CountFloor = 12;
            house.Hight = 30;
            Console.WriteLine($"Номер дома: {house.Numberhouse}");
            Console.WriteLine($"Высотра дома: {house.Hight}");
            Console.WriteLine($"Высота этажа: {house.HightFloor()}");
            Console.WriteLine($"Количество подъездов: {house.CountEntrance}");
            Console.WriteLine($"Количество этажей: {house.CountFloor}");
            Console.WriteLine($"Количество квартир: {house.CountAppartament}");
            Console.WriteLine($"Количество квартир в подъезде: {house.CountAppartamentInEntrance()}");
            Console.WriteLine($"Количество квартир на этаже: {house.CountAppartamentInFloor()}");
            Console.WriteLine($"{Environment.NewLine}Номер второго дома: {house1.Numberhouse}");
           }
    }
}
