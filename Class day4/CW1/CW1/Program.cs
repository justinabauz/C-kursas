using System;
using System.Threading;

namespace CW1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            int cursor = 0;
            for (int j = 0; j <= 70; j++)
            {
                Thread.Sleep(50);
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("{0}%", j);
                Console.SetCursorPosition(cursor + j, 1);
                Console.WriteLine("#");
            }
            for (int i = 0; i <= 100; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
            Console.ReadLine(); //Pagal Console nustatymus, jeigu nebutu ReadLine Console ivykdytu operacija ir uzsidarytu. Pas mane veikia ir be jo
        }
    }
}


