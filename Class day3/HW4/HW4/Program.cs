using System;

namespace HW4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu:");
            double number1;
            if (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Ivestas ne skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Iveskite antra skaiciu:");
            double number2;
            if (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Ivestas ne skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Iveskite operaciją (+,-,*,/):");
            string operation = Console.ReadLine();
            if ((operation == "+" || operation == "-" || operation == "*" || operation == "/") == false)
            {
                Console.WriteLine("Ivestas neteisingas operatorius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            double result = 0;
            if (operation == "+")
            {
               result = number1 + number2;
            }
            else if (operation == "-")
            {
                result = number1 - number2; 
            }
            else if (operation == "*")
            {
                result = number1 * number2;
            }
            else if (operation == "/")
            {
                result = number1/number2;
            }
            Console.WriteLine("Rezultatas: {0}", result);
            Console.ReadLine();
        }
    }
}
