using System;

namespace HW2
{
    class MainClass
    {

            public static string Ceasar(string value, int shift)
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
                Console.WriteLine("Iveskite raide");
                string letter1 = Console.ReadLine();
                Console.WriteLine("Iveskite skaiciu, per kiek raidziu perstumti raide:");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Ceasar(letter1, number1));
            }
        }
    }