using System;

namespace Task6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Daugybos lentele yra:");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("{0}*{1}={2}", i, number, i * number);
            }
        }
    }
}
