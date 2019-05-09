using System;
using System.Linq;

namespace HW26
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] numbers1 = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] = rnd.Next(1, 1000);
            }
            for (int j = 0; j <= numbers1.Length - 1; j++)
            {
                Console.Write("{0}, ", numbers1[j]);
            }
            int maxval = numbers1.Max();
            int minval = numbers1.Min();
            Console.WriteLine();
            Console.WriteLine("Maksimali reiksme: {0}", maxval);
            Console.WriteLine("Minimali reiksme: {0}", minval);
        }
    }
}
