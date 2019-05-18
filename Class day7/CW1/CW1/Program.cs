using System;

namespace CW1
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int skaicius = rnd.Next(1, 15);
            int i = 0;
            while (i < 4)
            {
                Console.WriteLine("Iveskite skaiciu!");
                int spejimas = Convert.ToInt32(Console.ReadLine());
                if (skaicius == spejimas)
                {
                    Console.WriteLine("Mano skaicius: {0}", skaicius);
                    Console.WriteLine("Atspejote skaiciu");
                    break;

                }
                else if (skaicius > spejimas)
                {

                    Console.WriteLine("Mano skaicius didesnis!");
                }
                else
                {
                    Console.WriteLine("Mano skaicius mazesnis!");
                }

                i++;
            }
            Console.WriteLine("Pralaimejote!! Mano skaicius buvo: {0}", skaicius);
        }
    }
}
// Kompiuteris sugalvoja skaiciu. Zmogus per 4 kartus turi ji atspeti. 
//Kompiuterio  atsakymas turi buti ar skaicius didesnis ar mazesnis uz jo sugalvota