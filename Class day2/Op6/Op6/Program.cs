using System;

namespace Op6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teksta:");
            string text = Console.ReadLine();
            Console.WriteLine("Ar ivesta eilute tuscia? {0}", text=="");
        }
    }
}
