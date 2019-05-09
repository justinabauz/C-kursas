using System;

namespace HW3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 10; i <= 20; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Skaiciu nuo 10 iki 20 suma: {0}", sum);
        }
    }
}
