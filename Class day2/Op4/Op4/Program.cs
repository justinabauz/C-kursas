using System;

namespace Op4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pirma skaiciu padidinam vienu - {0}, antra skaiciu sumazinam vienu - {1}", number1++, number2--);
            Console.WriteLine("Pirma skaiciu padidinam vienu - {0}, antra skaiciu sumazinam vienu - {1}", number1, number2);
        }
    }
}
