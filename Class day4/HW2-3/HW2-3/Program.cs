using System;

namespace HW23
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] numbers1 = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] = rnd.Next(1, 100);
            }
            for (int j = 0; j <= numbers1.Length - 1; j++)
            {
                Console.WriteLine(numbers1[j]);
            }
            int sum = 0;
            for (int k = 0; k <= numbers1.Length - 1; k++)
            {
                sum = sum + numbers1[k];
            }
            Console.WriteLine("Elementu suma: {0}", sum);
        }
    }
}
