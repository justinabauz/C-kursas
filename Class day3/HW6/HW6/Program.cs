using System;

namespace HW6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma trikampio kampo laipsni:");
            int number1;
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Ivestas ne skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Iveskite antra trikampio kampo laipsni:");
            int number2;
            if (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Ivestas ne skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Iveskite trecia trikampio kampo laipsni:");
            int number3;
            if (!int.TryParse(Console.ReadLine(), out number3))
            {
                Console.WriteLine("Ivestas ne skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Ar is ivestu duomenu galima sudaryti trikampi: {0}", number1>0&& number2>0&&number3>0&&(number1+number2+number3)==180);
            Console.ReadLine();
        }
    }
}
