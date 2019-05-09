using System;

namespace CWM7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int[] numbers1 = new int[10];
            int[] numbers1 = { 2, 5, 4, 7, 2, 8, 5, 4, 7, 9 };
            /*Random rnd = new Random();
            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] = rnd.Next(1, 100);
            }
            */

            foreach (var number in numbers1)
            {
                Console.Write("{0}, ", number);
            }

        }
    }
}
