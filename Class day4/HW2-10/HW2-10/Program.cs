using System;

namespace HW210
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] varduMas = { "Justas", "Tomas", "Rokas", "Lukas", "Vaidas", "Povilas", "Martynas", "Jokubas", "Viktoras", "Benas"};
            string[] masyvasNaujas = new string[8];
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i != 5 && i != 7)
                {
                    masyvasNaujas[j] = varduMas[i];
                    j++;
                }


                /* if (i < 4)
                {
                    masyvasNaujas[i] = varduMas[i];
                }
                else if (i == 5)
                {
                    masyvasNaujas[i-1] = varduMas[i];
                }
                else if (i > 6)
                {
                    masyvasNaujas[i-2] = varduMas[i];
                }
                */
            }

            foreach (var number1 in masyvasNaujas)
            {
                Console.WriteLine("{0}, ", number1);
            }



        }
    }
}
