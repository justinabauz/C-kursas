using System;

namespace Op3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ar skaiciai lygus? {0}", number1==number2);
        }
    }
}
