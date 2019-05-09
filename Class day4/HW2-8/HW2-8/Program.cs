using System;

namespace HW28
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] masyvas = new int[5];
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
            Array.Sort(masyvas);
            foreach (int number in masyvas)
            {
                Console.Write("{0}, ", number);
            }

        }
    }
}
