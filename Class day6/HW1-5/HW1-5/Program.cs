using System;

namespace HW15
{
    class MainClass
    {
        public static void remas(string eilute)
        {
            for(int i=0; i<eilute.Length+4; i++)
            {
            Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine("* {0} *", eilute);
            for (int i = 0; i < eilute.Length + 4; i++)
            {
                Console.Write("*");
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite eilute:");
            string eilute = Console.ReadLine();
            remas(eilute);
        }
    }
}
