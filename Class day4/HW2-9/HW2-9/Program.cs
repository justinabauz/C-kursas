using System;

namespace HW29
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] masyvas1 = { 1, 3, 9 };
            int[] masyvas2 = { 4, 6, 7 };
            int[] masyvas3 = new int[6];
            for (int i=0; i<3; i++)
            {
                masyvas3[i] = masyvas1[i];
            }

            for (int j = 0; j < 3; j++)
            {
                masyvas3[3+j] = masyvas2[j];
            }
            foreach (int number in masyvas3)
            {
                Console.Write("{0}, ", number);
            }

        }
    }
}
