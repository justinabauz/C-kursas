using System;
using System.Linq;

namespace Task7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double[] array = new double[4];
            Console.WriteLine("Iveskite 4 skaicius:");
            for (int i = 0; i < 4; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine(array.Average());
        }
    }
}
