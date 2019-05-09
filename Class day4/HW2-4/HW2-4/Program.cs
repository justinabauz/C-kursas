using System;

namespace HW24
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] masyvas = { "a", "b", "c", "d" };

            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.Write("{0}, ", masyvas[i]);
            }
            Console.WriteLine();
            for (int j = masyvas.Length - 1; j >= 0; j--)
            {
                Console.Write("{0}, ", masyvas[j]);
            }

        }
    }
}
