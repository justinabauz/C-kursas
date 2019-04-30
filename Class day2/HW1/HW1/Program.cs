using System;

namespace HW1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine().ToUpper();
            Console.WriteLine("Please enter your surname:");
            string surname = Console.ReadLine().ToUpper();
            Console.WriteLine("Your name and surname - {0}", name + "_" + surname);
        }
    }
}
