using System;
using System.Linq;

namespace CW2
{
    class MainClass
    {
        public static string TurimiMasyvoElm (string[] valiutuMasyvas)
        {
            string output = "";
            for (int i = 0; i < valiutuMasyvas.Length; i++)
            {

                output = output + "[" + (i + 1) + "] - " + valiutuMasyvas[i] + ", ";
            
            }

            return output;
        }

        public static void Main(string[] args)
        {
            string[] valiutuMasyvas = new string[] { "EUR", "USD", "PLN" };
            double[] kursuMasyvas = new double[] { 1, 1.17, 3.45 };
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Iveskite, kokia operacija atliksite: [1] - pirksite valiuta, [2] - parduosite, [3] -  " +
                    "baigti operacijas, [4] - prideti nauja valiuta, [5] - istrinti valiuta, [6] - redaguoti kursa");
                int operacija = Convert.ToInt32(Console.ReadLine());
                if (operacija == 3)
                {
                    break;
                }
                else
                {
                    if (operacija > 6)
                    {
                        Console.WriteLine("Ivedete bloga opearcija:");
                    }
                    else
                    {

                        if (operacija == 1)
                        {
                            Console.WriteLine("Pasirinkite su kuria valiuta darysite operacija: {0}", TurimiMasyvoElm(valiutuMasyvas));
                            int valiuta = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Iveskite keitimo kieki:");
                            int kiekis = Convert.ToInt32(Console.ReadLine());

                            double sumoketi = kiekis / kursuMasyvas[valiuta - 1];
                            Console.WriteLine("Jus turite sumoketi: {0} EUR, kad gautumete {1} {2}", sumoketi, kiekis, valiutuMasyvas[valiuta - 1]);

                        }

                        else if (operacija == 2)
                        {
                            Console.WriteLine("Pasirinkite su kuria valiuta darysite operacija:{0}", TurimiMasyvoElm(valiutuMasyvas));
                            int valiuta = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Iveskite keitimo kieki:");
                            int kiekis = Convert.ToInt32(Console.ReadLine()); double gausite = kiekis / kursuMasyvas[valiuta - 1];
                            Console.WriteLine("Jus gausite: {0} EUR uz parduota kieki - {1} {2} ", gausite, kiekis, valiutuMasyvas[valiuta - 1]);

                        }

                        else if (operacija == 4)
                        {
                            Console.WriteLine("Iveskite nauja valiuta");
                            string valiutaNauja = Console.ReadLine();
                            Console.WriteLine("Iveskite nauja valiutos kursa:");
                            double kursasNaujas = Convert.ToDouble(Console.ReadLine());

                            valiutuMasyvas = valiutuMasyvas.Concat(new string[] { valiutaNauja }).ToArray();

                            kursuMasyvas = kursuMasyvas.Concat(new double[] { kursasNaujas }).ToArray();
                            Console.WriteLine("Naujas elementas {0} su kursu {1}", valiutuMasyvas[3], kursuMasyvas[3]);

                        }
                        else if (operacija == 5)
                        {
                            Console.WriteLine("Pasirinkite, kuria valiuta istrinsite: {0}", TurimiMasyvoElm(valiutuMasyvas));
                            int istrinti = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Elementas pries istrinant yra {0} su kursu {1}", valiutuMasyvas[istrinti - 1], kursuMasyvas[istrinti - 1]);
                            valiutuMasyvas = valiutuMasyvas.Where((source, index) => index != istrinti-1).ToArray();
                            kursuMasyvas = kursuMasyvas.Where((source, index) => index != istrinti - 1).ToArray();

                            Console.WriteLine("Patikrinti ar istrintas elementas yra {0} su kursu {1}", valiutuMasyvas[istrinti - 1], kursuMasyvas[istrinti - 1]);
                        }
                        else if (operacija == 6)
                        {


                            Console.WriteLine("Pasirinkite valiuta: {0}", TurimiMasyvoElm(valiutuMasyvas));
                            int pakeistiVal = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Iveskite nauja kursa");
                            double naujasKursas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Elementas pries pakeiciant yra {0} su kursu {1}", valiutuMasyvas[pakeistiVal - 1], kursuMasyvas[pakeistiVal - 1]);
                            kursuMasyvas[pakeistiVal - 1] = naujasKursas;
                            Console.WriteLine("Elementas po pakeitimo {0} su kursu {1}", valiutuMasyvas[pakeistiVal - 1], kursuMasyvas[pakeistiVal - 1]);
                        }

                    }
                    i++;
                }

            }
        }
    }
}

//Kokia operacija atliksite: 1 pirksite, 2 parduosite
//Pasirinkite valiuta: turi buti masyvas
//Iveskite kieki!
// Parasyti ar Jums reikia sumoketi, ar Jums priklauso X
// Masyva string masyvas
// Int masyvas valiutu




