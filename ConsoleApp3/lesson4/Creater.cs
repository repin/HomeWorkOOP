using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.lesson4
{
    class Creater
    {
        private Creater()
        {

        }

        private static Hashtable _hashTable;

        public static Hashtable hashTable
        {
            get
            {
                return _hashTable;
            }
            private set
            {
                _hashTable = value;
            }
        }

        private static void AddHouseToHashTable(int numberHouse, House house)
        {
            if (hashTable == null)
            {
                hashTable = new Hashtable();
            }
            hashTable.Add(numberHouse, house);
        }

        public static void CreateBuild(int CountAppartament, float Hight)
        {
            House house = new House();
            house.CountAppartament = CountAppartament;
            house.CountEntrance = 1;
            house.CountFloor = 1;
            house.Hight = Hight;
            AddHouseToHashTable(house.Numberhouse, house);
        }

        public static void CreateBuild(int CountAppartament, int CountFloor, float Hight)
        {
            House house = new House();
            house.CountAppartament = CountAppartament;
            house.CountEntrance = 1;
            house.CountFloor = CountFloor;
            house.Hight = Hight;
            AddHouseToHashTable(house.Numberhouse, house);

        }

        public static void CreateBuild(int CountAppartament, int CountEntrance, int CountFloor, float Hight)
        {
            House house = new House();
            house.CountAppartament = CountAppartament;
            house.CountEntrance = CountEntrance;
            house.CountFloor = CountFloor;
            house.Hight = Hight;
            AddHouseToHashTable(house.Numberhouse, house);
        }

        public static void GetHashTableHouse()
        {
            if (hashTable == null)
            {
                Console.WriteLine("домов нет");
                return;
            }
            foreach (DictionaryEntry dE in hashTable)
            {
                Console.WriteLine($"{dE.Key}: {dE.Value}");
            }
        }

        public static void DelHouseInHashCode(int numderHouse)
        {
            if (hashTable.ContainsKey(numderHouse))
            {
                hashTable.Remove(numderHouse);
            }
            else
            {
                Console.WriteLine("Дома с таким номером не существуеты");
            }
        }
    }
}
