using System;

namespace HW6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int A = 1;
            int B = 15;
            Console.WriteLine("Pradines reiksmes A = {0}, B = {1}: ", A, B);
            (A, B) = (B, A);
            Console.WriteLine("Sukeitus reiksmes gauname: A = {0}, B = {1}: ", A, B);
        }
    }
}
