using System;

namespace HW2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite apskritimo spinduli");
            int spindulys = Convert.ToInt32(Console.ReadLine());
            double ilgis = 2 * spindulys * Math.PI;
            double plotas = Math.PI * spindulys * spindulys;
            Console.WriteLine("Apskritimo ilgis yra - {0}, o plotas {1}", ilgis, plotas);
        }
    }
}
