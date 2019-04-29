using System;

namespace Operation2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int A = 1;
            int B = 15;
            Console.WriteLine("Pirminis varianats: A = {0}, B= {1},", A, B);
            //int C = A;
            (A, B) = (B, A);
            Console.WriteLine("Pirminis varianats: A = {0}, B= {1},", A, B);
            //Console.WriteLine("Pirminis varianats: A = {0}, B = {1} ", A=B, B=C);

        }
    }
}

