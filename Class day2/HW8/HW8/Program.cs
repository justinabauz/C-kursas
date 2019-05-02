using System;

namespace HW8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirmojo tasko koordinates:(X,Y)");
            string point1 = Console.ReadLine();
            string[] splitted = point1.Split(',');
            int[] nums1 = new int[2];
            for (int i = 0; i < 2; i++)
            {
                nums1[i] = int.Parse(splitted[i]);
            }
            Console.WriteLine("Iveskite antrojo tasko koordinates:(X1,Y1)");
            string point2 = Console.ReadLine();
            string[] splitted2 = point2.Split(',');
            int[] nums2 = new int[2];
            for (int i = 0; i < 2; i++)
            {
                nums2[i] = int.Parse(splitted2[i]);
            }
            Console.WriteLine("Iveskite treciojo tasko koordinates:(M,N)");
            string point3 = Console.ReadLine();
            string[] splitted3 = point3.Split(',');
            int[] nums3 = new int[2];
            for (int i = 0; i < 2; i++)
            {
                nums3[i] = int.Parse(splitted3[i]);
            }
            Console.WriteLine("Ar taskas (M,N) yra staciakampio viduje? {0}", nums1[0] <= nums3[0] && nums2[0] >= nums3[0] && nums1[1] <= nums3[1] && nums2[1] >= nums3[1]);
        }
    }
}
