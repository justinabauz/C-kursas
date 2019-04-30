using System;
using System.Threading;

namespace HW4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu (sekundes)");
            int seconds = Convert.ToInt32(Console.ReadLine());
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            string str = time.ToString(@"hh\:mm\:ss");
            Console.WriteLine("Pavertus i valandas, minutes, sekundes gauname: {0}", str);
        }
    }
}
