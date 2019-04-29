using System;

namespace Op8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite varda:");
            string name = Console.ReadLine();
            Console.WriteLine("Iveskite pavarde:");
            string surname = Console.ReadLine();
            Console.WriteLine("Vardar ir Pavarde yra: {0}", name+" "+surname);
        } 
    }
}
