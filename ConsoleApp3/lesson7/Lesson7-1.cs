using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.lesson7
{
    class Lesson7_1 : ILesson
    {
        public string nLesson => "7-1";
        
        public string discription => "Кодирование и декодирование текстовых строк";

        public void Demo()
        {
            ACoder ac = new ACoder("Съешь ещё этих мягких французких булок, да выпей чаю. 1234567890");
            Console.WriteLine(ac.Decode());
            Console.WriteLine(ac.Encode());
            BCoder bc = new BCoder("Съешь ещё этих мягких французких булок, да выпей чаю. 1234567890", 19);
            Console.WriteLine(bc.Decode());
            Console.WriteLine(bc.Encode());
        }
    }
}
