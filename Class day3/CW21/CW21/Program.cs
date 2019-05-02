using System;

namespace CW21
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite simboli:");
            string symbol = Console.ReadLine();
            Console.WriteLine("{0}", symbol);
            Console.WriteLine("{0}{0}", symbol);
            Console.WriteLine("{0}{0}{0}", symbol);
        }
    }
}
