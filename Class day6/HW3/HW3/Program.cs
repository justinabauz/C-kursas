using System;

namespace HW3
{
    class MainClass
    { 
            public static string Ceasar(string value, string key)
            {
                char[] buffer = value.ToCharArray();
                for (int i = 0; i < buffer.Length; i++)
                {
                    char letter = buffer[i];
                    letter = (char)(letter - shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    buffer[i] = letter;
                }
                return new string(buffer);

            }
            public static void Main(string[] args)
            {
                Console.WriteLine("Iveskite eilute");
                string letter1 = Console.ReadLine();
                Console.WriteLine("Iveskite rakto eilute");
                string letter2 = Console.ReadLine();

            Console.WriteLine(Ceasar(letter1, letter2));
            }
        }
    }
}
}
