using System;

namespace CWM5
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
            foreach (var number in numbers1)
            {
                Console.Write("{0}, ", number);
            }
            Console.WriteLine();
            Console.WriteLine("Antras masyvas:");
            int[] numbers2 = new int[10];
            Random rnd2 = new Random();
            for (int j = 0; j < numbers2.Length; j++)
            {
                numbers2[j] = rnd2.Next(1, 100);
            }
            foreach (var number2 in numbers2)
            {
                Console.Write("{0}, ", number2);
            }
            int[] combined = new int[numbers1.Length + numbers2.Length];
            Array.Copy(numbers1, combined, numbers1.Length);
            Array.Copy(numbers2, 0, combined, numbers1.Length, numbers2.Length);
            Console.WriteLine();
            Console.WriteLine("Sujungtas masyvas:");
            Array.Sort(combined);
            foreach (var number3 in combined)
            {
                Console.Write("{0}, ", number3);
            }

        }
    }
}
