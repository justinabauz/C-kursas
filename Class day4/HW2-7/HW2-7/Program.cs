using System;

namespace HW27
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int[] masyvas = new int [5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iveskite skaiciu:");
                if (!int.TryParse(Console.ReadLine(), out masyvas[i]))
                {
                    Console.WriteLine("Ivestas ne skaicius");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("Senas Masyvas:");
            for (int k = 0; k<5; k++)
            {
                Console.Write("{0}, ", masyvas[k]);
            }

            Console.WriteLine();
            Console.WriteLine("Naujas Masyvas:");
            int[] masyvasNaujas = new int[5];
            for (int j = 0; j< 5; j++)
                {
                    masyvasNaujas[j] = masyvas[j];
                    Console.Write("{0}, ", masyvasNaujas[j]);
                }
        }
    }
}
