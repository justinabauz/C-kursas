using System;

namespace HW18
{
    class MainClass
    {
        public static int vertejas(int skaicius)
        {
            string apverstasSkaicius = "";
            string skaicius2 = Convert.ToString(skaicius);
            for(int i = skaicius2.Length-1; i >= 0; i--)
            {
                apverstasSkaicius = apverstasSkaicius + skaicius2[i];
            }

            int result = Convert.ToInt32(apverstasSkaicius);
            return result;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Apverstas skaicius: {0}", vertejas(skaicius));
        }
    }
}
