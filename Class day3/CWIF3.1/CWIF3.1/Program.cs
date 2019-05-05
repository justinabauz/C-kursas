using System;

namespace CWIF3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int nariuSkaicius = 0;
            bool result = true;
            Console.WriteLine("Iveskite gruopes nariu kieki:");
            result = int.TryParse(Console.ReadLine(), out nariuSkaicius);
            if (nariuSkaicius == 1)
            {
                Console.WriteLine("Tai solo atlikejas");
            }
            else if (nariuSkaicius == 2)
            {
                Console.WriteLine("Tai duetas");

            }

            else if (2 < nariuSkaicius && nariuSkaicius < 10)
            {
                Console.WriteLine("Tai ansamblis");

            }

            else if (nariuSkaicius > 10)
            {
                Console.WriteLine("Tai kamerinis ansamblis");

            }
            else if (result ==false) // geriau iskelti kaip atskira if
            {
                Console.WriteLine("Ivedete netesingai");
                Console.ReadLine();
            }
        }

    }
}
