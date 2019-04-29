using System;

namespace Op7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaciu:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ar skaicius mazesnis uz 0? {0}", number < 0);
        }
    }
}
