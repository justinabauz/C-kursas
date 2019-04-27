using System;

namespace Task5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            double div = (double) number1 / (double) number2;
            Console.WriteLine("Dvieju skaiciu suma {0}", number1 + number2);
            Console.WriteLine("Dvieju skaiciu skirtumas {0}", Math.Abs(number1 - number2));
            Console.WriteLine("Dvieju skaiciu daugyba {0}", number1 * number2);
            Console.WriteLine("Dvieju skaiciu dalyba {0}", div);
        }
    }
}
