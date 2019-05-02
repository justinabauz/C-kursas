using System;

namespace CW2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double skaicius1 = 0.1 * 10; //Rasom decimal vietoj double bus lygu
            double skaicius2 = 0;

            for (int ctr = 0; ctr < 10; ctr++)
            {
                skaicius2 += 0.1; //0.1m parodo decimal
            }
            Console.WriteLine("{0:R} = {1:R} : {2}", skaicius1, skaicius2, skaicius1 == skaicius2); //Vioetoj R rasom N
            Console.ReadLine();

        }
    }
}
