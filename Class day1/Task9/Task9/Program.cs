using System;

namespace Task9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite simboli!");
            string symbol = Console.ReadLine();
            Console.WriteLine("Kvadratas");
            Console.WriteLine("{0}{0}{0}",symbol);
            Console.WriteLine("{0} {0}", symbol);
            Console.WriteLine("{0} {0}", symbol);
            Console.WriteLine("{0} {0}", symbol);
            Console.WriteLine("{0}{0}{0}", symbol);
        }
    }
}
