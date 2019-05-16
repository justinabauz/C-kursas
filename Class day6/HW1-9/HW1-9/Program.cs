using System;

namespace HW19
{
    class MainClass
    {

        public static string RandomStr()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[10];
            var random = new Random();

            for (int i = 0; i<stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            return finalString;
            }

        public static void Main(string[] args)
        {
            Console.WriteLine("Atsitiktine eilute {0}", RandomStr());
        }
    }
}
