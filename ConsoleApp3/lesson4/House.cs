using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.lesson4
{
    class House
    {
        private static int _nHouse;
        private int _numberHouse;
        private float _hight;
        private int _countFloor;
        private int _countAppartament;
        private int _cpuntEntrance;
        public int Numberhouse 
        {
            get{return _numberHouse;}
            private set{_numberHouse = value;}
        }
        public float Hight
        {
            get{return _hight;}
            set{_hight = value;}
        }
        public int CountFloor
        {
            get{return _countFloor;}
            set{_countFloor = value;}
        }
        public int CountAppartament
        {
            get {return _countAppartament;}
            set { _countAppartament = value; }
        }
        public int CountEntrance 
        {
            get { return _cpuntEntrance; } 
            set { _cpuntEntrance = value; } 
        }

        public House()
        {
            _nHouse++;
            Numberhouse = _nHouse;
        }

        /// <summary>
        /// Метод возвращает высоту этажа (игнорируя технические этажи)
        /// </summary>
        /// <returns></returns>
        public float HightFloor()
        {
            float hightFloor = Hight / CountFloor;
            return hightFloor;
        }

        /// <summary>
        /// Получение количества квартир на этаже
        /// </summary>
        /// <returns></returns>
        public int CountAppartamentInFloor()
        {
            int countAppartamentInFloor = CountAppartamentInEntrance() / CountFloor;
            return countAppartamentInFloor;
        }

        /// <summary>
        /// Получение количества квартир в подъезде
        /// </summary>
        /// <returns></returns>
        public int CountAppartamentInEntrance()
        {
            int countAppartamentInEntrance = CountAppartament / CountEntrance;
            return countAppartamentInEntrance;
        }
    }
}
