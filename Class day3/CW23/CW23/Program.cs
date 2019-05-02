using System;

namespace CW23
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Irasykite Celsijaus laipsnius:");
            int celsius = Convert.ToInt32(Console.ReadLine());
            double fahrenheit = (double)celsius * 18 / 10 + 32;
            Console.WriteLine("Kelvin: {0}", celsius + 273);
            Console.WriteLine("Fahrenheit: {0}", fahrenheit);
        }
    }
}
