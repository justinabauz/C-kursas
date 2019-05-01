using System;

namespace HW5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite staciakampio krastines x ilgi:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite staciakampio krastines y ilgi:");
            int y = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            if (x >= 2 && y >= 2)
            {
                count = x * y / 6;
            }
            Console.WriteLine("Ar galima ibrezti staciakampi 2*3 i staciakampi {0}*{1}? Atsakymas {2}:", x,y, count);
        }
    }
}