using System;

namespace CW1
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            float skaiciusFloat = 1f / 3;
            double skaiciusDouble = 1d / 3;

            if (skaiciusFloat == skaiciusDouble)
            {
                Console.WriteLine("skaiciusFloat {0} YRA skaicius skaiciusDouble {1}", skaiciusFloat, skaiciusDouble);
            }
            else 
            {
                Console.WriteLine("skaiciusFloat {0} NERA skaicius skaiciusDouble {1}", skaiciusFloat, skaiciusDouble);
            }
            Console.ReadLine();
        }
    }
}
