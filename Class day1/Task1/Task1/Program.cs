using System;

namespace Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kokia tavo megstamiausia spalva?");
            var user_colour = Console.ReadLine();
            Console.WriteLine("Mano irgi " + user_colour);
        }
    }
}
