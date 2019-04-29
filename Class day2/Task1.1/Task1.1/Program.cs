using System;

namespace Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skaiciu suma: {0}", number1 + number2);
            Console.WriteLine("Skaiciu skirtumas: {0}", Math.Abs(number1 - number2));
            Console.WriteLine("Skaiciu sandauga: {0}", number1 * number2);
            Console.WriteLine("Skaiciu dalyba: {0}", (double)number1 / number2);
        }
    }
}
