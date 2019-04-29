using System;

namespace Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string school = "Vilniaus licejus";
            string course = "IT";
            int numberOfstudents = 100;
            string date = DateTime.Now.ToString("d/MM/yyyy");
            Console.WriteLine("Mokykla - {0}, kursas - {1}, studentu skaicius - {2} ir laikas - {3}", school, course, numberOfstudents, date);
        }
    }
}
