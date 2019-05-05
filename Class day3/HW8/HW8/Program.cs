using System;

namespace HW8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu nuo 1 iki 7, kuris reiks savaites diena:");
            int veiksmas = int.Parse(Console.ReadLine());
            switch (veiksmas)
            {
                case 1:
                    Console.WriteLine("Pirmadienis");
                    break;
                case 2:
                    Console.WriteLine("Antradienis");
                    break;

                case 3:
                    Console.WriteLine("Treciadienis");
                    break;
                case 4:
                    Console.WriteLine("Ketvirtadienis");
                    break;
                case 5:
                    Console.WriteLine("Penktadienis");
                    break;
                case 6:
                    Console.WriteLine("Sestadienis");
                    break;
                case 7:
                    Console.WriteLine("Sekmadienis");
                    break;
                default:
                    Console.WriteLine("Nezinomas veiksmas. Paspauskite [ENTER], kad uzdarytumet langa.");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Paspauskite [ENTER], kad uzdarytumet langa.");
            Console.ReadLine();
        }
    }
}
