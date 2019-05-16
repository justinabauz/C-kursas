using System;

namespace HW110
{
    class MainClass
    {
        public static string RandomStr(int counter)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[counter];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            return finalString;
        }

        public static void Main(string[] args)
        { 
            int counter = 3;
            Console.WriteLine("Atsitiktine eilute {0}", RandomStr(counter));
        }
    }
}
