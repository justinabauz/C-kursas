using System;

namespace HW4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Skaicius dalinasi is 3:");
            for (int i = 1; i <= 100; i++)
            { 
            if (i % 3 == 0)
                {
                    Console.Write("{0},", i);
                }
            }
        }
    }
}
