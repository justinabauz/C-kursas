using System;

namespace CW3
{
    class MainClass
    {


        public static int SkaitmenuSuma(int num)

        {
            int sum = 0;
            for (int n = num; n > 0; sum += n % 10, n /= 10);
            return sum;
        }

        public static void Main(string[] args)
        {

            int skaicius = 67;

            Console.WriteLine("skaitmenu suma: {0}", SkaitmenuSuma(skaicius));


        }
    }
}
