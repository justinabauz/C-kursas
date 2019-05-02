using System;

namespace CW22
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string name2 = "Juste";
            string password2 = "labas";

            int i = 0;
            bool result = false;

            while ((result == false) && (i < 3))
            {

                Console.WriteLine("Iveskite Varda");
                string name = Console.ReadLine();
                Console.WriteLine("Iveskite Slaptazodi:");
                string password = Console.ReadLine();
                result = name.Equals(name2, StringComparison.OrdinalIgnoreCase) &&
                     password.Equals(password2, StringComparison.OrdinalIgnoreCase);

               i++;

            }

                Console.WriteLine("Suvedete neteisinga varda arba slaptazodi {0}", result);
        }
    }
}
