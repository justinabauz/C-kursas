using System;

namespace HW16
{
    class MainClass
    {
        public static void metodas(int[] eilute)
        {
            for(int i = 0; i < eilute.Length; i++)
            {
                if (i == eilute.Length-1)
                {
                    Console.Write("{0}. ", eilute[i]);
                }
                else if (i != eilute.Length)
                {
                    Console.Write("{0}: ", eilute[i]);
                }
            }
        }

        public static void Main(string[] args)
        {
            int[] stringArray = { 3, 6, 7, 8, 9 };
            metodas(stringArray);
        }
    }
}
