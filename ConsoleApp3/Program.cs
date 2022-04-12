using System;
using System.Collections.Generic;

namespace HomeWorkOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ILesson> lessonList = new List<ILesson>
            {
                new Lesson1.Lesson1_1(),
                new lesson2.lesson2_1(),
                new lesson2.lesson2_2(),
                new lesson4.lesson4_1(),
                new lesson4.lesson4_2(),
                new lesson5.Lesson5_1()
            };
            Console.WriteLine("Спискок текущих заданий:");
            foreach (ILesson lesson in lessonList)
            {
                Console.WriteLine($"{lesson.nLesson}: {lesson.discription}") ;
            }
            string input=null;
            while (input != "exit")
            {
                Console.WriteLine("Введите номер задания для выполнения или \"exit\" для выхода");
                input = Console.ReadLine();
                foreach (ILesson lesson in lessonList)
                {
                    if (input == lesson.nLesson)
                    {
                        lesson.Demo();
                    }
                }
            }

            
        }
    }
}
