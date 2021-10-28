using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Lesson_4._1
{
    public class Houses
    {
        static int LastCountHouse = 0;
        private int NumHouse { get; set; }
        private int HaightHouse { get; set; }
        private int NumFloor{ get; set; }
        private int NumDoors { get; set; }
        private int NumEntranse { get; set; }

        public Houses(int haigh,int floor,int doors,int entance)
        {
           
            HaightHouse = haigh;
            NumFloor = floor;
            NumDoors = doors;
            NumEntranse = entance;
        }

        private void Rand()
        {
           
            NumHouse = new Random().Next(1, 1000);
            LastCountHouse = NumHouse;
        }

        public void Show()
        {
            Rand();
            Console.WriteLine($"Номер дома {NumHouse}");
            Console.WriteLine($"Высота дома {HaightHouse}");
            Console.WriteLine($"Кол-во этажей  дома {NumFloor}");
            Console.WriteLine($"Кол-во квартир  дома {NumDoors}");
            Console.WriteLine($"Кол-во подьездов  дома {NumEntranse}");
        }
        public void TakesDoors( )
        {
            Console.WriteLine($"кол-воо квартир в подьезде {NumDoors / NumEntranse}");
        }
        public void TakeDorsFlor()
        {
            Console.WriteLine($"кол-воо квартир на этаже {(NumDoors / NumEntranse)/ NumFloor}");
        }

        private void Up()
        {
            LastCountHouse++;
        }
    }
 }

