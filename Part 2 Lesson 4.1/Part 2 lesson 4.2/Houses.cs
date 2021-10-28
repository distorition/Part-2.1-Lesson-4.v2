using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_lesson_4._2
{
   public  class Houses
    {
        static int LastCountHouse = 0;
        public int NumHouse { get; set; }
        public int HaightHouse { get; set; }
        public int NumFloor { get; set; }
        private int NumDoors { get; set; }
        private int NumEntranse { get; set; }
     

        public Houses(int haigh, int floor, int doors, int entance)
        {
            NumHouse = new Random().Next(1, 1000);
            HaightHouse = haigh;
            NumFloor = floor;
            NumDoors = doors;
            NumEntranse = entance;
        }

        //public  int Rand()
        //{

          
        //    LastCountHouse = NumHouse;
        //    return NumHouse;
        //}

        public void Show()
        {
            //Rand();


            Console.WriteLine($"Номер дома {NumHouse}");
            Console.WriteLine($"Высота дома {HaightHouse}");
            Console.WriteLine($"Кол-во этажей  дома {NumFloor}");
            Console.WriteLine($"Кол-во квартир  дома {NumDoors}");
            Console.WriteLine($"Кол-во подьездов  дома {NumEntranse}");
        }
        public void TakesDoors()
        {
            Console.WriteLine($"кол-воо квартир в подьезде {NumDoors / NumEntranse}");
        }
        public void TakeDorsFlor()
        {
            Console.WriteLine($"кол-воо квартир на этаже {(NumDoors / NumEntranse) / NumFloor}");
        }
        public void TakeHaightFlorrs()
        {
            Console.WriteLine($"высота этаже {(NumDoors/NumEntranse)/HaightHouse}");
        }

        private void Up()
        {
            LastCountHouse++;
        }
        public override bool Equals(object obj)
        {
            var houses = obj as Houses;
            if(houses==null)
            {
                return false;
            }
            return NumDoors == houses.NumDoors && HaightHouse == houses.HaightHouse && NumFloor == houses.NumFloor && NumEntranse == houses.NumEntranse;
        }

        public override int GetHashCode()
        {
            int numHose = NumHouse.GetHashCode();
            int height = HaightHouse.GetHashCode();
            int numDors = NumDoors.GetHashCode();
            int numFlors = NumFloor.GetHashCode();
            int numEntance = NumEntranse.GetHashCode();

            return  numHose ;
        }

    }
}
