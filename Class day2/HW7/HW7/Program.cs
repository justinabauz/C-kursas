using System;

namespace HW7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite dvieju skaitmenu skaiciu:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skaitmenu suma: {0}+{1}={2}", number/10, number%10, number /10 + number % 10);
        }
    }
}
