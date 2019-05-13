using System;

namespace CW4
{
    class MainClass
    {
        public static int Factorial(int m)

        {
            int fact = 1;
            for (int i=m; i>0; i--)
            {
                fact = fact * i;
                        }
            return fact;
        }

        public static void Main(string[] args)
        
        {

            int skaicius = 5;
            Console.WriteLine("Skaiciaus faktorialas: {0}", Factorial(skaicius));

        }
    }
}
