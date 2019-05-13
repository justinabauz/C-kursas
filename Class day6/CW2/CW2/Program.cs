using System;

namespace CW2
{
    class MainClass
    {
        public static int Fibonaciai(int n)
        {
            int a = 0;
            int b = 1;
        
        for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        
        }

        public static void Main(string[] args)
        {
            int skaicius = 15;

            for (int i = 0; i < skaicius; i++)
            {
                Console.WriteLine(Fibonaciai(i));
            }
        }
    }
}
