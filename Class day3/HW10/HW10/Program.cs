using System;

namespace HW10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo metines pajamas:");
            double income;
            if (!double.TryParse(Console.ReadLine(), out income))
            {
                Console.WriteLine("Ivestas ne skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (income < 40000)
            {
                Console.WriteLine("Mokestis netaikomas");
                Console.ReadLine();
            }
            else if (income >= 40000 && income < 75000)
            {
                Console.WriteLine("Taikomas 15 % mokestis: {0}", income*0.15);
                Console.ReadLine();
            }
            else if (income >= 75000 && income < 100000)
            {
                Console.WriteLine("Taikomas 20 % mokestis: {0}", income * 0.2);
                Console.ReadLine();
            }
            else if (income > 100000)
            {
                Console.WriteLine("Taikomas 35 % mokestis: {0}", income * 0.35);
                Console.ReadLine();
            }
        }
    }
}
