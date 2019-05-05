using System;

namespace HW3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            int number1;
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Ivestas ne skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Ar ivestas skaicius yra lyginis? {0}", number1%2 ==0);
            Console.WriteLine("Ar ivestas skaicius yra teigimas? {0}", number1>0);
            Console.ReadLine();
        }
    }
}
