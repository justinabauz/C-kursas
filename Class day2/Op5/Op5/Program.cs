using System;

namespace Op5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite staciakampio ilgi:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite staciakampio ploti:");
            int hight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Staciakampio plotas:{0}", width*hight);
        }
    }
}
