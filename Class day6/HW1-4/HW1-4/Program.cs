using System;

namespace HW14
{
    class MainClass
    {
        public static int LenghtCalc(string eilute)
        {
        int lenght = 0;
        foreach(var letter in eilute)
            {
                lenght++;
            }
            return lenght;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite raidziu eilute:");
            string value = Console.ReadLine();
            Console.WriteLine("Sios eilutes ilgis yra:{0}", LenghtCalc(value));
        }
    }
}
