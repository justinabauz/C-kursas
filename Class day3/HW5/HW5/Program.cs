using System;

namespace HW5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu:");
            double number1;
            if (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Ivestas ne skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Iveskite antra skaiciu:");
            double number2;
            if (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Ivestas ne skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Iveskite trecia skaiciu:");
            double number3;
            if (!double.TryParse(Console.ReadLine(), out number3))
            {
                Console.WriteLine("Ivestas ne skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Didziausias is siu skaiciu yra: {0}", Math.Max(Math.Max(number1, number2), number3));
            Console.ReadLine();
        }
    }
}
