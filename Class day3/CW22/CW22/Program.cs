using System;

namespace CW22
{
    class MainClass
    {
        public static void Main(string[] args)
        {


             
            string name2 = "Juste";
            string password2 = "labas";

            //bool result = name.Equals(name2, StringComparison.OrdinalIgnoreCase);
            //bool result2 = password.Equals(password2, StringComparison.OrdinalIgnoreCase);
            int i = 0;
            bool result = false;

            while ((result == false) && (i < 4))
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
