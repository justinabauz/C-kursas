using System;

namespace CW3
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            byte a = 0;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            a = 254;
            a++;

            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            Console.ReadLine();//perpildo byte tipa, jame telpa tik 255, grazina 0

        }
    }
}
