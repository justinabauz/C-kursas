using System;
using System.Linq;

namespace Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu:");
            int number3 = Convert.ToInt32(Console.ReadLine());
            double avg = (double)(number1 + number2 + number3) / 3;
            Console.WriteLine("Skaiciu vidurkis: {0}",avg);
        }
    }
}
