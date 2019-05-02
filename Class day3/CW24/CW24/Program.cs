using System;

namespace CW24
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double number = 1888.699007;
            int number1 = (int)number;
            short number2 = (short)number1;
            byte number3 = (byte)number2;

            Console.WriteLine("double number {0}", number);
            Console.WriteLine("int number {0}", number1);
            Console.WriteLine("short number {0}", number2);
            Console.WriteLine("byte number {0}", number3);

        }
    }
}
