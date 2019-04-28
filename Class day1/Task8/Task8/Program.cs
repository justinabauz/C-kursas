using System;

namespace Task8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius (A,B,C):");
            string numberStr = Console.ReadLine();
            string[] splitted = numberStr.Split(',');
            int[] nums = new int[3];
            for (int i = 0; i < 3; i++)
            {
                nums[i] = int.Parse(splitted[i]);
            }
            Console.WriteLine("Atlikus skaiciavimus (A+B)*C gauname: {0}", (nums[0]+nums[1])*nums[2]);
            Console.WriteLine("Atlikus skaiciavimus A*C+B*C gauname: {0}", nums[0] *  nums[2] + nums[1]*nums[2]);
        }
    }
}
