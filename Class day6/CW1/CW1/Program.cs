using System;

namespace CW1
{
    class MainClass
    {
        public static string ArPalindromas(string s)
        {
            string newword = "";
            for (int i = s.Length-1; i >=0; i--)
            {
                newword = newword + s[i];
            }
            return newword;
        }




        public static void Main(string[] args)
        {
            string s = "abu gaiso po sia guba";
            string b = s.Replace(" ", "");


            Console.WriteLine(ArPalindromas(s));
            Console.WriteLine("Ar Polindromas: {0}", ArPalindromas(s).Replace(" ", "") == b);

        }
    }
}
