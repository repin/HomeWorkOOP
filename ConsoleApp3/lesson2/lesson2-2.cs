using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.lesson2
{
    class lesson2_2 : ILesson
    {
        public string nLesson => "2-2";

        public string discription => "переворот строки";

        public void Demo()
        {
            string stroka = "Какой чудесный день!";
            Console.WriteLine($"Исходная строка: {stroka}");
            ReverseString(ref stroka);
            Console.WriteLine($"Перевернутая строка: {stroka}");
        }
/*
        private string ReverseString(ref string stroka)
        {
            StringBuilder str = new StringBuilder();
            for (int i = stroka.Length - 1; i >= 0; i--)
            {
                str.Append(stroka[i]);
            }
            return str.ToString();
        }*/
        private void ReverseString(ref string stroka)
        {
            StringBuilder str = new StringBuilder();
            for (int i = stroka.Length - 1; i >= 0; i--)
            {
                str.Append(stroka[i]);
            }
            stroka = str.ToString();
        }
    }
}
