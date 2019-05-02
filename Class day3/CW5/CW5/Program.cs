using System;

namespace CW5
{
    class Human
    {
        public string Name; // sukurem tipa
    }

        class MainClass
    {
        public static void Main(string[] args)
        {
            Human human1 = new Human(); // tokiu budu apsiraso naujo tipo aprasymas, su sudetiniais tipais 
            human1.Name = "Batman";

            Human human2 = human1;

            Console.WriteLine("human1.Name: " + human1.Name);
            Console.WriteLine("human2.Name: " + human2.Name);

            human1.Name = "Joker";

            Console.WriteLine("human1.Name: " + human1.Name);
            Console.WriteLine("human2.Name: " + human2.Name);

            Console.ReadLine();
        }
    }
}
