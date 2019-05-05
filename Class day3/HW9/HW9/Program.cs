using System;

namespace HW9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kurios figuros plota norite suskaiciuoti?");
            Console.WriteLine("[1] - apskritimo, [2] - staciakampio, [3] - trikampio?");
            int veiksmas = int.Parse(Console.ReadLine());
            switch (veiksmas)
            {
                case 1:
                    Console.WriteLine("Iveskite spindulio ilgi:");
                    double spindulys;
                    if (!double.TryParse(Console.ReadLine(), out spindulys))
                    {
                        Console.WriteLine("Ivestas ne skaicius");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Apskritimo plotas: {0}", Math.PI * spindulys * spindulys);

                    break;

                case 2:
                    Console.WriteLine("Iveskite staciakampio ilgi:");
                    double ilgis;
                    if (!double.TryParse(Console.ReadLine(), out ilgis))
                    {
                        Console.WriteLine("Ivestas ne skaicius");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Iveskite staciakampio ploti:");
                    double plotis;
                    if (!double.TryParse(Console.ReadLine(), out plotis))
                    {
                        Console.WriteLine("Ivestas ne skaicius");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Staciakampio plotas yra: {0}", ilgis * plotis);
                    break;

                case 3:
                    Console.WriteLine("Iveskite krastines ilgi");
                    double ilgis2;
                    if (!double.TryParse(Console.ReadLine(), out ilgis2))
                    {
                        Console.WriteLine("Ivestas ne skaicius");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Iveskite ausktines nubreztos i krastine ilgi:");
                    double aukstine;
                    if (!double.TryParse(Console.ReadLine(), out aukstine))
                    {
                        Console.WriteLine("Ivestas ne skaicius");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Trikampio plotas yra: {0}", (ilgis2 * aukstine)/2);
                    break;
                default:
                    Console.WriteLine("Nezinomas veiksmas. Paspauskite [ENTER], kad uzdarytumet langa.");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Paspauskite [ENTER], kad uzdarytumet langa.");
            Console.ReadLine();
        }
    }
}
