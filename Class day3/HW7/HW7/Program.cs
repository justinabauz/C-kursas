using System;

namespace HW7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sunaudotos elektros kieki kWh");
            double number1;
            if (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Ivestas ne skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Iveskite sunaudoto karsto vandens kieki(kubiniais metrais):");
            double number2;
            if (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Ivestas ne skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Sumoketi uz elektra reikes, kai kwh = 0,15 eur: {0}, sumoketi uz karsta vandeni reikes, kai kubo kaina - 6 eur: {1} ", number1*0.15, number2*6);
        }
    }
}