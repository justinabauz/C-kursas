using System;

namespace HW31
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] masyvas = { "Beyonce (m)", "David Bowie (v)", "Elvis Costello(v)", "Madonna(m)", "Elton John(v)", "Charles Aznavour(v)" };

            Console.WriteLine("Atspausdiname vyrus:");
            Console.WriteLine();
            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i].EndsWith("(v)"))
                {
                    Console.WriteLine(masyvas[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Atspausdiname moteris:");
            Console.WriteLine();
            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i].EndsWith("(m)"))
                {
                    Console.WriteLine(masyvas[i]);
                }
            }
        }
    }
}
