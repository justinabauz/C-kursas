using System;

namespace Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int yearofBirth;
            string firstName;

            var lastName = "Pavardenis";
            decimal salary = 1999.9m;
            DateTime lastPayDay = DateTime.Today.AddMonths(-1);

            yearofBirth = 1990;
            firstName = "Vardenis";

            Console.WriteLine("Vardas, Pavarde: {0}, {0}", firstName, lastName);
            Console.WriteLine("Gimimo metai: {0}", yearofBirth);
            Console.WriteLine("Pajamos: {0}", salary);
            Console.WriteLine("Paskutini karta ismoketa alga: {0}", lastPayDay.ToLongDateString());
            Console.ReadLine();

        }
    }
}
