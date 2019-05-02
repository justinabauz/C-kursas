using System;

namespace CWIF1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite grupes pavadinima:");
            string grupesPavadinimas = Console.ReadLine();
            Console.WriteLine("Iveskite grupes nariu skaiciu:");
            //int grupesNariuskaicius = int.Parse(Console.ReadLine());
            int nariuSkaicius;
            if (!int.TryParse(Console.ReadLine(), out nariuSkaicius))// rezultatas True or False
            {

                Console.WriteLine("Ivestas blogas skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Grupes pavadinimas yra:{0}, nariu skaicius yra {1}:", grupesPavadinimas, nariuSkaicius);
            Console.ReadLine();

        }
    }
}
