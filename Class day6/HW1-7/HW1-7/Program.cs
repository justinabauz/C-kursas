using System;

namespace HW17
{
    class MainClass
    {
        public static decimal metodas(decimal[] skaicius)
        {
            decimal sum = 0;

            for (int i = 0; i < skaicius.Length; i++)
            {
                sum = sum + Math.Round(skaicius[i],2);
            }
            return sum;
        }

        public static void Main(string[] args)
        {
            decimal[] skaicius = { 35.2m, 55.345m};
            Console.WriteLine("Skaiciu suma suapvalinta iki simtuju:{0}", metodas(skaicius));
        }
    }
}

