using System;

namespace Part_2_Lesson_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Houses houses = new Houses(1,2,3,5);
            houses.Show();
            Console.WriteLine();
            Houses houses1 = new Houses(111, 5, 32, 6);
            houses1.Show();
            houses1.TakesDoors();
            houses1.TakeDorsFlor();

        }
    }
}
