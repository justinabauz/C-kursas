using System;

namespace HW3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite darbuotojo ID:");
            string ID = Console.ReadLine();
            Console.WriteLine("Iveskite darbuotojo isdirbtas valandas");
            int valandos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite darbuotojo valandini ikaini");
            int ikainis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Darbuotojo ID: {0}", ID);
            Console.WriteLine("Darbuotojo alga: {0}", valandos * ikainis);
        }
    }
}
