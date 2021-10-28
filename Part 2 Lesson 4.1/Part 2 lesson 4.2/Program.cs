using System;
using System.Collections;

namespace Part_2_lesson_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Houses houses = new Houses(1, 2, 3, 5);
            houses.Show();
            houses.TakesDoors();
            var create = new Creator();
            create.CreatBulild(1, 2, 3, 4);
            create.CreatBulild(4, 22, 1, 3);
            Show(create, 2);
            Console.WriteLine();
           
            
           
        }
        private static void Show(Creator creator, int index)
        {
            foreach(var num in creator.Items)
            {
                Console.WriteLine(num.Key);
                foreach(var value in num.Value)
                {
                    Console.WriteLine($"\t{value.NumHouse} - {value.NumFloor}-{value.HaightHouse}");
                }
            }
               
        }
    }
}
