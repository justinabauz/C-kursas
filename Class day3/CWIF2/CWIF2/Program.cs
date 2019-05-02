using System;

namespace CWIF2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Koki veiksma norite atlikti?");
            Console.WriteLine("[1] - istrinti vartotoja, [2] - sukurti vartotoja, [3] - redaguoti esama?");

            int veiksmas = int.Parse(Console.ReadLine());
            switch (veiksmas)
            {
                case 1:
                    Console.WriteLine("Vartotojas sekmingai istrintas...");
                    break;
                case 2:
                    Console.WriteLine("Vartotojas sekmingai sukurtas...");
                    break;

                case 3:
                    Console.WriteLine("Vartotojo redagavimo rezimas");
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
