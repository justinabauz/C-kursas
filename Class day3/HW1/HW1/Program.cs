using System;

namespace HW1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu:");
            int number1;
            if (!int.TryParse(Console.ReadLine(), out number1))// rezultatas True or False
            {
                Console.WriteLine("Ivestas ne skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Iveskite antra skaiciu:");
            int number2;
            if (!int.TryParse(Console.ReadLine(), out number2))// rezultatas True or False
            {
                Console.WriteLine("Ivestas ne skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Ivesti skaiciai yra vienodi? {0}", number1 == number2 );
            Console.ReadLine();
        }
    }
}
